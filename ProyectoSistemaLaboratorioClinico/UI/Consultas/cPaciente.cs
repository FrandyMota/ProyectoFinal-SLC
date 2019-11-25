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
    public partial class cPaciente : Form
    {
        public List<Pacientes> ListaPacientes;
        public cPaciente(int valor)
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
            RepositorioBase<Pacientes> db = new RepositorioBase<Pacientes>();
            var listado = new List<Pacientes>();
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
                                listado = db.GetList(p => p.PacienteId == id);
                                break;

                            case "UsuarioId":
                                int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Usuarioid == UsuarioId);
                                break;

                            case "Nombre":
                                listado = db.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                                break;
                            case "Direccion":
                                listado = db.GetList(p => p.Direccion.Contains(CriteriotextBox.Text));
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

                    ListaPacientes = listado;
                    ConsultadataGridView.DataSource = ListaPacientes;

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
                            listado = db.GetList(p => p.PacienteId == id);
                            break;

                        case "UsuarioId":
                            int UsuarioId = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(p => p.Usuarioid == UsuarioId);
                            break;

                        case "Nombre":
                            listado = db.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                            break;
                        case "Direccion":
                            listado = db.GetList(p => p.Direccion.Contains(CriteriotextBox.Text));
                            break;

                        default:
                            break;
                    }

                }
                else
                {
                    listado = db.GetList(p => true);
                }

                ListaPacientes = listado;
                ConsultadataGridView.DataSource = ListaPacientes;
            }
        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {
            Consultarbutton_Click(sender, e);
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
               PacientesReporte reporte = new PacientesReporte(ListaPacientes);
                reporte.ShowDialog();
            }
        }
    }
    
}
