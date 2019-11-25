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
    public partial class RAnalisis : Form
    {
        public RAnalisis(int id)
        {
            this.IdAnalisis = id;
            InitializeComponent();
        }

        public int IdAnalisis { get; set; }

        private void Limpiar()
        {
            TipoAnalisisIdnumericUpDown.Value = 0;
            DescripcionAnalisistextBox.Text = string.Empty;
            precioAnalisistextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;

        }

        private void LlenaCampo(TipoAnalisis tipoAnalisis)
        {
            TipoAnalisisIdnumericUpDown.Value = tipoAnalisis.TipoAnalisisId;
            DescripcionAnalisistextBox.Text = tipoAnalisis.Descripcion;
            precioAnalisistextBox.Text = tipoAnalisis.Precio.ToString();

        }

        private TipoAnalisis LlenaClase()
        {
            TipoAnalisis tipoAnalisi = new TipoAnalisis();
            tipoAnalisi.TipoAnalisisId = Convert.ToInt32(TipoAnalisisIdnumericUpDown.Value);
            tipoAnalisi.Descripcion = string.Empty;
            tipoAnalisi.Precio = Convert.ToDecimal(precioAnalisistextBox.Text);

            return tipoAnalisi;
        }

        private bool ExisteEnLaBaseDeDatos()
        {

            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();

            TipoAnalisis tipoAnalisis = db.Buscar((int)TipoAnalisisIdnumericUpDown.Value);

            return (tipoAnalisis != null);

        }

        private bool Validar()
        {
            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();

            bool paso = true;

            errorProvider.Clear();


            if (string.IsNullOrWhiteSpace(DescripcionAnalisistextBox.Text))
            {
                errorProvider.SetError(DescripcionAnalisistextBox, "La descripcion no puede estar vacia");

                DescripcionAnalisistextBox.Focus();

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
            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();
            TipoAnalisis tipoAnalisis;
            bool paso = false;

            if (!Validar())

                return;

            tipoAnalisis = LlenaClase();


            if (TipoAnalisisIdnumericUpDown.Value == 0)
            {
                paso = db.Guardar(tipoAnalisis);
            }

            else
            {

                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                paso = db.Modificar(tipoAnalisis);
            }

            if (paso)

                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();

            try
            {

                if (TipoAnalisisIdnumericUpDown.Value > 0)
                {

                    if (db.Eliminar((int)TipoAnalisisIdnumericUpDown.Value))
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
            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();
            TipoAnalisis tipoAnalisis = new TipoAnalisis();

            int.TryParse(TipoAnalisisIdnumericUpDown.Text, out id);

            Limpiar();

            tipoAnalisis = db.Buscar(id);

            if (tipoAnalisis != null)
            {
                LlenaCampo(tipoAnalisis);
            }

            else
            {
                MessageBox.Show("El Analisis no existe");
            }
        }

    
    }
}
