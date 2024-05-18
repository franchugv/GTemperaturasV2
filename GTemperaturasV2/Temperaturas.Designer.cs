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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAgregarTemp = new System.Windows.Forms.Button();
            this.buttonGuardarTemp = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Temperaturas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lista Agregar Temperatura:";
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
            // Temperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 353);
            this.Controls.Add(this.buttonGuardarTemp);
            this.Controls.Add(this.buttonAgregarTemp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAgregarTemp;
        private System.Windows.Forms.Button buttonGuardarTemp;
    }
}

