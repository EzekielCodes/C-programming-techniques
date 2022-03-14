using Microsoft.AspNetCore.Identity;

namespace Opleiding.api.Entitties
{

    public class PersoonRol : IdentityUserRole<Guid>
    {
        public virtual Rol Rol { get; set; }
        public virtual Persoon Persoon { get; set; }
    }
}
