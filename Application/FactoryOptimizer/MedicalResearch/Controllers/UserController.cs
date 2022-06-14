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
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var itemsDto = await _userService.GetList();
            var itemsVM = itemsDto.Select(i => i.AsViewModel());
            return Ok(itemsVM);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestModel model)
        {
            var id = await _userService.Create(model.AsDto());
            return Ok(id);
        }

        [AllowAnonymous]
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
                return Redirect("/departments");
            }
            return NotFound();
        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/users/login");
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDetails([FromRoute] int id)
        {
            var item = await _userService.Get(id);
            return Ok(item.AsViewModel());
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Activate([FromRoute] int id, [FromBody] bool canChange)
        {
            await _userService.Update(id, canChange);
            return Ok();
        }
    }
}
