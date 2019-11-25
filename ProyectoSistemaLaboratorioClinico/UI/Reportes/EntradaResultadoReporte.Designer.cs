namespace ProyectoSistemaLaboratorioClinico.UI.Reportes
{
    partial class EntradaResultadoReporte
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
            this.EntradaResultadosReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ListadoEntradaResultados1 = new ProyectoSistemaLaboratorioClinico.ListadoEntradaResultados();
            this.SuspendLayout();
            // 
            // EntradaResultadosReportViewer
            // 
            this.EntradaResultadosReportViewer.ActiveViewIndex = -1;
            this.EntradaResultadosReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntradaResultadosReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.EntradaResultadosReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntradaResultadosReportViewer.Location = new System.Drawing.Point(0, 0);
            this.EntradaResultadosReportViewer.Name = "EntradaResultadosReportViewer";
            this.EntradaResultadosReportViewer.ReportSource = this.ListadoEntradaResultados1;
            this.EntradaResultadosReportViewer.Size = new System.Drawing.Size(800, 450);
            this.EntradaResultadosReportViewer.TabIndex = 0;
            // 
            // EntradaResultadoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntradaResultadosReportViewer);
            this.Name = "EntradaResultadoReporte";
            this.Text = "EntradaResultadoReporte";
            this.Load += new System.EventHandler(this.EntradaResultadoReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer EntradaResultadosReportViewer;
        private ListadoEntradaResultados ListadoEntradaResultados1;
    }
}