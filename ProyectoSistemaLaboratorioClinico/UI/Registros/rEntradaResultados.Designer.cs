namespace ProyectoSistemaLaboratorioClinico.UI.Registros
{
    partial class rEntradaResultados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEntradaResultados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MontoAnalisislabel = new System.Windows.Forms.Label();
            this.EntradadetalledataGridView = new System.Windows.Forms.DataGridView();
            this.PacientetextBox = new System.Windows.Forms.TextBox();
            this.AnalisisIdlabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OrdencomboBox = new System.Windows.Forms.ComboBox();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.PacienteIdlabel = new System.Windows.Forms.Label();
            this.EntradaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AnalisisDetalleIdlabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarOrdenbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntradadetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MontoAnalisislabel);
            this.groupBox1.Controls.Add(this.EntradadetalledataGridView);
            this.groupBox1.Location = new System.Drawing.Point(28, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 191);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // MontoAnalisislabel
            // 
            this.MontoAnalisislabel.AutoSize = true;
            this.MontoAnalisislabel.Location = new System.Drawing.Point(21, 24);
            this.MontoAnalisislabel.Name = "MontoAnalisislabel";
            this.MontoAnalisislabel.Size = new System.Drawing.Size(0, 13);
            this.MontoAnalisislabel.TabIndex = 29;
            // 
            // EntradadetalledataGridView
            // 
            this.EntradadetalledataGridView.AllowUserToOrderColumns = true;
            this.EntradadetalledataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EntradadetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EntradadetalledataGridView.Location = new System.Drawing.Point(7, 19);
            this.EntradadetalledataGridView.Name = "EntradadetalledataGridView";
            this.EntradadetalledataGridView.Size = new System.Drawing.Size(541, 134);
            this.EntradadetalledataGridView.TabIndex = 5;
            // 
            // PacientetextBox
            // 
            this.PacientetextBox.Location = new System.Drawing.Point(127, 103);
            this.PacientetextBox.Name = "PacientetextBox";
            this.PacientetextBox.ReadOnly = true;
            this.PacientetextBox.Size = new System.Drawing.Size(455, 20);
            this.PacientetextBox.TabIndex = 43;
            // 
            // AnalisisIdlabel
            // 
            this.AnalisisIdlabel.AutoSize = true;
            this.AnalisisIdlabel.Location = new System.Drawing.Point(25, 106);
            this.AnalisisIdlabel.Name = "AnalisisIdlabel";
            this.AnalisisIdlabel.Size = new System.Drawing.Size(49, 13);
            this.AnalisisIdlabel.TabIndex = 27;
            this.AnalisisIdlabel.Text = "Paciente";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(455, 18);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FechadateTimePicker.TabIndex = 52;
            // 
            // OrdencomboBox
            // 
            this.OrdencomboBox.FormattingEnabled = true;
            this.OrdencomboBox.Location = new System.Drawing.Point(127, 62);
            this.OrdencomboBox.Name = "OrdencomboBox";
            this.OrdencomboBox.Size = new System.Drawing.Size(203, 21);
            this.OrdencomboBox.TabIndex = 51;
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(410, 20);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 50;
            this.Fechalabel.Text = "Fecha";
            // 
            // PacienteIdlabel
            // 
            this.PacienteIdlabel.AutoSize = true;
            this.PacienteIdlabel.Location = new System.Drawing.Point(31, 63);
            this.PacienteIdlabel.Name = "PacienteIdlabel";
            this.PacienteIdlabel.Size = new System.Drawing.Size(36, 13);
            this.PacienteIdlabel.TabIndex = 49;
            this.PacienteIdlabel.Text = "Orden";
            // 
            // EntradaIdnumericUpDown
            // 
            this.EntradaIdnumericUpDown.Location = new System.Drawing.Point(127, 18);
            this.EntradaIdnumericUpDown.Name = "EntradaIdnumericUpDown";
            this.EntradaIdnumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.EntradaIdnumericUpDown.TabIndex = 48;
            // 
            // AnalisisDetalleIdlabel
            // 
            this.AnalisisDetalleIdlabel.AutoSize = true;
            this.AnalisisDetalleIdlabel.Location = new System.Drawing.Point(31, 20);
            this.AnalisisDetalleIdlabel.Name = "AnalisisDetalleIdlabel";
            this.AnalisisDetalleIdlabel.Size = new System.Drawing.Size(56, 13);
            this.AnalisisDetalleIdlabel.TabIndex = 47;
            this.AnalisisDetalleIdlabel.Text = "Entrada Id";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BuscarOrdenbutton
            // 
            this.BuscarOrdenbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.search_icon_1251651;
            this.BuscarOrdenbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarOrdenbutton.Location = new System.Drawing.Point(344, 54);
            this.BuscarOrdenbutton.Name = "BuscarOrdenbutton";
            this.BuscarOrdenbutton.Size = new System.Drawing.Size(106, 35);
            this.BuscarOrdenbutton.TabIndex = 58;
            this.BuscarOrdenbutton.Text = "Buscar Orden";
            this.BuscarOrdenbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarOrdenbutton.UseVisualStyleBackColor = true;
            this.BuscarOrdenbutton.Click += new System.EventHandler(this.BuscarOrdenbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(400, 340);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 56;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(255, 340);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 55;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.add_files_icon_125399;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(99, 340);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 54;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.search_icon_1251651;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(250, 5);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 37);
            this.Buscarbutton.TabIndex = 53;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rEntradaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 398);
            this.Controls.Add(this.BuscarOrdenbutton);
            this.Controls.Add(this.PacientetextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.OrdencomboBox);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.PacienteIdlabel);
            this.Controls.Add(this.EntradaIdnumericUpDown);
            this.Controls.Add(this.AnalisisIdlabel);
            this.Controls.Add(this.AnalisisDetalleIdlabel);
            this.Name = "rEntradaResultados";
            this.Text = "Registro Entrada Resultados";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntradadetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PacientetextBox;
        private System.Windows.Forms.Label MontoAnalisislabel;
        private System.Windows.Forms.DataGridView EntradadetalledataGridView;
        private System.Windows.Forms.Label AnalisisIdlabel;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.ComboBox OrdencomboBox;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label PacienteIdlabel;
        private System.Windows.Forms.NumericUpDown EntradaIdnumericUpDown;
        private System.Windows.Forms.Label AnalisisDetalleIdlabel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button BuscarOrdenbutton;
    }
}