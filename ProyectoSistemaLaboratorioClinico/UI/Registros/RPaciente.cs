using BLL;
using Entidades;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoSistemaLaboratorioClinico.UI.Registros
{
    public partial class RPaciente : Form
    {
        public RPaciente(int id)
        {
            this.IdUsario = id;
            InitializeComponent();
        }
        public int IdUsario { get; set; }

        private void Limpiar()
        {
            PacienteIdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            SeguroVidatextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            BalancetextBox.Text = 0.ToString();
            CelularmaskedTextBox.Text = string.Empty;
            TelefonomaskedTextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
        }

        private Pacientes LlenaClase()
        {
            Pacientes paciente = new Pacientes();
            paciente.PacienteId = Convert.ToInt32(PacienteIdnumericUpDown.Value);
            paciente.Nombres = NombretextBox.Text.Trim();
            paciente.Email = EmailtextBox.Text;
            paciente.Direccion = DirecciontextBox.Text.Trim();
            paciente.Cedula = CedulamaskedTextBox.Text;
            paciente.Telefono = TelefonomaskedTextBox.Text;
            paciente.Celular = CelularmaskedTextBox.Text;            
            paciente.SeguroDeVida = SeguroVidatextBox.Text;
            paciente.Balance = Convert.ToDecimal(BalancetextBox.Text);
            paciente.Fecha = FechadateTimePicker.Value;
            
            return paciente;
        }

        private void LlenaCampo(Pacientes paciente)
        {
            PacienteIdnumericUpDown.Value = paciente.PacienteId;
            NombretextBox.Text = paciente.Nombres;
            EmailtextBox.Text = paciente.Email;
            DirecciontextBox.Text = paciente.Direccion;
            CedulamaskedTextBox.Text = paciente.Cedula;
            TelefonomaskedTextBox.Text = paciente.Telefono;
            CelularmaskedTextBox.Text = paciente.Celular;
            SeguroVidatextBox.Text = paciente.SeguroDeVida;
            BalancetextBox.Text = paciente.Balance.ToString();
            FechadateTimePicker.Value = paciente.Fecha;

        }

        private bool ExisteEnLaBaseDeDatos()
        {

            RepositorioBase<Pacientes> db = new RepositorioBase<Pacientes>();

            Pacientes paciente = db.Buscar((int)PacienteIdnumericUpDown.Value);

            return (paciente != null);

        }

        private bool Validar()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();

            bool paso = true;

            errorProvider.Clear();


            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "La direccion no puede esta vacia");

                NombretextBox.Focus();

                paso = false;
            }

            if (FechadateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "La fecha Debe ser igual a hoy");

                EmailtextBox.Focus();

                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox, "La direccion no puede estar vacia");
                DirecciontextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
            {
                errorProvider.SetError(CedulamaskedTextBox, "La Cedula no puede estar Vacia");
                CedulamaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonomaskedTextBox.Text))
            {
                errorProvider.SetError(TelefonomaskedTextBox, "El telefono no puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularmaskedTextBox.Text))
            {
                errorProvider.SetError(CelularmaskedTextBox, "El Celular no puede estar vacio");
                CelularmaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(SeguroVidatextBox.Text))
            {
                errorProvider.SetError(SeguroVidatextBox, "El Seguro de vida no puede estar vacio");
                SeguroVidatextBox.Focus();
                paso = false;
            }

            if (ValidarEmail(EmailtextBox.Text) == false)
            {

                errorProvider.SetError(EmailtextBox, "Correo invalido");

                EmailtextBox.Focus();

                paso = false;

            }

            return paso;
        }

        private Boolean ValidarEmail(String email)
        {
            String expresion;

            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }

            else
            {
                return false;

            }

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Pacientes> db = new RepositorioBase<Pacientes>();
            Pacientes paciente;
            bool paso = false;

            if (!Validar())

                return;

            paciente = LlenaClase();


            if (PacienteIdnumericUpDown.Value == 0)
            {
                paso = db.Guardar(paciente);
            }

            else
            {

                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                paso = db.Modificar(paciente);
            }

            if (paso)

                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Pacientes> db = new RepositorioBase<Pacientes>();

            try
            {

                if (PacienteIdnumericUpDown.Value > 0)
                {

                    if (db.Eliminar((int)PacienteIdnumericUpDown.Value))
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
            RepositorioBase<Pacientes> db = new RepositorioBase<Pacientes>();
            Pacientes paciente = new Pacientes();

            int.TryParse(PacienteIdnumericUpDown.Text, out id);

            Limpiar();

                paciente = db.Buscar(id);

                if (paciente != null)
                {
                    LlenaCampo(paciente);
                }

                else
                {
                    MessageBox.Show("El Usuario no existe");
                }

            
        }

    
    }
}
