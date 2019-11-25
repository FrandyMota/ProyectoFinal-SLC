using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntradaResultados
    {
        [Key]
        public int EntradaId { get; set; }
        public int OrdenId { get; set; }
        public int PacienteId { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public virtual List<EntradaDetalles> detalles { get; set; }

     
        public EntradaResultados()
        {
            EntradaId = 0;
            OrdenId = 0;
            PacienteId = 0;
            Fecha = DateTime.Now;
            detalles = new List<EntradaDetalles>();
        }
    }
}
