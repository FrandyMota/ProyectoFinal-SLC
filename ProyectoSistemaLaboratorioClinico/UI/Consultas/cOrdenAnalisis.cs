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
    public partial class cOrdenAnalisis : Form
    {
        public List<OrdenAnalisis> ListaOrdenAnalisis;
        public cOrdenAnalisis(int valor)
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
            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();
            var listado = new List<OrdenAnalisis>();
            if (FiltroFecha.Checked == true)
            {
                try
                {
                    int Criterio = 0;
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.Text)
                        {
                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "Id":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.OrdenId == Criterio);
                                break;
                            case "UsuarioId":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == Criterio);
                                break;
                            case "Paciente":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.PacienteId == Criterio);
                                break;

                            case "Balance":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Balance == Criterio);
                                break;
                            case "Total":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Total == Criterio);
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

                    ListaOrdenAnalisis = listado;
                    ConsultadataGridView.DataSource = ListaOrdenAnalisis;

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
                    int Criterio = 0;
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = db.GetList(p => true);
                            break;

                        case "Id":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.OrdenId == Criterio);
                            break;
                        case "UsuarioId":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == Criterio);
                            break;
                        case "Paciente":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.PacienteId == Criterio);
                            break;

                        case "Balance":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Balance == Criterio);
                            break;
                        case "Total":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Total == Criterio);
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaOrdenAnalisis = listado;
                ConsultadataGridView.DataSource = ListaOrdenAnalisis;
            }
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }

        private void cOrdenAnalisis_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
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
                OrdenAnalisisReporte reporte = new OrdenAnalisisReporte(ListaOrdenAnalisis);
                reporte.ShowDialog();
            }
        }
    }
}
