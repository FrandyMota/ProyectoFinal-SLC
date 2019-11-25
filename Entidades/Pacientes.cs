using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pacientes
    {
        [Key]
        public int PacienteId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string SeguroDeVida { get; set; }
        public String Cedula { get; set; }
        public decimal Balance { get; set; }
        public int Usuarioid { get; set; }
        public string Telefono { get; set; }
        public String Celular { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }

        public Pacientes()
        {
            PacienteId = 0;
            Nombres = "";
            Direccion = "";
            SeguroDeVida = "";
            Cedula = "";
            Balance = 0;
            Usuarioid = 0;
            Telefono = "";
            Celular = "";
            Email = "";
            Fecha = DateTime.Now;
        }
    }
}
