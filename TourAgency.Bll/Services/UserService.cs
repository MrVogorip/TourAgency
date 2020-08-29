using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;
using TourAgency.Bll.Services.Interfaces;
using TourAgency.Dal.Entities;
using TourAgency.Dal.UnitOfWork.Interfaces;

namespace TourAgency.Bll.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork Database { get; set; }
        public UserService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public async Task<ClaimsIdentity> Authenticate(string email, string password)
        {
            ClaimsIdentity claim = null;
            ApplicationUser user = Database.UserManager.FindByEmail(email);
            var verificationResult = new PasswordHasher().VerifyHashedPassword(user.PasswordHash, password);
            if (verificationResult == PasswordVerificationResult.Success)
                if (user != null)
                    claim = await Database.UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
            return claim;
        }
        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
