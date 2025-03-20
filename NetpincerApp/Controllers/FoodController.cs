﻿using Microsoft.AspNetCore.Mvc;
using HotelGuru.Services;

namespace HotelGuru.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        public IActionResult List()
        {
            var result = _foodService.List();
            return Ok(result);
        }
    }
}
