using AutoMapper;
using Bayolu.AppService.Dto;
using Bayolu.AppService.Infastructure;
using Bayolu.Domain;
using Bayolu.SharedKernel;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bayolu.AppService.Service
{
    public class UserAppService : IUserAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UserAppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UserDto> CreateUser(Request<UserDto> request)
        {
            try
            {
                var dto = request.Item;
                var @user = new User(dto.Id, dto.FullName, dto.Email, dto.Role, dto.Team, dto.StorageCapacity,
                    dto.OriginalFolder, dto.Comment, dto.UserReviews)
                    .SetPassword(dto.Password);

                _unitOfWork.UserGenaricRepository.Insert(@user);
                await _unitOfWork.SaveAsync();
                return _mapper.Map<UserDto>(user);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public IQueryable<User> GetUserQueryAsNoTracking() {

            return _unitOfWork.UserGenaricRepository.GetAllAsNoTracking();
        }
    }
}
