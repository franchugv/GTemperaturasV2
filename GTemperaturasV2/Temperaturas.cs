using GTemperaturasV2.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTemperaturasV2
{
    public partial class Temperaturas : Form
    {
        public Temperaturas()
        {
            InitializeComponent();
        }

        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos

            Button opcion = (Button) sender;
            bool esValido = true; // Inicializado a TRUE
            string MensajeError = "";


            try
            {
                switch (opcion.Name)
                {
                    case "buttonAgregarCiudad":
                        AgregarCiudad();
                        break;
                    case "buttonAgregarTemp":
                        AgregarTemperatura();
                        break;
                    case "buttonGuardarTemp":
                        GuardarTemperatura();
                        break;
                    case "buttonMediaAnual":
                        MediaAnual();
                        break;
                }
            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    UI.MostrarError(MensajeError);
                    CargarCiudades();

                    textBoxAgregarCiudad.Text = "";

                    buttonAgregarTemp.Enabled = false;
                    textBoxAgregarTemp.Enabled = false;
                    buttonAgregarCiudad.Enabled = false;
                    buttonGuardarTemp.Enabled = false;
                }


            }           
        }


        private void MediaAnual()
        {
            string[]ListaTemp = APIFichero.ConsultarFicheroSinFormato(comboBoxListaCiudades.Text).Cast<string>().ToArray(); // Lista Temperaturas

            float temperaturaActual;

            float TotalTemp = listBoxTemperatura.Items.Count;

            float sumaTemp = 0;
            float result = 0;



            // Calculo

            for(int indice = 0; indice < ListaTemp.Length; indice++)
            {
                temperaturaActual = Convert.ToSingle(ListaTemp[indice]);

                sumaTemp += temperaturaActual;
            }

            result = sumaTemp / TotalTemp;

            if (result == 0) throw new Exception("Cadena vacía");

            textBoxMediaAnual.Text = result.ToString() + "Cº";

        }




        // Agregar al fichero
        private void GuardarTemperatura()
        {
            string [] ListTemp = listBoxTemperatura.Items.Cast<string>().ToArray();
            int aux = 0;

            // Validar que sea numerico
            for(int indice = 0; indice < ListTemp.Length; indice++)
            {
                if (!Int32.TryParse(ListTemp[indice], out aux)) throw new Exception("Solo caracteres numéricos");
            }

            // En caso de que haya menos de 12 temperaturas no podremos agregar nada
            if (listBoxTemperatura.Items.Count < 12) throw new Exception("Hay menos de 12 temperaturas");
         
            // Agregamos el Array que el la lista de temperaturas del ListBox al fichero seleccionado con el ComboBox
            APIFichero.AgregarTemperaturas(comboBoxListaCiudades.Text, ListTemp);


            UI.MostrarMensaje($"La lista a sido agregada correctamente a la ciudad {comboBoxListaCiudades.Text}");

            listBoxTemperatura.Items.Clear();
            textBoxAgregarTemp.Text = "";


        }

        // Agregar al listBox
        private void AgregarTemperatura()
        {
            int aux = 0;
            // Comprobar que sea un número
            if(!Int32.TryParse(textBoxAgregarTemp.Text, out aux)) throw new Exception("Solo caracteres numéricos");

            // Si intentamos añadir mas temperaturas, la lista de reseteará
            if (listBoxTemperatura.Items.Count == 12) 
            {
                listBoxTemperatura.Items.Clear();
                LabelContadorMes.Text = "Mes: ";
            } 

            // Inicializamos el botón a false, si todo es correcto se inicializara a true
            buttonAgregarTemp.Enabled = false;
            // Si hay 12 temperaturas o menos el botón seguirá activo,
            // en caso contrario se quedará false ya que lo inicializamos a false anteriormente


            if (listBoxTemperatura.Items.Count <= 10)
            {
                buttonAgregarTemp.Enabled = true;
            }


            // Agregamos el contenido del texto a la lista
            listBoxTemperatura.Items.Add(textBoxAgregarTemp.Text);

            LabelContadorMes.Text = $"Mes: {listBoxTemperatura.Items.Count}";

            // Lo limpiamos para que sea mas cómodo
            textBoxAgregarTemp.Clear();

        }


        private void AgregarCiudad()
        {

            // Validar que no sea cadena vacía
            if (string.IsNullOrEmpty(textBoxAgregarCiudad.Text)) throw new Exception("Cadena vacía");

            // Limpiar ComboBox Ciudades
            comboBoxListaCiudades.Items.Clear();

            // Crear Fichero
            API.APIFichero.CrearFichero(textBoxAgregarCiudad.Text);

            // Añadir contenido al ComboBox
            CargarCiudades();

            // Mostramos un mensaje de que se a agregado correctamente
            UI.MostrarMensaje($"La ciudad {textBoxAgregarCiudad.Text} a sido agregada correctamente");

            // Limpiar Texto
            textBoxAgregarCiudad.Text = "";

        }




        private void Temperaturas_Load(object sender, EventArgs e)
        {



            // Recursos

            bool esValido = true; // Inicializado a TRUE
            string MensajeError = "";

            try
            {
                // Cargamos las ciudades cada vez que se inicie el programa
                // y además comprobamos el el directorio esté creado correctamente
                APIFichero.CrearDirectorio();

                CargarCiudades();

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    UI.MostrarError(MensajeError);
                }

            }


        }


        private void CargarCiudades()
        {
            // Hay que limpiar la lista de ciudades para que no se solapen
            comboBoxListaCiudades.Items.Clear();

            // Agregamos el contendido del fichero a la lista
            comboBoxListaCiudades.Items.AddRange(API.APIFichero.ConsultarDirectorio());
        }



        private void comboBoxListaCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recursos

            bool esValido = true;
            string MensajeError = "";

            // Inicializar Botones

            buttonAgregarTemp.Enabled = false;
            textBoxAgregarTemp.Enabled = false;
            buttonAgregarCiudad.Enabled = false;
            buttonGuardarTemp.Enabled = false;

            // Limpiar el ListBox para que no se solape con el anterior
            listBoxTemperatura.Items.Clear();

            try
            {
                // Cargar temperaturas de la ciudad seleccionada usando el contenido de su fichero
                listBoxTemperatura.Items.AddRange(APIFichero.ConsultarFichero(comboBoxListaCiudades.Text));

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {

                if (!esValido)
                {
                    UI.MostrarError(MensajeError);

                    textBoxAgregarTemp.Enabled = false;
                    buttonAgregarTemp.Enabled = false;
                    buttonAgregarCiudad.Enabled = false;
                    buttonGuardarTemp.Enabled = false;
                }
                else
                {
                    textBoxAgregarTemp.Enabled = true;
                    buttonAgregarTemp .Enabled = true;
                    buttonAgregarCiudad.Enabled = true;
                    buttonGuardarTemp.Enabled = true;

                    if (listBoxTemperatura.Items.Count == 12)
                    {
                        buttonMediaAnual.Enabled = true;
                    }
                }


            }
        }

        private void textBoxAgregarCiudad_TextChanged(object sender, EventArgs e)
        {
            // Recursos



            bool esValido = true;
            string MensajeError = "";



            try
            {

               

                if (!string.IsNullOrEmpty(textBoxAgregarCiudad.Text))
                {
                    comboBoxListaCiudades.Text = textBoxAgregarCiudad.Text;
                }

            }
            catch (Exception error)
            {
                esValido = false;
                MensajeError = error.Message;
            }
            finally
            {

                if (!esValido)
                {
                    UI.MostrarError(MensajeError);

                   
                }


            }
        }
    }
}
