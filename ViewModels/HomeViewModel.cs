using DrinksMVC.Models;

namespace DrinksMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Drink> PreferredDrinks { get; set; }
    }
}
