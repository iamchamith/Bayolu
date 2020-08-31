using AutoMapper;
using Bayolu.Api.Utility;
using Bayolu.AppService.Dto;
using Bayolu.AppService.Service;
using Bayolu.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bayolu.Api.Controllers
{
    [Route(VERSION + "/users")]
    public class UserApiController : BaseApiController
    {
        private readonly IUserAppService _userAppService;
        private readonly IMapper _mapper;
        public UserApiController(IUserAppService userAppService, IMapper mapper)
        {
            _userAppService = userAppService;
            _mapper = mapper;
        }
        [HttpPost, ModelValidation]
        public async Task<IActionResult> Createuser([FromBody] UserViewModel model)
        {
            try
            {
                var vm = _mapper.Map<UserDto>(model);
                var result = await _userAppService.CreateUser(Request(vm));
                return Ok(result);
            }
            catch (System.Exception e)
            {
                return HandleException(e);
            }
        }

        [HttpGet, Route("keyvalues")]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var result = await (_userAppService.GetUserQueryAsNoTracking()
                    .Select(p => new KeyValuePair<Guid, string>(p.Id, p.FullName)))
                    .ToListAsync();
                return Ok(result);
            }
            catch (System.Exception e)
            {
                return HandleException(e);
            }
        }
    }
}
