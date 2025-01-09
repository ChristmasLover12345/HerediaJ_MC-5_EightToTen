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
    public class GuessItController : ControllerBase
    {
        
        private readonly GuessItService _guessItService;

        public GuessItController(GuessItService guessItService)
        {
            _guessItService = guessItService;
        }

        [HttpGet]
        [Route("GuessNumberEasy/{userGuess}")]
        public string GuessItEasy(string userGuess)
        {
            return _guessItService.GuessItEasy(userGuess);
        }

        [HttpGet]
        [Route("GuessNumberMedium/{userGuess}")]
        public string GuessItMedium(string userGuess)
        {
            return _guessItService.GuessItMedium(userGuess);
        }

        [HttpGet]
        [Route("GuessNumberHard/{userGuess}")]
        public string GuessItHard(string userGuess)
        {
            return _guessItService.GuessItHard(userGuess);
        }

    }
}