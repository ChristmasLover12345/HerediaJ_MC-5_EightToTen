using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HerediaJ_MC_5_EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace HerediaJ_MC_5_EightToTen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {

            private readonly Magic8BallService _magic8BallService;

        public Magic8BallController(Magic8BallService magic8BallService)
        {
            _magic8BallService = magic8BallService;
        }

        [HttpGet]
        [Route("MagicBall/{userQuestion}")]

        public string Magic8Ball(string userQuestion)
        {
            return _magic8BallService.Magic8Ball(userQuestion);
        }

    }
}