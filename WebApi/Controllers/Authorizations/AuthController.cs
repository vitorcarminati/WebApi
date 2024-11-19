using Microsoft.AspNetCore.Mvc;
using WebApi.Application.Services;

namespace WebApi.Controllers.Authorizations
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "admin" && password == "123456")
            {
                var token = TokenService.GenerateToken(new Domain.Model.EmployeeAggregate.Employee());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
