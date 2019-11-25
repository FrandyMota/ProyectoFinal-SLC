using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoAnalisis
    {
        [Key]
        public int TipoAnalisisId { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioId { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadVeses { get; set; }

        public TipoAnalisis()
        {
            TipoAnalisisId = 0;
            Descripcion = "";
            UsuarioId = 0;
            Precio = 0;
            Fecha = DateTime.Now;
            CantidadVeses = 0;
        }
    }
}
