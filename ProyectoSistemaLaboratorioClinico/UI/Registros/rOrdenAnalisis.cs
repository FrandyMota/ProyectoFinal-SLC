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
    public partial class rOrdenAnalisis : Form
    {
        public List<OrdenAnalisisDetalles> Orden;
        public rOrdenAnalisis(int id)
        {
            this.IdAnalisis = id;
            Orden = new List<OrdenAnalisisDetalles>();
            InitializeComponent();
            LlenarComboBox();
            LlenarComboBox2();
        }
        public int IdAnalisis { get; set; }

        private void Limpiar()
        {
            AnalisisDetallenumericUpDown.Value = 0;
            PacienteComboBox.Text = string.Empty;
            AnalisisIdcomboBox.Text = null;
            PreciotextBox.Text = "0";
            BalancetextBox.Text = string.Empty;
            TotaltextBox.Text = string.Empty;
            this.Orden = new List<OrdenAnalisisDetalles>();
            CargarGrid();
        }

        private OrdenAnalisis LlenaClase()
        {
            OrdenAnalisis ordenAnalisis = new OrdenAnalisis();
            ordenAnalisis.OrdenId = Convert.ToInt32(AnalisisDetallenumericUpDown.Value);
            ordenAnalisis.PacienteId = Convert.ToInt32(PacienteComboBox.SelectedValue);
            ordenAnalisis.Precio = Convert.ToDecimal(PreciotextBox.Text);
            ordenAnalisis.Fecha = FechadateTimePicker.Value;
            ordenAnalisis.Balance = Convert.ToDecimal(BalancetextBox.Text);
            ordenAnalisis.Total = Convert.ToDecimal(TotaltextBox.Text);
            ordenAnalisis.detalles = this.Orden;

            return ordenAnalisis;
        }

        private void LlenaCampo(OrdenAnalisis ordenAnalisis)
        {
            AnalisisDetallenumericUpDown.Value = ordenAnalisis.OrdenId;
            PacienteComboBox.SelectedValue = ordenAnalisis.PacienteId;
            FechadateTimePicker.Value = ordenAnalisis.Fecha;
            BalancetextBox.Text = ordenAnalisis.Balance.ToString();
            TotaltextBox.Text = ordenAnalisis.Total.ToString();
           this.Orden = ordenAnalisis.detalles;
            CargarGrid();

        }
        private void LlenarComboBox()
        {

            RepositorioBase<Pacientes> PRepositorio = new RepositorioBase<Pacientes>();

            PacienteComboBox.DataSource = PRepositorio.GetList(c => true);

            PacienteComboBox.ValueMember = "PacienteId";

            PacienteComboBox.DisplayMember = "Nombres";

        }

        private void LlenarComboBox2()
        {

            RepositorioBase<TipoAnalisis> PRepositorio = new RepositorioBase<TipoAnalisis>();

            AnalisisIdcomboBox.DataSource = PRepositorio.GetList(c => true);

            AnalisisIdcomboBox.ValueMember = "TipoAnalisisId";

            AnalisisIdcomboBox.DisplayMember = "Descripcion";

        }

        private bool ExisteEnLaBaseDeDatos()
        {

            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();

            OrdenAnalisis ordenAnalisis = db.Buscar((int)AnalisisDetallenumericUpDown.Value);

            return (ordenAnalisis != null);

        }

        private bool Validar()
        {
            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();

            bool paso = true;

            errorProvider.Clear();


            if (string.IsNullOrWhiteSpace(PacienteComboBox.Text))
            {
                errorProvider.SetError(PacienteComboBox, "La orden no puede estar vacia");

                PacienteComboBox.Focus();

                paso = false;
            }


            return paso;
        }

        public void CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Orden)
            {
                total += (item.Precio) ;
            }
            BalancetextBox.Text = total.ToString();
            TotaltextBox.Text = total.ToString();
        }

        private void CargarGrid()
        {
            AnalisisdetalledataGridView.DataSource = null;
            AnalisisdetalledataGridView.DataSource = Orden;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();
            OrdenAnalisis ordenAnalisis;
            bool paso = false;

            if (!Validar())

                return;

            ordenAnalisis = LlenaClase();


            if (AnalisisDetallenumericUpDown.Value == 0)
            {
                paso = AnalisisBLL.Guardar(ordenAnalisis);
            }

            else
            {

                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Resultado que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                paso = AnalisisBLL.Modificar(ordenAnalisis);
            }

            if (paso)

                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();

            try
            {

                if (AnalisisDetallenumericUpDown.Value > 0)
                {

                    if (AnalisisBLL.Eliminar((int)AnalisisDetallenumericUpDown.Value))
                    {
                        MessageBox.Show("Eliminado", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Limpiar();
                    }

                    else
                    {
                        MessageBox.Show("No se puede eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }

            }

            catch (Exception)
            {
                MessageBox.Show("NO se pudo eliminar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();
            OrdenAnalisis ordenAnalisis = new OrdenAnalisis();

            int.TryParse(AnalisisDetallenumericUpDown.Text, out id);

            Limpiar();

            ordenAnalisis = db.Buscar(id);

            if (ordenAnalisis != null)
            {
                LlenaCampo(ordenAnalisis);
            }

            else
            {
                MessageBox.Show("El Analisis no existe");
            }
        }

        private void AnalisisIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void AnalisisIdcomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            TipoAnalisis A = AnalisisIdcomboBox.SelectedItem as TipoAnalisis;
            if(A != null)
            {
                PreciotextBox.Text = Convert.ToString(A.Precio);
            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();
            TipoAnalisis tipoAnalisis;
            tipoAnalisis = db.Buscar((int)AnalisisIdcomboBox.SelectedValue);

            if (AnalisisdetalledataGridView.DataSource != null)
                this.Orden = (List<OrdenAnalisisDetalles>)AnalisisdetalledataGridView.DataSource;

            this.Orden.Add(new OrdenAnalisisDetalles()
            {

                OrdenId = Convert.ToInt32(AnalisisDetallenumericUpDown.Value),
                TipoAnalisisId = Convert.ToInt32(AnalisisIdcomboBox.SelectedValue),
                Precio = Convert.ToDecimal(PreciotextBox.Text),
                Descripcion= tipoAnalisis.Descripcion



            }) ;

            CargarGrid();
            CalcularTotal();
            AnalisisIdcomboBox.Text = null;
            PreciotextBox.Text = "0";
        }


    }
}
