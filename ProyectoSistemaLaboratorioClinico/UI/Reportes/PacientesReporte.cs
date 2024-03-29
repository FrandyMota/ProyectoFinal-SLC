﻿using Entidades;
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
    public partial class PacientesReporte : Form
    {
        private List<Pacientes> ListaPacientes;
        public PacientesReporte(List<Pacientes> pacientes)
        {
            this.ListaPacientes = pacientes;
            InitializeComponent();
        }

        private void PacientesReporte_Load(object sender, EventArgs e)
        {
            ListadoPacientes listadoPacientes1 = new ListadoPacientes();
            listadoPacientes1.SetDataSource(ListaPacientes);

            PacientesReportViewer.ReportSource = listadoPacientes1;
            PacientesReportViewer.Refresh();
        }
    }
}
