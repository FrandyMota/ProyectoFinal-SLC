namespace ProyectoSistemaLaboratorioClinico.UI.Reportes
{
    partial class UsuarioReporte
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
            this.UsuarioReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
//            this.ListadoUsuarios1 = new ProyectoSistemaLaboratorioClinico.ListadoUsuarios();
            this.SuspendLayout();
            // 
            // UsuarioReportViewer
            // 
            this.UsuarioReportViewer.ActiveViewIndex = -1;
            this.UsuarioReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsuarioReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsuarioReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UsuarioReportViewer.Name = "UsuarioReportViewer";
//            this.UsuarioReportViewer.ReportSource = this.ListadoUsuarios1;
            this.UsuarioReportViewer.Size = new System.Drawing.Size(800, 450);
            this.UsuarioReportViewer.TabIndex = 0;
            // 
            // UsuarioReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsuarioReportViewer);
            this.Name = "UsuarioReporte";
            this.Text = "UsuarioReporte";
            this.Load += new System.EventHandler(this.UsuarioReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer UsuarioReportViewer;
        private ListadoUsuarios ListadoUsuarios1;
    }
}