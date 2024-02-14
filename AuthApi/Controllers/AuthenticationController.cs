using AuthApi.Models;
using AuthApi.Models.Authentication.Signup;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }


        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegisterUser registerUser, string role)
        {
            var UserExist= await _userManager.FindByEmailAsync(registerUser.Email);
            if (UserExist!=null)
            {
                return StatusCode(StatusCodes.Status403Forbidden, new Response { Status="Error", Message="User already exist!"});
            }

            IdentityUser user = new()
            {
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerUser.UserName,
            };
            var result= await _userManager.CreateAsync(user, registerUser.Password);
            return result.Succeeded
                ? StatusCode(StatusCodes.Status201Created, new Response { Status = "Success", Message = "User created sucessfully!" })
                : (IActionResult)StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Failed to create the user" });
        }
    }
}
