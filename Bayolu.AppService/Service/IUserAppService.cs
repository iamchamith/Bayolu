using Bayolu.AppService.Dto;
using Bayolu.Domain;
using Bayolu.SharedKernel;
using System.Linq;
using System.Threading.Tasks;

namespace Bayolu.AppService.Service
{
    public interface IUserAppService
    {
        Task<UserDto> CreateUser(Request<UserDto> request);
        IQueryable<User> GetUserQueryAsNoTracking();
    }
}
