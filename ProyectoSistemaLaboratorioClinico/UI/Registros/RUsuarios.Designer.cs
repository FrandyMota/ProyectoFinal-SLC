﻿namespace ProyectoSistemaLaboratorioClinico.UI.Registros
{
    partial class RUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UsuarioIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.NivelUsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.FechaIngresodatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmarClavetextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel de usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha";
            // 
            // UsuarioIdnumericUpDown
            // 
            this.UsuarioIdnumericUpDown.Location = new System.Drawing.Point(136, 25);
            this.UsuarioIdnumericUpDown.Name = "UsuarioIdnumericUpDown";
            this.UsuarioIdnumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.UsuarioIdnumericUpDown.TabIndex = 6;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(136, 88);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(200, 20);
            this.NombretextBox.TabIndex = 7;
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(136, 126);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(200, 20);
            this.EmailtextBox.TabIndex = 8;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(136, 230);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(200, 20);
            this.ClavetextBox.TabIndex = 9;
            // 
            // NivelUsuariocomboBox
            // 
            this.NivelUsuariocomboBox.FormattingEnabled = true;
            this.NivelUsuariocomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.NivelUsuariocomboBox.Location = new System.Drawing.Point(136, 164);
            this.NivelUsuariocomboBox.Name = "NivelUsuariocomboBox";
            this.NivelUsuariocomboBox.Size = new System.Drawing.Size(201, 21);
            this.NivelUsuariocomboBox.TabIndex = 10;
            // 
            // FechaIngresodatedateTimePicker
            // 
            this.FechaIngresodatedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresodatedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresodatedateTimePicker.Location = new System.Drawing.Point(136, 56);
            this.FechaIngresodatedateTimePicker.Name = "FechaIngresodatedateTimePicker";
            this.FechaIngresodatedateTimePicker.Size = new System.Drawing.Size(201, 20);
            this.FechaIngresodatedateTimePicker.TabIndex = 11;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.add_files_icon_125399;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(43, 293);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 59);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.save_icon_125167;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(157, 293);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 59);
            this.Guardarbutton.TabIndex = 13;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.search_icon_1251651;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(261, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 33);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoSistemaLaboratorioClinico.Properties.Resources.trash_icon_125121;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(261, 293);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 59);
            this.Eliminarbutton.TabIndex = 16;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ConfirmarClavetextBox
            // 
            this.ConfirmarClavetextBox.Location = new System.Drawing.Point(136, 265);
            this.ConfirmarClavetextBox.Name = "ConfirmarClavetextBox";
            this.ConfirmarClavetextBox.PasswordChar = '*';
            this.ConfirmarClavetextBox.Size = new System.Drawing.Size(200, 20);
            this.ConfirmarClavetextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = " Confirmar contraseña";
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(136, 201);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(200, 20);
            this.UsuariotextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Usuario";
            // 
            // RUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 358);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ConfirmarClavetextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechaIngresodatedateTimePicker);
            this.Controls.Add(this.NivelUsuariocomboBox);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.UsuarioIdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RUsuarios";
            this.Text = "Registro Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown UsuarioIdnumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.ComboBox NivelUsuariocomboBox;
        private System.Windows.Forms.DateTimePicker FechaIngresodatedateTimePicker;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox ConfirmarClavetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.Label label8;
    }
}