using BLL;
using Entidades;
using ProyectoSistemaLaboratorioClinico.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSistemaLaboratorioClinico.UI.Consultas
{
    public partial class cEntradaResultados : Form
    {
        public List<EntradaResultados> ListaEntradaResultados;
        public cEntradaResultados(int valor)
        {
            InitializeComponent();
            FiltrocomboBox.Text = "Todo";

            if (valor == 1)
            {
                Imprimirbutton.Visible = false;

            }
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<EntradaResultados> db = new RepositorioBase<EntradaResultados>();
            var listado = new List<EntradaResultados>();
            if (FiltroFecha.Checked == true)
            {
                try
                {
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "EntradaId":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.EntradaId == id);
                                break;

                            case "UsuarioId":
                                int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == UsuarioId);
                                break;

                            case "PacienteId":
                                int ProductoId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.PacienteId == ProductoId);
                                break;

                            case "OrdenId":
                                int Entrada = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.OrdenId == Entrada);
                                break;




                            default:
                                break;
                        }
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    }
                    else
                    {

                        listado = db.GetList(p => true);
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    }

                    ListaEntradaResultados = listado;
                    ConsultadataGridView.DataSource = ListaEntradaResultados;

                }
                catch (Exception)
                {
                    MessageBox.Show("Introdujo un dato incorrecto");

                }


            }
            else
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = db.GetList(p => true);
                            break;

                        case "Id":
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.EntradaId == id);
                            break;

                        case "UsuarioId":
                            int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == UsuarioId);
                            break;

                        case "PacienteId":
                            int ProductoId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.PacienteId == ProductoId);
                            break;

                        case "OrdenId":
                            int Entrada = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.OrdenId == Entrada);
                            break;


                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaEntradaResultados = listado;
                ConsultadataGridView.DataSource = ListaEntradaResultados;
            }
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("No hay Datos Para Imprimir");
                return;
            }
            else
            {
               EntradaResultadoReporte reporte = new EntradaResultadoReporte(ListaEntradaResultados);
                reporte.ShowDialog();
            }
        }

        private void cEntradaResultados_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }
    }
}
