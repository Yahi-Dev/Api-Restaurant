using Restaurant.Core.Domain.Common;

namespace Restaurant.Core.Domain.Entities
{
    public class Orden : AuditableBaseEntity
    {
        public virtual ICollection<Plato> PlatosSeleccionados { get; set; }
        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }
        public decimal Subtotal { get; set; }
        public string Estado { get; set; }
    }
}
