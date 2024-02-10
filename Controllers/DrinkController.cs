using DrinksMVC.Models;
using DrinksMVC.Services;
using DrinksMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DrinksMVC.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkServices _drinkServices;     
        private readonly ICategoryServices _categoryServices;

        public DrinkController(ICategoryServices categoryServices, IDrinkServices drinkServices)
        {
            _categoryServices = categoryServices;
            _drinkServices = drinkServices;
        }

        public ViewResult Index(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                drinks = _drinkServices.Drinks.OrderBy(p => p.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                    drinks = _drinkServices.Drinks.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
                else
                    drinks = _drinkServices.Drinks.Where(p => p.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new DrinksListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Drink> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                drinks = _drinkServices.Drinks.OrderBy(p => p.DrinkId);
            }
            else
            {
                drinks = _drinkServices.Drinks.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Drink/Index.cshtml", new DrinksListViewModel { Drinks = drinks, CurrentCategory = "All drinks" });
        }

        public ViewResult Details(int drinkId)
        {
            var drink = _drinkServices.Drinks.FirstOrDefault(d => d.DrinkId == drinkId);
            if (drink == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(drink);
        }
    }
}