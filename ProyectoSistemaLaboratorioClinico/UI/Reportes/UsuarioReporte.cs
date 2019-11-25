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
    public partial class UsuarioReporte : Form
    {
        private List<Usuarios> ListaUsuarios;
        public UsuarioReporte(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }


        private void UsuarioReporte_Load(object sender, EventArgs e)
        {
            ListadoUsuarios listadoUsuarios1 = new ListadoUsuarios();
            listadoUsuarios1.SetDataSource(ListaUsuarios);

            UsuarioReportViewer.ReportSource = listadoUsuarios1;
            UsuarioReportViewer.Refresh();
        }
    }
}
