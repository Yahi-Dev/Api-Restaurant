using Restaurant.Core.Domain.Common;

namespace Restaurant.Core.Domain.Entities
{
    public class Mesa : AuditableBaseEntity
    {
        public int Capacidad { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Orden> Ordenes { get; set; }

        public virtual ICollection<Plato> Platos { get; set; }
    }
}
