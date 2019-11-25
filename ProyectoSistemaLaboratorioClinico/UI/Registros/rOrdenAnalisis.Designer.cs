namespace ProyectoSistemaLaboratorioClinico.UI.Consultas
{
    partial class rOrdenAnalisis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rOrdenAnalisis));
            this.AnalisisDetalleIdlabel = new System.Windows.Forms.Label();
            this.AnalisisdetalledataGridView = new System.Windows.Forms.DataGridView();
            this.AnalisisDetallenumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.PacienteComboBox = new System.Windows.Forms.ComboBox();
            this.AnalisisIdcomboBox = new System.Windows.Forms.ComboBox();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.MontoPagadolabel = new System.Windows.Forms.Label();
            this.MontoAnalisislabel = new System.Windows.Forms.Label();
            this.PacienteIdlabel = new System.Windows.Forms.Label();
            this.AnalisisIdlabel = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoverLineabutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BalancetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AnalisisdetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalisisDetallenumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // AnalisisDetalleIdlabel
            // 
            this.AnalisisDetalleIdlabel.AutoSize = true;
            this.AnalisisDetalleIdlabel.Location = new System.Drawing.Point(20, 25);
            this.AnalisisDetalleIdlabel.Name = "AnalisisDetalleIdlabel";
            this.AnalisisDetalleIdlabel.Size = new System.Drawing.Size(54, 13);
            this.AnalisisDetalleIdlabel.TabIndex = 0;
            this.AnalisisDetalleIdlabel.Text = "Analisis Id";
            // 
            // AnalisisdetalledataGridView
            // 
            this.AnalisisdetalledataGridView.AllowUserToAddRows = false;
            this.AnalisisdetalledataGridView.AllowUserToDeleteRows = false;
            this.AnalisisdetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnalisisdetalledataGridView.Location = new System.Drawing.Point(13, 75);
            this.AnalisisdetalledataGridView.Name = "AnalisisdetalledataGridView";
            this.AnalisisdetalledataGridView.ReadOnly = true;
            this.AnalisisdetalledataGridView.Size = new System.Drawing.Size(541, 134);
            this.AnalisisdetalledataGridView.TabIndex = 5;
            // 
            // AnalisisDetallenumericUpDown
            // 
            this.AnalisisDetallenumericUpDown.Location = new System.Drawing.Point(116, 23);
            this.AnalisisDetallenumericUpDown.Name = "AnalisisDetallenumericUpDown";
            this.AnalisisDetallenumericUpDown.Size = new System.Drawing.Size(73, 20);
            this.AnalisisDetallenumericUpDown.TabIndex = 6;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(450, 23);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FechadateTimePicker.TabIndex = 37;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(430, 268);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(121, 20);
            this.TotaltextBox.TabIndex = 36;
            // 
            // PacienteComboBox
            // 
            this.PacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PacienteComboBox.FormattingEnabled = true;
            this.PacienteComboBox.Location = new System.Drawing.Point(116, 67);
            this.PacienteComboBox.Name = "PacienteComboBox";
            this.PacienteComboBox.Size = new System.Drawing.Size(455, 21);
            this.PacienteComboBox.TabIndex = 34;
            // 
            // AnalisisIdcomboBox
            // 
            this.AnalisisIdcomboBox.FormattingEnabled = true;
            this.AnalisisIdcomboBox.Location = new System.Drawing.Point(92, 23);
            this.AnalisisIdcomboBox.Name = "AnalisisIdcomboBox";
            this.AnalisisIdcomboBox.Size = new System.Drawing.Size(121, 21);
            this.AnalisisIdcomboBox.TabIndex = 33;
            this.AnalisisIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.AnalisisIdcomboBox_SelectedIndexChanged);
            this.AnalisisIdcomboBox.SelectedValueChanged += new System.EventHandler(this.AnalisisIdcomboBox_SelectedValueChanged);
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(405, 25);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 31;
            this.Fechalabel.Text = "Fecha";
            // 
            // MontoPagadolabel
            // 
            this.MontoPagadolabel.AutoSize = true;
            this.MontoPagadolabel.Location = new System.Drawing.Point(359, 268);
            this.MontoPagadolabel.Name = "MontoPagadolabel";
            this.MontoPagadolabel.Size = new System.Drawing.Size(31, 13);
            this.MontoPagadolabel.TabIndex = 30;
            this.MontoPagadolabel.Text = "Total";
            // 
            // MontoAnalisislabel
            // 
            this.MontoAnalisislabel.AutoSize = true;
            this.MontoAnalisislabel.Location = new System.Drawing.Point(21, 24);
            this.MontoAnalisislabel.Name = "MontoAnalisislabel";
            this.MontoAnalisislabel.Size = new System.Drawing.Size(0, 13);
            this.MontoAnalisislabel.TabIndex = 29;
            // 
            // PacienteIdlabel
            // 
            this.PacienteIdlabel.AutoSize = true;
            this.PacienteIdlabel.Location = new System.Drawing.Point(20, 68);
            this.PacienteIdlabel.Name = "PacienteIdlabel";
            this.PacienteIdlabel.Size = new System.Drawing.Size(49, 13);
            this.PacienteIdlabel.TabIndex = 28;
            this.PacienteIdlabel.Text = "Paciente";
            // 
            // AnalisisIdlabel
            // 
            this.AnalisisIdlabel.AutoSize = true;
            this.AnalisisIdlabel.Location = new System.Drawing.Point(21, 26);
            this.AnalisisIdlabel.Name = "AnalisisIdlabel";
            this.AnalisisIdlabel.Size = new System.Drawing.Size(65, 13);
            this.AnalisisIdlabel.TabIndex = 27;
            this.AnalisisIdlabel.Text = "Tipo analisis";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(297, 23);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(184, 20);
            this.PreciotextBox.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Precio";
            // 
            // RemoverLineabutton
            // 
            this.RemoverLineabutton.Location = new System.Drawing.Point(10, 215);
            this.RemoverLineabutton.Name = "RemoverLineabutton";
            this.RemoverLineabutton.Size = new System.Drawing.Size(153, 23);
            this.RemoverLineabutton.TabIndex = 44;
            this.RemoverLineabutton.Text = "Remover Linea";
            this.RemoverLineabutton.UseVisualStyleBackColor = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(500, 21);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(66, 23);
            this.Agregarbutton.TabIndex = 45;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BalancetextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.PreciotextBox);
            this.groupBox1.Controls.Add(this.RemoverLineabutton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TotaltextBox);
            this.groupBox1.Controls.Add(this.AnalisisIdcomboBox);
            this.groupBox1.Controls.Add(this.MontoAnalisislabel);
            this.groupBox1.Controls.Add(this.AnalisisdetalledataGridView);
            this.groupBox1.Controls.Add(this.AnalisisIdlabel);
            this.groupBox1.Controls.Add(this.MontoPagadolabel);
            this.groupBox1.Location = new System.Drawing.Point(17, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 294);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // BalancetextBox
            // 
            this.BalancetextBox.Location = new System.Drawing.Point(430, 235);
            this.BalancetextBox.Name = "BalancetextBox";
            this.BalancetextBox.Size = new System.Drawing.Size(121, 20);
            this.BalancetextBox.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Balance";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.trash_icon_125121;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(406, 407);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 53);
            this.Eliminarbutton.TabIndex = 41;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(261, 407);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 53);
            this.Guardarbutton.TabIndex = 40;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.add_files_icon_125399;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(105, 407);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 53);
            this.Nuevobutton.TabIndex = 39;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(222, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 35);
            this.Buscarbutton.TabIndex = 38;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // rOrdenAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 465);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.PacienteComboBox);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.PacienteIdlabel);
            this.Controls.Add(this.AnalisisDetallenumericUpDown);
            this.Controls.Add(this.AnalisisDetalleIdlabel);
            this.Name = "rOrdenAnalisis";
            this.Text = "Toma de orden de analisis";
            ((System.ComponentModel.ISupportInitialize)(this.AnalisisdetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AnalisisDetallenumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AnalisisDetalleIdlabel;
        private System.Windows.Forms.DataGridView AnalisisdetalledataGridView;
        private System.Windows.Forms.NumericUpDown AnalisisDetallenumericUpDown;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ComboBox PacienteComboBox;
        private System.Windows.Forms.ComboBox AnalisisIdcomboBox;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label MontoPagadolabel;
        private System.Windows.Forms.Label MontoAnalisislabel;
        private System.Windows.Forms.Label PacienteIdlabel;
        private System.Windows.Forms.Label AnalisisIdlabel;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button RemoverLineabutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BalancetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}