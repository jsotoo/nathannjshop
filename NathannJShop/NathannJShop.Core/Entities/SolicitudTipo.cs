using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NathannJShop.Core.Entities
{
    public class SolicitudTipo
    {
        public int SolicitudTipoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public IEnumerable<Solicitud> Solicitudes { get; set; }
    }
}
