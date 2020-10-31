using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Core.Entities
{
    public class Solicitud
    {
        public int SolicitudId { get; set; }
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaRespuesta { get; set; }
        public SolicitudTipo SolicitudTipo { get; set; }
        public EstadoSolicitud EstadoSolicitud { get; set; }
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }

    }
}
