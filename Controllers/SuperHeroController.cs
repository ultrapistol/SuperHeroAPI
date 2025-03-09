﻿using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI_Dotnet8.Entities;

namespace SuperHeroAPI_Dotnet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero
                {
                    Id = 1,
                    Name = "Spiderman",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            }; 

            return Ok(heroes);
        }
    }
}
