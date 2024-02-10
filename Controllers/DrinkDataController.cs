using DrinksMVC.Models;
using DrinksMVC.Services;
using DrinksMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrinksMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkDataController : ControllerBase
    {
        private readonly IDrinkServices _drinkServices;

        public DrinkDataController(IDrinkServices drinkServices)
        {
            _drinkServices = drinkServices;
        }

        [HttpGet]
        public IEnumerable<DrinkViewModel> LoadMoreDrinks()
        {
            IEnumerable<Drink> dbDrinks = null;

            dbDrinks = _drinkServices.Drinks.OrderBy(p => p.DrinkId).Take(10);

            List<DrinkViewModel> drinks = new List<DrinkViewModel>();

            foreach (var dbDrink in dbDrinks)
            {
                drinks.Add(MapDbDrinkToDrinkViewModel(dbDrink));
            }
            return drinks;
        }

        private DrinkViewModel MapDbDrinkToDrinkViewModel(Drink dbDrink) => new DrinkViewModel()
        {
            DrinkId = dbDrink.DrinkId,
            Name = dbDrink.Name,
            Price = dbDrink.Price,
            ShortDescription = dbDrink.ShortDescription,
            ImageThumbnailUrl = dbDrink.ImageThumbnailUrl
        };

    }
}