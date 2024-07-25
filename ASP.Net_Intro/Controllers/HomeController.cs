using ASP.Net_Intro.Entities;
using ASP.Net_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Intro.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
         
            return View();
        }



       
        public IActionResult Drinks()
        {
            List<Drink> drones = new List<Drink>()
            {
                new Drink()
                {
                    Id= 1,
                    Name="Latte",
                    price=4,

                },
				  new Drink()
				{
					Id= 2,
					Name="Iced Tea",
					price=2,
				},
					new Drink()
				{
					Id= 3,
					Name="Americano",
					price=5,
				},

			};
            return View(drones);
        }
   

        public IActionResult FastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood()
                {
                    Id= 1,
                    Name="Cheeseburger",
                    price=4,
                },
                new FastFood()
                {
                    Id= 2,
                    Name="Pizza",
                    price=8,
                },
                new FastFood()
                {
                    Id= 3,
                    Name = "sandwich",
                    price=4,
				}
            };
            return View(fastFoods);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal()
                {
                    Id= 1,
                    Name="Spaghetti Bolognese",
                    price=12,
                },
                new HotMeal()
                {
                    Id= 2,
                    Name="Tomato Soup",
                    price=16,
				},
                new HotMeal()
                {
                    Id= 3,
                    Name="Dushbara",
                    price=10,
                }


            };
            return View(hotMeals);

        }


       

     
    };
}
