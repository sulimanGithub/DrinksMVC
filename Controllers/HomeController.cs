using DrinksMVC.Models;
using DrinksMVC.Services;
using DrinksMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DrinksMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDrinkServices _drinkServices;
        public HomeController(ILogger<HomeController> logger, IDrinkServices drinkServices)
        {
            _logger = logger;
            _drinkServices = drinkServices;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
               PreferredDrinks = _drinkServices.PreferredDrinks
            };
            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}