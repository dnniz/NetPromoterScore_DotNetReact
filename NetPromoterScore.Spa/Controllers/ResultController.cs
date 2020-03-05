using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetPromoterScore.Service;
using NetPromoterScore.Util;

namespace NetPromoterScore.Spa.Controllers
{
    [Produces("application/json")]
    [EnableCors("CORSReactPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly IScoreService _scoreService;

        public ResultController(IScoreService scoreService) => (_scoreService) = (scoreService);

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var scoresByCompany = await _scoreService.GetListScoreByCompanyAsync();
            var cantPromotores = scoresByCompany.Where(x => x.User.UserTypeId == (int)UserTypes.Promotor).Count();
            var cantDetractores = scoresByCompany.Where(x => x.User.UserTypeId == (int)UserTypes.Detractor).Count();
            var cantEncuestados = scoresByCompany.Count();

            double nps = (cantPromotores - cantDetractores) / (float)cantEncuestados * 100;

            return Ok(nps);
        }
    }
}