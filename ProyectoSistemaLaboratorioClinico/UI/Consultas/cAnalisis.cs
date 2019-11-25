using BLL;
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

namespace ProyectoSistemaLaboratorioClinico.UI.Consultas
{
    public partial class cAnalisis : Form
    {
        public List<TipoAnalisis> ListaAnalisis;
        public cAnalisis(int valor)
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
                        int Criterio = 0;
                        switch (FiltrocomboBox.Text)
                        {

                            case "Todo":
                                listado = db.GetList(p => true);
                                break;

                            case "TipoAnalisisId":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.TipoAnalisisId == Criterio);
                                break;

                            case "UsuarioId":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == Criterio);
                                break;

                            case "Descripcion":
                                listado = db.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                                break;


                            case "Precio":
                                Criterio = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Precio == Criterio);
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

                    ListaAnalisis = listado;
                    ConsultadataGridView.DataSource = ListaAnalisis;

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

                        case "TipoAnalisisId":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.TipoAnalisisId == Criterio);
                            break;

                        case "UsuarioId":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.UsuarioId == Criterio);
                            break;

                        case "Descripcion":
                            listado = db.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                            break;

                        case "Precio":
                            Criterio = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Precio == Criterio);
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaAnalisis = listado;
                ConsultadataGridView.DataSource = ListaAnalisis;
            }
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }

        private void cAnalisis_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }
        private void Consultarbutton_TextChanged(object sender, EventArgs e)
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
              /*  ProductosReporte reporte = new ProductosReporte(ListaAnalisis);
                reporte.ShowDialog();*/
            }
        }
    }
}
