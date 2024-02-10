using DrinksMVC.Models;

namespace DrinksMVC.Services
{
    public interface IShoppingCartServices
    {
        ShoppingCart GetCart(IServiceProvider services);

        void AddToCart(Drink drink, int amount);

        int RemoveFromCart(Drink drink);

        List<ShoppingCartItem> GetShoppingCartItems();

        void ClearCart();

        decimal GetShoppingCartTotal();
    }
}
