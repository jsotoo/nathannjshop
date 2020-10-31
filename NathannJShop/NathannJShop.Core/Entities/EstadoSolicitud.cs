namespace NathannJShop.Core.Entities
{
    public class EstadoSolicitud
    {
        public int EstadoSolicitudId { get; set; }
        public Solicitud Solicitud { get; set; }
        public int SolicitudId { get; set; }
        public string NombreEstado { get; set; }
    }
}
