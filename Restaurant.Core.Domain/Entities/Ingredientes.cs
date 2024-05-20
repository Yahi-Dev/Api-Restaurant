using Restaurant.Core.Domain.Common;

namespace Restaurant.Core.Domain.Entities
{
    public class Ingredientes : AuditableBaseEntity
    {
        public string Nombre { get; set; }
        public virtual ICollection<Plato> Platos { get; set; }
    }
}
