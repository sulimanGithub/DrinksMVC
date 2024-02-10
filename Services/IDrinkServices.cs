using DrinksMVC.Models;

namespace DrinksMVC.Services
{
    public interface IDrinkServices
    {
        IEnumerable<Drink> Drinks { get; }
        IEnumerable<Drink> PreferredDrinks { get; }
        Drink GetDrinkById(int drinkId);
    }
}
