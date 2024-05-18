using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTemperaturasV2.API
{
    public static class APIFichero
    {

        // Recursos

        private const string DIRECTORIO = "Ciudades\\";
        private const string EXTENSION = ".tmp";

        // MÉTODOS PUBLICOS

        #region Creación Ficheros
        /// <summary>
        /// Crear Directorio en caso de que no exista
        /// </summary>
        public static void CrearDirectorio()
        {
            if (!Directory.Exists(DIRECTORIO))
            {
                Directory.CreateDirectory(DIRECTORIO);
            }
        }

        /// <summary>
        /// Crear fichero con un nombre seleccionado
        /// </summary>
        /// <param name="nombre">Nombre de el fichero</param>
        public static void CrearFichero(string nombre)
        {
            // Recursos
            StreamWriter escritor = null;

            // Validar que el fichero no exista

            VerificarExistencia(nombre);

            if (!File.Exists(DIRECTORIO+nombre+EXTENSION))
            {
                escritor = File.CreateText(DIRECTORIO+nombre+EXTENSION);

                escritor.Close();

            }

        }
        #endregion


        #region Escribir Ficheros
        /// <summary>
        /// Agregar lista de temperaturas a un fichero en concreto
        /// </summary>
        /// <param name="nombre">Nombre de el fichero</param>
        /// <param name="ListaTemperaturas">Lista de temperaturas a añadir</param>
        public static void AgregarTemperaturas(string nombre, string[] ListaTemperaturas)
        {
            // Recursos
            StreamWriter escritor;

            escritor = File.CreateText(DIRECTORIO+nombre+EXTENSION);

            for(int indice = 0; indice < ListaTemperaturas.Length; indice++)
            {
                escritor.WriteLine(ListaTemperaturas[indice]);
            }

            escritor.Close();


        }

        #endregion


        #region Consultas

        /// <summary>
        /// Consultar Directorio
        /// </summary>
        /// <returns>Array con el contenido del directorio</returns>
        public static string[] ConsultarDirectorio()
        {
            // Recursos
            string[] ListaDirectorio;
            string cadena;

            ListaDirectorio = Directory.GetFiles(DIRECTORIO);

            // Limpiar Contenido Directorio/nombre.txt --> nombre

            for(int indice = 0; indice < ListaDirectorio.Length; indice++)
            {
                cadena = ListaDirectorio[indice];

                cadena = cadena.Substring(cadena.IndexOf("\\") + 1);
                cadena = cadena.Substring(0, cadena.IndexOf("."));

                ListaDirectorio[indice] = cadena;

            }

            return ListaDirectorio;


        }


        /// <summary>
        /// Consultar fichero seleccionado
        /// </summary>
        /// <param name="nombre">Nombre de el fichero</param>
        /// <returns>Array con el contenido del fichero</returns>
        public static string[] ConsultarFichero(string nombre)
        {
            // Recursos
            string[] ListaTemp;

            ListaTemp = File.ReadAllLines(DIRECTORIO+nombre+EXTENSION);


            return ListaTemp;
        }

        #endregion

        /// <summary>
        /// Verificar que no exista el fichero
        /// </summary>
        /// <param name="fichero">Nombre de el fichero</param>
        /// <exception cref="Exception">Fichero repetido</exception>
        public static void VerificarExistencia(string fichero)
        {
            string aux = "";

            // Remover mayúsculas y espacios
            fichero = fichero.ToLower().Trim();

            foreach(string cadena in ConsultarDirectorio())
            {
                // Remover mayusculas y espacios
                aux = cadena.Trim().ToLower();

                if (fichero.Contains(aux)) throw new Exception("Archivo repetido");
            }
        }

        // MÉTODOS PRIVADOS


    }
}
