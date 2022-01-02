using System.Net;
using System.Threading.Tasks;
using ComplaintManagement.Api.Controllers.Requests;
using ComplaintManagement.Core.Services;
using ComplaintManagement.Core.Services.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ComplaintManagement.Api.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserAsync([FromBody] CreateUserHttpRequest request)
        {
            if (!request.IsValid())
            {
                return StatusCode((int)HttpStatusCode.BadRequest);
            }

            var createUserRequest = new CreateUserRequest(request.Username);
            var userId = await _userService.CreateUserAsync(createUserRequest);

            return StatusCode((int)HttpStatusCode.Created, userId);
        }
    }
}