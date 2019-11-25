using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaLaboratorioClinico.UI.Reportes
{
    public partial class TipoAnalisisReporte : Form
    {
        private List<TipoAnalisis> ListaTipoAnalisis;
        public TipoAnalisisReporte(List<TipoAnalisis> tipoAnalisis)
        {
            this.ListaTipoAnalisis = tipoAnalisis;
            InitializeComponent();
        }

        private void TipoAnalisisReporte_Load(object sender, EventArgs e)
        {
            ListadoTipoAnalisis listadoTipoAnalisis1 = new ListadoTipoAnalisis();
            listadoTipoAnalisis1.SetDataSource(ListaTipoAnalisis);

            TipoAnalisisReportViewer.ReportSource = listadoTipoAnalisis1;
            TipoAnalisisReportViewer.Refresh();
        }
    }
}
