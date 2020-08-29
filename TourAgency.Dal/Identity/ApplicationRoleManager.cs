using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TourAgency.Dal.Entities;

namespace TourAgency.Dal.Identity
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole>
    {
        public ApplicationRoleManager(RoleStore<ApplicationRole> store)
                    : base(store)
        { }
    }
}
