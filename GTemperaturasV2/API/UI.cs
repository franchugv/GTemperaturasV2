﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTemperaturasV2.API
{
    public static class UI
    {
        public static void MostrarError(string error)
        {
            MessageBox.Show($"Error: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarMensaje(string cadena)
        {
            MessageBox.Show(cadena, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
