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
    public class RestaurantPickerController : ControllerBase
    {

        private readonly RestaurantPickerService _restaurantPickerService;

        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _restaurantPickerService = restaurantPickerService;
        }
        

    [HttpGet]
    [Route("RestaurantPicker/{userChoice}")]
    public string RestaurantMethod(string userChoice)
    {
        return _restaurantPickerService.RestaurantMethod(userChoice);
    }

    }
}