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
    public class SurveyController : ControllerBase
    {
        private readonly IScoreService _scoreService;
        private readonly IUserService _userService;

        public SurveyController(IScoreService scoreService, IUserService userService) => (_userService, _scoreService) = (userService, scoreService);

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] int valueSelected)
        {
            var score = new Score();

            score.SelectedScore = valueSelected;
            var userOnline = HttpContext.Session.GetObject<User>(DatosSesion.SesionUsuario);
            userOnline.SurveyCarriedOut = true;

            switch (valueSelected)
            {
                case int value when (value <= 6 && value >= 0):
                    userOnline.UserTypeId = (int)UserTypes.Detractor;
                    break;
                case int value when (value > 6 && value < 9):
                    userOnline.UserTypeId = (int)UserTypes.Neutro;
                    break;
                case int value when (value > 8 && value <= 10):
                    userOnline.UserTypeId = (int)UserTypes.Promotor;
                    break;
            }

            score.UserId = userOnline.UserId;
            score.CompanyId = HttpContext.Session.GetObject<Company>(DatosSesion.SesionCompany).CompanyId;

            await _scoreService.AddAsync(score);
            await _userService.UpdateAsync(userOnline);

            return Ok(score);
        }
    }
}