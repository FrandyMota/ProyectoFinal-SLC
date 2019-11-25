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
    public partial class RTipoAnalisis : Form
    {
        public RTipoAnalisis()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            TipoAnalisisnumericUpDown.Text = string.Empty;
            DescripcionAnalisistextBox.Text = string.Empty;
            PrecioAnalisistextBox.Text = string.Empty;
        }

        private TipoAnalisis LlenaClase()
        {
            TipoAnalisis tipoAnalisi = new TipoAnalisis();
            tipoAnalisi.TipoAnalisisId = Convert.ToInt32(TipoAnalisisnumericUpDown.Text);
            tipoAnalisi.Descripcion = DescripcionAnalisistextBox.Text;
            tipoAnalisi.Precio = Convert.ToDecimal(PrecioAnalisistextBox.Text);


            return tipoAnalisi;
        }
        
        private void LlenaCampo(TipoAnalisis tipoAnalisi)
        {

            TipoAnalisisnumericUpDown.Text = tipoAnalisi.TipoAnalisisId.ToString();
            DescripcionAnalisistextBox.Text = tipoAnalisi.Descripcion;
            PrecioAnalisistextBox.Text = tipoAnalisi.Precio.ToString();
            FechadateTimePicker.Value = tipoAnalisi.Fecha;
            VecestextBox.Text = tipoAnalisi.CantidadVeses.ToString();
        }

        private bool ExisteEnLaBaseDeDatos()
        {

            RepositorioBase<TipoAnalisis> db = new RepositorioBase<TipoAnalisis>();

            TipoAnalisis tipoAnalisis = db.Buscar((int)TipoAnalisisnumericUpDown.Value);

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

            if (string.IsNullOrWhiteSpace(PrecioAnalisistextBox.Text))
            {
                errorProvider.SetError(PrecioAnalisistextBox, "El precio no puede estar vacio");
                PrecioAnalisistextBox.Focus();

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
            TipoAnalisis tipoAnalisi;
            bool paso = false;

            if (!Validar())
                return;

            tipoAnalisi = LlenaClase();


            if (TipoAnalisisnumericUpDown.Value == 0)
            {
                paso = db.Guardar(tipoAnalisi);
            }

            else
            {

                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Analisis que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                paso = db.Modificar(tipoAnalisi);
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

                if (TipoAnalisisnumericUpDown.Value > 0)
                {

                    if (db.Eliminar((int)TipoAnalisisnumericUpDown.Value))
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

            int.TryParse(TipoAnalisisnumericUpDown.Text, out id);

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
