using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sakura.Data;
using Sakura.Model;
using Sakura.Model.Auth;

namespace Sakura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        private readonly SignInManager<NiUser> _signInManager;
        private readonly UserManager<NiUser> _userManager;
        private readonly ApplicationDbContext _applicationDbContext;

        public AuthController(SignInManager<NiUser> signInManager,
            UserManager<NiUser> userManager,
            ApplicationDbContext applicationDbContext)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _applicationDbContext = applicationDbContext;
        }
        
        [HttpPost]
        [Route("PasswordLogin")]
        public async Task<IActionResult> PasswordLogin(string usernameOrEmail, string password)
        {
            var user = await _applicationDbContext.Users.SingleOrDefaultAsync(t =>
                t.Email == usernameOrEmail || t.UserName == usernameOrEmail);
            var result = await _signInManager.PasswordSignInAsync(user, password, true, false);
            if (result.Succeeded)
            {
                return Json(new NiProtocol(NiErrCode.Success, "Sign in successfully."));
            }
            else
            {
                return Json(new NiProtocol(NiErrCode.Unauthorized, "Wrong username or password."));
            }
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(string username, string email, string password)
        {
            var result = await _userManager.CreateAsync(new NiUser()
            {
                UserName = username,
                Email = email
            },password);
            if (result.Succeeded)
            {
                return Json(new NiProtocol(NiErrCode.Success, "User created successfully."));
            }
            else
            {
                return Json(new NiProtocol(NiErrCode.Unauthorized, "Created failed." + result.Errors));
            }
        }
    }
}