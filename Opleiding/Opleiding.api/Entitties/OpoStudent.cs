using Opleiding.api.Entitties;

namespace opleiding.api.Entitties
{

    public class OpoStudent
    {
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; }
        public Guid OpoId { get; set; }
        public virtual Opo Opo { get; set; }
    }
}
