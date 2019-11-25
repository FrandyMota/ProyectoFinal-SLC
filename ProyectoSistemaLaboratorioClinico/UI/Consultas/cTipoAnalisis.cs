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
    public partial class cTipoAnalisis : Form
    {
        public List<TipoAnalisis> ListaTipoAnalisis;
        public cTipoAnalisis(int valor)
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
            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();
            var listado = new List<TipoAnalisis>();
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

                            case "TipoAnalisisId":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.TipoAnalisisId == id);
                                break;

                            case "UsuarioId":
                                int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == UsuarioId);
                                break;

                            case "Descripcion":
                                int Descripcion = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Descripcion == "");
                                break;

                            case "Precio":
                                int Precio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Precio == Precio);
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

                    ListaTipoAnalisis = listado;
                    ConsultadataGridView.DataSource = ListaTipoAnalisis;

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

                        case "TipoAnalisisId":
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.TipoAnalisisId == id);
                            break;

                        case "UsuarioId":
                            int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == UsuarioId);
                            break;

                        case "Descripcion":
                            int Descripcion = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Descripcion == "");
                            break;

                        case "Precio":
                            int Precio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Precio == Precio);
                            break;


                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaTipoAnalisis = listado;
                ConsultadataGridView.DataSource = ListaTipoAnalisis;
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
               TipoAnalisisReporte reporte = new TipoAnalisisReporte(ListaTipoAnalisis);
                reporte.ShowDialog();
            }
        }

        private void cTipoAnalisis_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }
    }
}
