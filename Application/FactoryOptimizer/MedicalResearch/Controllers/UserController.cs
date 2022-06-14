using MedicalResearch.Application.Services.Regions;
using MedicalResearch.Application.Services.UserService;
using MedicalResearch.Models.Regions;
using MedicalResearch.Models.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MedicalResearch.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var itemsDto = await _userService.GetList();
            var itemsVM = itemsDto.Select(i => i.AsViewModel());
            return Ok(itemsVM);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            var id = await _userService.Create(model.AsDto());
            return Ok(id);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LogIn(LogInRequestModel model)
        {
            var email = await _userService.LogIn(model.AsDto());
            if (email != "" && email != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, email)
                };
                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
                return Redirect("/department");
            }
            return NotFound();
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/users/login");
        }
    }
}
