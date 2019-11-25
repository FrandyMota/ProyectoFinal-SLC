using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntradaDetalles
    {
        [Key]
        public int EntradaDetallesId { get; set; }
        public int EntradaId { get; set; }
        public int OrdenId { get; set; }
        public int TipoAnalisisId { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public string Resultado { get; set; }

        public EntradaDetalles()
        {
            EntradaDetallesId = 0;
            EntradaId = 0;
            OrdenId = 0;
            TipoAnalisisId = 0;
            Precio = 0;
            Descripcion = "";
            Resultado = "";
        }

        public EntradaDetalles(int entradaDetallesId, int entradaId, int ordenId, int tipoAnalisisId, decimal precio, string descripcion, string resultado)
        {
            EntradaDetallesId = entradaDetallesId;
            EntradaId = entradaId;
            OrdenId = ordenId;
            TipoAnalisisId = tipoAnalisisId;
            Precio = precio;
            Descripcion = descripcion;
            Resultado = resultado;
        }
    }
}
