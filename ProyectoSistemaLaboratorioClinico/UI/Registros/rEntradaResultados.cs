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

namespace ProyectoSistemaLaboratorioClinico.UI.Registros
{
    public partial class rEntradaResultados : Form
    {
        public List<EntradaDetalles> Entrada;
     
            
        public rEntradaResultados(int id)
        {
            
            
            InitializeComponent();
            LlenarComboBox2();
            Entrada = new List<EntradaDetalles>();
            this.IdAnalisis = id;
        }
        public int IdAnalisis { get; set; }

        private void Limpiar()
        {
            EntradaIdnumericUpDown.Value = 0;
            OrdencomboBox.Text = string.Empty;
            PacientetextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;

        }
        private int nombre = 0; 
        private EntradaResultados LlenaClase()
        {
            EntradaResultados entradaResultados = new EntradaResultados();
            entradaResultados.EntradaId = Convert.ToInt32(EntradaIdnumericUpDown.Value);
            entradaResultados.OrdenId = Convert.ToInt32(OrdencomboBox.Text);
            entradaResultados.PacienteId = Convert.ToInt32(nombre);
            entradaResultados.detalles = this.Entrada;

            return entradaResultados;
        }

        private void LlenaCampo(EntradaResultados entradaResultados)
        {
            OrdenAnalisis ordenAnalisis = new OrdenAnalisis();
            Pacientes pacientes = new Pacientes();
            RepositorioBase<Pacientes> db2 = new RepositorioBase<Pacientes>();
   

            pacientes = db2.Buscar(Convert.ToInt32(entradaResultados.PacienteId));

            PacientetextBox.Text = pacientes.Nombres;
            nombre = ordenAnalisis.PacienteId;
            EntradaIdnumericUpDown.Value = entradaResultados.EntradaId;
            OrdencomboBox.Text = entradaResultados.OrdenId.ToString();
           
            this.Entrada = entradaResultados.detalles;
            CargarGrid();
        }

        private void LlenarComboBox2()
        {

            RepositorioBase<OrdenAnalisis> PRepositorio = new RepositorioBase<OrdenAnalisis>();

            OrdencomboBox.DataSource = PRepositorio.GetList(c => true);

            OrdencomboBox.ValueMember = "OrdenId";

            OrdencomboBox.DisplayMember = "OrdenId";

        }


        private bool ExisteEnLaBaseDeDatos()
        {

            RepositorioBase<EntradaResultados> db = new RepositorioBase<EntradaResultados>();

            EntradaResultados entradaResultados = db.Buscar((int)EntradaIdnumericUpDown.Value);

            return (entradaResultados != null);

        }

        private bool Validar()
        {
            RepositorioBase<EntradaResultados> db = new RepositorioBase<EntradaResultados>();

            bool paso = true;

            errorProvider.Clear();


            if (string.IsNullOrWhiteSpace(OrdencomboBox.Text))
            {
                errorProvider.SetError(OrdencomboBox, "La orden no puede estar vacia");

                OrdencomboBox.Focus();

                paso = false;
            }


            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<EntradaResultados> db = new RepositorioBase<EntradaResultados>();
            EntradaResultados entradaResultados;
            bool paso = false;

            if (!Validar())

                return;

            entradaResultados = LlenaClase();


            if (EntradaIdnumericUpDown.Value == 0)
            {
                paso = db.Guardar(entradaResultados);
            }

            else
            {

                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Resultado que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                paso = db.Modificar(entradaResultados);
            }

            if (paso)

                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<EntradaResultados> db = new RepositorioBase<EntradaResultados>();

            try
            {

                if (EntradaIdnumericUpDown.Value > 0)
                {

                    if (db.Eliminar((int)EntradaIdnumericUpDown.Value))
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
            RepositorioBase<EntradaResultados> db = new RepositorioBase<EntradaResultados>();
            EntradaResultados entradaResultados = new EntradaResultados();

            int.TryParse(EntradaIdnumericUpDown.Text, out id);

            Limpiar();

            entradaResultados = db.Buscar(id);

            if (entradaResultados != null)
            {
                LlenaCampo(entradaResultados);
            }

            else
            {
                MessageBox.Show("El Analisis no existe");
            }
        }

        private void BuscarOrdenbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<OrdenAnalisis> db = new RepositorioBase<OrdenAnalisis>();
            RepositorioBase<Pacientes> db2 = new RepositorioBase<Pacientes>();
            OrdenAnalisis ordenAnalisis = new OrdenAnalisis();
            Pacientes pacientes = new Pacientes();

            ordenAnalisis   = db.Buscar(Convert.ToInt32(OrdencomboBox.Text));

            pacientes = db2.Buscar(Convert.ToInt32(ordenAnalisis.PacienteId));

            PacientetextBox.Text = pacientes.Nombres;
            nombre = ordenAnalisis.PacienteId;

            

            foreach(var item in ordenAnalisis.detalles)
            {
                int EntradaDetallesId = 0;
                int entradaId = 0;
                int OrdenId = item.OrdenId;
                int TipoAnalisisId = item.TipoAnalisisId;
                decimal Precio = item.Precio;
                string Descripcion = item.Descripcion;
                string Resultado =item.Resultado;

                if (EntradadetalledataGridView.DataSource != null)
                    this.Entrada = (List<EntradaDetalles>)EntradadetalledataGridView.DataSource;

                this.Entrada.Add(new EntradaDetalles()
                {

                    EntradaDetallesId = EntradaDetallesId,
                    EntradaId = entradaId,
                    OrdenId = Convert.ToInt32(OrdenId),
                    TipoAnalisisId = Convert.ToInt32(TipoAnalisisId),
                    Precio = Convert.ToDecimal(Precio),
                    Descripcion = Descripcion



                }) ;



            }
            CargarGrid();

         

           


        }

        private void CargarGrid()
        {
            EntradadetalledataGridView.DataSource = null;
            EntradadetalledataGridView.DataSource = Entrada;
        }
    }
}
