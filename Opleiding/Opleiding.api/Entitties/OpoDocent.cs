using Opleiding.api.Entitties;

namespace opleiding.api.Entitties
{

    public class OpoDocent
    {
        public Guid DocentId { get; set; }
        public virtual Docent Docent { get; set; }
        public Guid OpoId { get; set; }
        public virtual Opo Opo { get; set; }
    }
}
