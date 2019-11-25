namespace ProyectoSistemaLaboratorioClinico.UI.Registros
{
    partial class RAnalisis
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
            this.AnalisisIdlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Montolabel = new System.Windows.Forms.Label();
            this.BalanceAnalisislabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionAnalisistextBox = new System.Windows.Forms.TextBox();
            this.precioAnalisistextBox = new System.Windows.Forms.TextBox();
            this.TipoAnalisisIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TipoAnalisisIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalisisIdlabel
            // 
            this.AnalisisIdlabel.AutoSize = true;
            this.AnalisisIdlabel.Location = new System.Drawing.Point(20, 21);
            this.AnalisisIdlabel.Name = "AnalisisIdlabel";
            this.AnalisisIdlabel.Size = new System.Drawing.Size(54, 13);
            this.AnalisisIdlabel.TabIndex = 0;
            this.AnalisisIdlabel.Text = "Analisis Id";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(20, 57);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 1;
            this.Fechalabel.Text = "Fecha";
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.Location = new System.Drawing.Point(20, 95);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(63, 13);
            this.Montolabel.TabIndex = 3;
            this.Montolabel.Text = "Descripcion";
            // 
            // BalanceAnalisislabel
            // 
            this.BalanceAnalisislabel.AutoSize = true;
            this.BalanceAnalisislabel.Location = new System.Drawing.Point(19, 131);
            this.BalanceAnalisislabel.Name = "BalanceAnalisislabel";
            this.BalanceAnalisislabel.Size = new System.Drawing.Size(92, 13);
            this.BalanceAnalisislabel.TabIndex = 4;
            this.BalanceAnalisislabel.Text = "Precio del Analisis";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(117, 51);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.FechadateTimePicker.TabIndex = 12;
            // 
            // DescripcionAnalisistextBox
            // 
            this.DescripcionAnalisistextBox.Location = new System.Drawing.Point(117, 92);
            this.DescripcionAnalisistextBox.Name = "DescripcionAnalisistextBox";
            this.DescripcionAnalisistextBox.Size = new System.Drawing.Size(182, 20);
            this.DescripcionAnalisistextBox.TabIndex = 13;
            // 
            // precioAnalisistextBox
            // 
            this.precioAnalisistextBox.Location = new System.Drawing.Point(117, 128);
            this.precioAnalisistextBox.Name = "precioAnalisistextBox";
            this.precioAnalisistextBox.Size = new System.Drawing.Size(182, 20);
            this.precioAnalisistextBox.TabIndex = 14;
            // 
            // TipoAnalisisIdnumericUpDown
            // 
            this.TipoAnalisisIdnumericUpDown.Location = new System.Drawing.Point(117, 19);
            this.TipoAnalisisIdnumericUpDown.Name = "TipoAnalisisIdnumericUpDown";
            this.TipoAnalisisIdnumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.TipoAnalisisIdnumericUpDown.TabIndex = 26;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.trash_icon_125121;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(224, 162);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 25;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.save_icon_125167;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(117, 162);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 23;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.add_files_icon_125399;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(23, 162);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 22;
            this.Nuevobutton.Text = "   Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.search_icon_1251651;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(224, 7);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 36);
            this.Buscarbutton.TabIndex = 21;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 229);
            this.Controls.Add(this.TipoAnalisisIdnumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.precioAnalisistextBox);
            this.Controls.Add(this.DescripcionAnalisistextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.BalanceAnalisislabel);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.AnalisisIdlabel);
            this.Name = "RAnalisis";
            this.Text = "Registro Analisis";
            ((System.ComponentModel.ISupportInitialize)(this.TipoAnalisisIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnalisisIdlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.Label BalanceAnalisislabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox DescripcionAnalisistextBox;
        private System.Windows.Forms.TextBox precioAnalisistextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown TipoAnalisisIdnumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}