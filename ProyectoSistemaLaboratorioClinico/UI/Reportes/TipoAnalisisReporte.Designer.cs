namespace ProyectoSistemaLaboratorioClinico.UI.Reportes
{
    partial class TipoAnalisisReporte
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
            this.TipoAnalisisReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            //this.ListadoTipoAnalisis1 = new ProyectoSistemaLaboratorioClinico.ListadoTipoAnalisis();
            this.SuspendLayout();
            // 
            // TipoAnalisisReportViewer
            // 
            this.TipoAnalisisReportViewer.ActiveViewIndex = -1;
            this.TipoAnalisisReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TipoAnalisisReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.TipoAnalisisReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TipoAnalisisReportViewer.Location = new System.Drawing.Point(0, 0);
            this.TipoAnalisisReportViewer.Name = "TipoAnalisisReportViewer";
          //  this.TipoAnalisisReportViewer.ReportSource = this.ListadoTipoAnalisis1;
            this.TipoAnalisisReportViewer.Size = new System.Drawing.Size(800, 450);
            this.TipoAnalisisReportViewer.TabIndex = 0;
            // 
            // TipoAnalisisReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TipoAnalisisReportViewer);
            this.Name = "TipoAnalisisReporte";
            this.Text = "TipoAnalisisReporte";
            this.Load += new System.EventHandler(this.TipoAnalisisReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer TipoAnalisisReportViewer;
       // private ListadoTipoAnalisis ListadoTipoAnalisis1;
    }
}