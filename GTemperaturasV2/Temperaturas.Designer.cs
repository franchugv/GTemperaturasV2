namespace GTemperaturasV2
{
    partial class Temperaturas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAgregarCiudad = new System.Windows.Forms.Button();
            this.listBoxTemperatura = new System.Windows.Forms.ListBox();
            this.labelAgregarCiudad = new System.Windows.Forms.Label();
            this.textBoxAgregarCiudad = new System.Windows.Forms.TextBox();
            this.textBoxAgregarTemp = new System.Windows.Forms.TextBox();
            this.labelListaCiudades = new System.Windows.Forms.Label();
            this.comboBoxListaCiudades = new System.Windows.Forms.ComboBox();
            this.labelListaTemp = new System.Windows.Forms.Label();
            this.labelAgregarTemp = new System.Windows.Forms.Label();
            this.buttonAgregarTemp = new System.Windows.Forms.Button();
            this.buttonGuardarTemp = new System.Windows.Forms.Button();
            this.LabelContadorMes = new System.Windows.Forms.Label();
            this.labelMediaAnual = new System.Windows.Forms.Label();
            this.textBoxMediaAnual = new System.Windows.Forms.TextBox();
            this.buttonMediaAnual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgregarCiudad
            // 
            this.buttonAgregarCiudad.Location = new System.Drawing.Point(359, 52);
            this.buttonAgregarCiudad.Name = "buttonAgregarCiudad";
            this.buttonAgregarCiudad.Size = new System.Drawing.Size(123, 23);
            this.buttonAgregarCiudad.TabIndex = 1;
            this.buttonAgregarCiudad.Text = "Agregar Ciudad";
            this.buttonAgregarCiudad.UseVisualStyleBackColor = true;
            this.buttonAgregarCiudad.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // listBoxTemperatura
            // 
            this.listBoxTemperatura.FormattingEnabled = true;
            this.listBoxTemperatura.Location = new System.Drawing.Point(198, 194);
            this.listBoxTemperatura.Name = "listBoxTemperatura";
            this.listBoxTemperatura.Size = new System.Drawing.Size(132, 121);
            this.listBoxTemperatura.TabIndex = 2;
            // 
            // labelAgregarCiudad
            // 
            this.labelAgregarCiudad.AutoSize = true;
            this.labelAgregarCiudad.Location = new System.Drawing.Point(47, 55);
            this.labelAgregarCiudad.Name = "labelAgregarCiudad";
            this.labelAgregarCiudad.Size = new System.Drawing.Size(101, 13);
            this.labelAgregarCiudad.TabIndex = 0;
            this.labelAgregarCiudad.Text = "Escriba una ciudad:";
            // 
            // textBoxAgregarCiudad
            // 
            this.textBoxAgregarCiudad.Location = new System.Drawing.Point(198, 52);
            this.textBoxAgregarCiudad.Name = "textBoxAgregarCiudad";
            this.textBoxAgregarCiudad.Size = new System.Drawing.Size(134, 20);
            this.textBoxAgregarCiudad.TabIndex = 3;
            this.textBoxAgregarCiudad.TextChanged += new System.EventHandler(this.textBoxAgregarCiudad_TextChanged);
            // 
            // textBoxAgregarTemp
            // 
            this.textBoxAgregarTemp.Enabled = false;
            this.textBoxAgregarTemp.Location = new System.Drawing.Point(198, 136);
            this.textBoxAgregarTemp.Name = "textBoxAgregarTemp";
            this.textBoxAgregarTemp.Size = new System.Drawing.Size(132, 20);
            this.textBoxAgregarTemp.TabIndex = 5;
            // 
            // labelListaCiudades
            // 
            this.labelListaCiudades.AutoSize = true;
            this.labelListaCiudades.Location = new System.Drawing.Point(47, 92);
            this.labelListaCiudades.Name = "labelListaCiudades";
            this.labelListaCiudades.Size = new System.Drawing.Size(79, 13);
            this.labelListaCiudades.TabIndex = 4;
            this.labelListaCiudades.Text = "Lista Ciudades:";
            // 
            // comboBoxListaCiudades
            // 
            this.comboBoxListaCiudades.Location = new System.Drawing.Point(198, 92);
            this.comboBoxListaCiudades.Name = "comboBoxListaCiudades";
            this.comboBoxListaCiudades.Size = new System.Drawing.Size(132, 21);
            this.comboBoxListaCiudades.TabIndex = 6;
            this.comboBoxListaCiudades.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaCiudades_SelectedIndexChanged);
            // 
            // labelListaTemp
            // 
            this.labelListaTemp.AutoSize = true;
            this.labelListaTemp.Location = new System.Drawing.Point(48, 194);
            this.labelListaTemp.Name = "labelListaTemp";
            this.labelListaTemp.Size = new System.Drawing.Size(100, 13);
            this.labelListaTemp.TabIndex = 7;
            this.labelListaTemp.Text = "Lista Temperaturas:";
            // 
            // labelAgregarTemp
            // 
            this.labelAgregarTemp.AutoSize = true;
            this.labelAgregarTemp.Location = new System.Drawing.Point(47, 136);
            this.labelAgregarTemp.Name = "labelAgregarTemp";
            this.labelAgregarTemp.Size = new System.Drawing.Size(135, 13);
            this.labelAgregarTemp.TabIndex = 8;
            this.labelAgregarTemp.Text = "Lista Agregar Temperatura:";
            // 
            // buttonAgregarTemp
            // 
            this.buttonAgregarTemp.Enabled = false;
            this.buttonAgregarTemp.Location = new System.Drawing.Point(359, 136);
            this.buttonAgregarTemp.Name = "buttonAgregarTemp";
            this.buttonAgregarTemp.Size = new System.Drawing.Size(123, 23);
            this.buttonAgregarTemp.TabIndex = 9;
            this.buttonAgregarTemp.Text = "Agregar Temperatura";
            this.buttonAgregarTemp.UseVisualStyleBackColor = true;
            this.buttonAgregarTemp.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // buttonGuardarTemp
            // 
            this.buttonGuardarTemp.Enabled = false;
            this.buttonGuardarTemp.Location = new System.Drawing.Point(359, 194);
            this.buttonGuardarTemp.Name = "buttonGuardarTemp";
            this.buttonGuardarTemp.Size = new System.Drawing.Size(123, 23);
            this.buttonGuardarTemp.TabIndex = 10;
            this.buttonGuardarTemp.Text = "Guardar Lista";
            this.buttonGuardarTemp.UseVisualStyleBackColor = true;
            this.buttonGuardarTemp.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // LabelContadorMes
            // 
            this.LabelContadorMes.AutoSize = true;
            this.LabelContadorMes.Location = new System.Drawing.Point(48, 226);
            this.LabelContadorMes.Name = "LabelContadorMes";
            this.LabelContadorMes.Size = new System.Drawing.Size(30, 13);
            this.LabelContadorMes.TabIndex = 11;
            this.LabelContadorMes.Text = "Mes:";
            // 
            // labelMediaAnual
            // 
            this.labelMediaAnual.AutoSize = true;
            this.labelMediaAnual.Location = new System.Drawing.Point(48, 344);
            this.labelMediaAnual.Name = "labelMediaAnual";
            this.labelMediaAnual.Size = new System.Drawing.Size(69, 13);
            this.labelMediaAnual.TabIndex = 12;
            this.labelMediaAnual.Text = "Media Anual:";
            // 
            // textBoxMediaAnual
            // 
            this.textBoxMediaAnual.Location = new System.Drawing.Point(198, 344);
            this.textBoxMediaAnual.Name = "textBoxMediaAnual";
            this.textBoxMediaAnual.Size = new System.Drawing.Size(132, 20);
            this.textBoxMediaAnual.TabIndex = 13;
            // 
            // buttonMediaAnual
            // 
            this.buttonMediaAnual.Enabled = false;
            this.buttonMediaAnual.Location = new System.Drawing.Point(359, 342);
            this.buttonMediaAnual.Name = "buttonMediaAnual";
            this.buttonMediaAnual.Size = new System.Drawing.Size(123, 23);
            this.buttonMediaAnual.TabIndex = 14;
            this.buttonMediaAnual.Text = "Media Anual";
            this.buttonMediaAnual.UseVisualStyleBackColor = true;
            this.buttonMediaAnual.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 420);
            this.Controls.Add(this.buttonMediaAnual);
            this.Controls.Add(this.textBoxMediaAnual);
            this.Controls.Add(this.labelMediaAnual);
            this.Controls.Add(this.LabelContadorMes);
            this.Controls.Add(this.buttonGuardarTemp);
            this.Controls.Add(this.buttonAgregarTemp);
            this.Controls.Add(this.labelAgregarTemp);
            this.Controls.Add(this.labelListaTemp);
            this.Controls.Add(this.comboBoxListaCiudades);
            this.Controls.Add(this.textBoxAgregarTemp);
            this.Controls.Add(this.labelListaCiudades);
            this.Controls.Add(this.textBoxAgregarCiudad);
            this.Controls.Add(this.listBoxTemperatura);
            this.Controls.Add(this.buttonAgregarCiudad);
            this.Controls.Add(this.labelAgregarCiudad);
            this.Name = "Temperaturas";
            this.Text = "Temperaturas";
            this.Load += new System.EventHandler(this.Temperaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAgregarCiudad;
        private System.Windows.Forms.ListBox listBoxTemperatura;
        private System.Windows.Forms.Label labelAgregarCiudad;
        private System.Windows.Forms.TextBox textBoxAgregarCiudad;
        private System.Windows.Forms.TextBox textBoxAgregarTemp;
        private System.Windows.Forms.Label labelListaCiudades;
        private System.Windows.Forms.ComboBox comboBoxListaCiudades;
        private System.Windows.Forms.Label labelListaTemp;
        private System.Windows.Forms.Label labelAgregarTemp;
        private System.Windows.Forms.Button buttonAgregarTemp;
        private System.Windows.Forms.Button buttonGuardarTemp;
        private System.Windows.Forms.Label LabelContadorMes;
        private System.Windows.Forms.Label labelMediaAnual;
        private System.Windows.Forms.TextBox textBoxMediaAnual;
        private System.Windows.Forms.Button buttonMediaAnual;
    }
}

