using Bayolu.Domain;
using Bayolu.SharedKernel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Bayolu.Api.Controllers
{
    [Route(VERSION + "/master")]
    public class MasterApiController : BaseApiController
    {
        [HttpGet("teams")]
        public IActionResult GetTeams()
        {
            var teams = new List<KeyValuePair<int, string>>();
            foreach (Enums.Team val in Enums.Team.GetValues(typeof(Enums.Team)))
            {
                teams.Add(new KeyValuePair<int, string>((int)val, val.GetDescription()));
            }
            return Ok(teams);
        }
        [HttpGet("roles")]
        public IActionResult GetRoles()
        {

            var teams = new List<KeyValuePair<int, string>>();
            foreach (Enums.Role val in Enums.Role.GetValues(typeof(Enums.Team)))
            {
                teams.Add(new KeyValuePair<int, string>((int)val, val.GetDescription()));
            }
            return Ok(teams);
        }
    }
}
