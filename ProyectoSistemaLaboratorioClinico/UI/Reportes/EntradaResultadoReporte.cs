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
    public partial class EntradaResultadoReporte : Form
    {
        private List<EntradaResultados> ListaEntradaResultados;
        public EntradaResultadoReporte(List<EntradaResultados> entradaResultados)
        {
            this.ListaEntradaResultados = entradaResultados;
            InitializeComponent();
        }

        private void EntradaResultadoReporte_Load(object sender, EventArgs e)
        {
            ListadoEntradaResultados listadoEntradaResultados1 = new ListadoEntradaResultados();
            listadoEntradaResultados1.SetDataSource(ListaEntradaResultados);

            EntradaResultadosReportViewer.ReportSource = listadoEntradaResultados1;
            EntradaResultadosReportViewer.Refresh();
        }
    }
}
