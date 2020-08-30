using Bayolu.SharedKernel;
using Microsoft.AspNetCore.Mvc;

namespace Bayolu.Api.Controllers
{
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        protected const string VERSION = "v1";
        [ApiExplorerSettings(IgnoreApi = true)]
        protected Request<T> Request<T>(T item)
        {
            //1 is the user id who login to the system.
            // i just hardcode it. else we need to take from claims
            //example HttpContext.User.Claims[userid]
            return new Request<T>(item, 1);
        }
    }
}
