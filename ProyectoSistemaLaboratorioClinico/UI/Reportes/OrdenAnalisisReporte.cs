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
    public partial class OrdenAnalisisReporte : Form
    {
        private List<OrdenAnalisis> ListaOrdenAnalisis;
        public OrdenAnalisisReporte(List<OrdenAnalisis> ordenAnalisis)
        {
            this.ListaOrdenAnalisis = ordenAnalisis;
            InitializeComponent();
        }

        private void OrdenAnalisisReporte_Load(object sender, EventArgs e)
        {
            ListadoOrdenAnalisis listadoOrdenAnalisis1 = new ListadoOrdenAnalisis();
            listadoOrdenAnalisis1.SetDataSource(ListaOrdenAnalisis);

            OrdenAnalisisReportViewer.ReportSource = listadoOrdenAnalisis1;
            OrdenAnalisisReportViewer.Refresh();
        }
    }
}
