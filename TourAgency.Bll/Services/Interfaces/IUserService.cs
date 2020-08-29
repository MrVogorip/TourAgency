using System;
using System.Security.Claims;
using System.Threading.Tasks;
using TourAgency.Bll.DTO;
using TourAgency.Bll.Infrastructure;

namespace TourAgency.Bll.Services.Interfaces
{
    public interface IUserService : IDisposable
    {
        Task<ClaimsIdentity> Authenticate(string email, string password);
    }
}
