using ProyectoSistemaLaboratorioClinico.UI.Consultas;
using ProyectoSistemaLaboratorioClinico.UI.Registros;
using ProyectoSistemaLaboratorioClinico.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaLaboratorioClinico
{
    public partial class MainForm : Form
    {
        public MainForm(int id)
        {
            InitializeComponent();
           // IdUsario = Id;
        }

        public int IdUsario { get; set; }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RUsuarios fmr = new RUsuarios(IdUsario);
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }

        private void analisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RAnalisis fmr = new RAnalisis(IdUsario);
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPaciente fmr = new RPaciente(IdUsario);
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }

        private void tipoDeAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RTipoAnalisis fmr = new RTipoAnalisis();
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }

        private void ordenAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rOrdenAnalisis fmr = new rOrdenAnalisis(IdUsario);
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }

        private void entradaDeResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaResultados fmr = new rEntradaResultados(IdUsario);
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }
        //Consultas
        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios frm = new cUsuarios(0);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void analisisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAnalisis frm = new cAnalisis(IdUsario);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cPaciente frm = new cPaciente(IdUsario);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void tipoAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTipoAnalisis frm = new cTipoAnalisis(IdUsario);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void ordenAnalisisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cOrdenAnalisis frm = new cOrdenAnalisis(IdUsario);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void entradaDeResultadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEntradaResultados frm = new cEntradaResultados(IdUsario);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void informaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe frm = new AcercaDe();
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }
    }


}
