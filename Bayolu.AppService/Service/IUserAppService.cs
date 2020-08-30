using Bayolu.AppService.Dto;
using Bayolu.SharedKernel;
using System.Threading.Tasks;

namespace Bayolu.AppService.Service
{
    public interface IUserAppService
    {
        Task<UserDto> CreateUser(Request<UserDto> request);
    }
}
