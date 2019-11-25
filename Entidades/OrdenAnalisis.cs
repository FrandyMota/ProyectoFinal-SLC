using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrdenAnalisis
    {
        [Key]
        public int OrdenId { get; set; }
        public int PacienteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Precio { get; set; }
        public decimal Balance { get; set; }
        public decimal Total { get; set; }
        public int UsuarioId { get; set; }

        public virtual List<OrdenAnalisisDetalles> detalles { get; set; }
        public OrdenAnalisis()
        {
            OrdenId = 0;
            PacienteId = 0;
            Fecha = DateTime.Now;
            Precio = 0;
            Balance = 0;
            Total = 0;
            UsuarioId = 0;
            detalles = new List<OrdenAnalisisDetalles>();        }
    }
}
