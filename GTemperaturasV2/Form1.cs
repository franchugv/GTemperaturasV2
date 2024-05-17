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

        // Agregar al fichero
        private void GuardarTemperatura()
        {
            string [] ListTemp = listBoxTemperatura.Items.Cast<string>().ToArray();

            if (listBoxTemperatura.Items.Count < 12) throw new Exception("Hay menos de 12 temperaturas");
         

            APIFichero.AgregarTemperaturas(comboBoxListaCiudades.Text, ListTemp);

            
        }

        // Agregar al listBox
        private void AgregarTemperatura()
        {

            if (listBoxTemperatura.Items.Count == 12)
            {
                listBoxTemperatura.Items.Clear();
            }
            // Inicializamos el boton a false, si todo es correcto se inicializara a true
            buttonAgregarTemp.Enabled = false;

            if (listBoxTemperatura.Items.Count <= 10)
            {
                buttonAgregarTemp.Enabled = true;
            }

            listBoxTemperatura.Items.Add(textBoxAgregarTemp.Text);


        }


        private void AgregarCiudad()
        {

            // Validar que no sea cadena vacía
            if (string.IsNullOrEmpty(textBoxAgregarCiudad.Text)) throw new Exception("Cadena vacía");

            // Limpiar ComboBos Ciudades
            comboBoxListaCiudades.Items.Clear();

            // Crear Fichero
            API.APIFichero.CrearFichero(textBoxAgregarCiudad.Text);

            // Añadir contenido al ComboBox
            CargarCiudades();

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
                CargarCiudades();

                APIFichero.CrearDirectorio();
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
            comboBoxListaCiudades.Items.Clear();
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

            listBoxTemperatura.Items.Clear();

            try
            {
                // Cargar temperaturas
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
                }

            }
        }
    }
}
