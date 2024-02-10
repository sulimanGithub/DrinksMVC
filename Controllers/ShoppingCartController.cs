using DrinksMVC.Models;
using DrinksMVC.Services;
using DrinksMVC.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DrinksMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkServices _drinkServices;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IDrinkServices drinkServices, ShoppingCart shoppingCart)
        {
            _drinkServices = drinkServices;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkServices.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shoppingCart.AddToCart(selectedDrink, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink = _drinkServices.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink != null)
            {
                _shoppingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");
        }

    }
}