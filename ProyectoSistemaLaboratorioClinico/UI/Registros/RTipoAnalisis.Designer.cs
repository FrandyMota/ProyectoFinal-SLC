namespace ProyectoSistemaLaboratorioClinico.UI.Registros
{
    partial class RTipoAnalisis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TipoAnalisisIdlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Preciolabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PrecioAnalisistextBox = new System.Windows.Forms.TextBox();
            this.DescripcionAnalisistextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.TipoAnalisisnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.VecestextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TipoAnalisisnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoAnalisisIdlabel
            // 
            this.TipoAnalisisIdlabel.AutoSize = true;
            this.TipoAnalisisIdlabel.Location = new System.Drawing.Point(28, 25);
            this.TipoAnalisisIdlabel.Name = "TipoAnalisisIdlabel";
            this.TipoAnalisisIdlabel.Size = new System.Drawing.Size(78, 13);
            this.TipoAnalisisIdlabel.TabIndex = 0;
            this.TipoAnalisisIdlabel.Text = "Tipo Analisis Id";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Location = new System.Drawing.Point(28, 62);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(100, 13);
            this.Descripcionlabel.TabIndex = 1;
            this.Descripcionlabel.Text = "Descripcion analisis";
            // 
            // Preciolabel
            // 
            this.Preciolabel.AutoSize = true;
            this.Preciolabel.Location = new System.Drawing.Point(28, 104);
            this.Preciolabel.Name = "Preciolabel";
            this.Preciolabel.Size = new System.Drawing.Size(74, 13);
            this.Preciolabel.TabIndex = 2;
            this.Preciolabel.Text = "Precio analisis";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(28, 184);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 3;
            this.Fechalabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(147, 178);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.FechadateTimePicker.TabIndex = 6;
            // 
            // PrecioAnalisistextBox
            // 
            this.PrecioAnalisistextBox.Location = new System.Drawing.Point(147, 101);
            this.PrecioAnalisistextBox.Name = "PrecioAnalisistextBox";
            this.PrecioAnalisistextBox.Size = new System.Drawing.Size(169, 20);
            this.PrecioAnalisistextBox.TabIndex = 7;
            // 
            // DescripcionAnalisistextBox
            // 
            this.DescripcionAnalisistextBox.Location = new System.Drawing.Point(147, 59);
            this.DescripcionAnalisistextBox.Name = "DescripcionAnalisistextBox";
            this.DescripcionAnalisistextBox.Size = new System.Drawing.Size(169, 20);
            this.DescripcionAnalisistextBox.TabIndex = 8;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.trash_icon_125121;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(241, 215);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 30;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.save_icon_125167;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(143, 215);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 57);
            this.Guardarbutton.TabIndex = 28;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.add_files_icon_125399;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(31, 215);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuevobutton.TabIndex = 27;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.search_icon_1251651;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(241, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 31);
            this.Buscarbutton.TabIndex = 26;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // TipoAnalisisnumericUpDown
            // 
            this.TipoAnalisisnumericUpDown.Location = new System.Drawing.Point(147, 23);
            this.TipoAnalisisnumericUpDown.Name = "TipoAnalisisnumericUpDown";
            this.TipoAnalisisnumericUpDown.Size = new System.Drawing.Size(50, 20);
            this.TipoAnalisisnumericUpDown.TabIndex = 31;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // VecestextBox
            // 
            this.VecestextBox.Location = new System.Drawing.Point(206, 138);
            this.VecestextBox.Name = "VecestextBox";
            this.VecestextBox.Size = new System.Drawing.Size(110, 20);
            this.VecestextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Veces que se han realizado analisis";
            // 
            // RTipoAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VecestextBox);
            this.Controls.Add(this.TipoAnalisisnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripcionAnalisistextBox);
            this.Controls.Add(this.PrecioAnalisistextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.Preciolabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.TipoAnalisisIdlabel);
            this.Name = "RTipoAnalisis";
            this.Text = "Registro Tipo Analisis";
            ((System.ComponentModel.ISupportInitialize)(this.TipoAnalisisnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipoAnalisisIdlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Preciolabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox PrecioAnalisistextBox;
        private System.Windows.Forms.TextBox DescripcionAnalisistextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown TipoAnalisisnumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox VecestextBox;
        private System.Windows.Forms.Label label1;
    }
}