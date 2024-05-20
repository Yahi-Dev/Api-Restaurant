using Restaurant.Core.Domain.Common;

namespace Restaurant.Core.Domain.Entities
{
    public class Plato : AuditableBaseEntity
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Personas { get; set; }
        public virtual ICollection<Ingredientes> Ingredientes { get; set; }
        public string Categoria { get; set; }
        public int MesaId { get; set; }

        public virtual Mesa Mesa { get; set; }
    }
}
