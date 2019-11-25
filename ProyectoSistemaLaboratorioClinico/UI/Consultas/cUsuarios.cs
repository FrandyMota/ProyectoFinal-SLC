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
        
    public partial class cUsuarios : Form
    {
        public List<Usuarios> ListaUsuarios;
        public cUsuarios(int valor)
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
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            var listado = new List<Usuarios>();
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

                            case "Id":
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == id);
                                break;

                            case "Nombre":
                                listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                                break;

                            case "Usuario":
                                listado = db.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                                break;
                            case "NivelUsuario":
                                listado = db.GetList(p => p.NivelUsuario.Contains(CriteriotextBox.Text));
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

                    ListaUsuarios = listado;
                    ConsultadataGridView.DataSource = ListaUsuarios;

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
                            listado = db.GetList(p => p.UsuarioId == id);
                            break;

                        case "Nombre":
                            listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                            break;

                        case "Usuario":
                            listado = db.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                            break;
                        case "NivelUsuario":
                            listado = db.GetList(p => p.NivelUsuario.Contains(CriteriotextBox.Text));
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaUsuarios = listado;
                ConsultadataGridView.DataSource = ListaUsuarios;
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
                UsuarioReporte reporte = new UsuarioReporte(ListaUsuarios);
                reporte.ShowDialog();
            }
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            Consultarbutton.PerformClick();
        }


    }
    
}
