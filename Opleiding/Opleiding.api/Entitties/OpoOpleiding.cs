using Opleiding.api.Entitties;

namespace opleiding.api.Entitties
{

    public class OpoOpleiding
    {
        public Guid OpleidingId { get; set; }
        public virtual Opleiding.api.Entitties.Opleiding Opleiding { get; set; }
        public Guid OpoId { get; set; }
        public virtual Opo Opo { get; set; }
    }
}
