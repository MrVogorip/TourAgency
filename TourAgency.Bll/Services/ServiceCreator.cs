using TourAgency.Bll.Services.Interfaces;
using TourAgency.Dal.UnitOfWork;

namespace TourAgency.Bll.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new EFUnitOfWork(connection));
        }
    }
}
