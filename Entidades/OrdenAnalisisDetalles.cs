using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrdenAnalisisDetalles
    {
        [Key]
        public int OrdenAnalisisdetalle { get; set; }
        [Browsable(false)]
        public int OrdenId { get; set; }
        public int TipoAnalisisId { get; set; }
        public string Descripcion { get; set; }
        public string Resultado { get; set; }
        public decimal Precio { get; set; }
        public OrdenAnalisisDetalles()
        {
            OrdenAnalisisdetalle = 0;
            OrdenId = 0;
            TipoAnalisisId = 0;
            Precio = 0;
            Descripcion = "";
            Resultado = "";
        }

        public OrdenAnalisisDetalles(int ordenAnalisisdetalle, int ordenId, int tipoAnalisisId, decimal precio, string descripcion, string resultado)
        {
            OrdenAnalisisdetalle = ordenAnalisisdetalle;
            OrdenId = ordenId;
            TipoAnalisisId = tipoAnalisisId;
            Precio = precio;
            Descripcion = descripcion;
            Resultado = resultado;
        }
    }
}
