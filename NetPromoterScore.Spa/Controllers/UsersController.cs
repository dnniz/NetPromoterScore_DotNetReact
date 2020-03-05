using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetPromoterScore.Entity;
using NetPromoterScore.Service;
using NetPromoterScore.Util;

namespace NetPromoterScore.Spa.Controllers
{
    [Produces("application/json")]
    [EnableCors("CORSReactPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ICompanyService _companyService;

        public UsersController(IUserService userService, ICompanyService companyService) => (_userService , _companyService) = (userService, companyService);

        [HttpGet]
        [Route("profiles")]
        public async Task<IActionResult> Get()
        {
            var result = await _userService.GetAllProfilesAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            var result = await _userService.AddAsync(user);
            return Ok(result);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> PostLogin([FromBody] User user)
        {
            var userOnline = await _userService.LoginAsync(user);
            var company = await _companyService.GetPrincipalCompany();

            HttpContext.Session.SetObject(DatosSesion.SesionUsuario, userOnline);
            HttpContext.Session.SetObject(DatosSesion.SesionCompany, company);

            return Ok(userOnline);
        }

    }
}