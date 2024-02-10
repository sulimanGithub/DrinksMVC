using DrinksMVC.Data;
using DrinksMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinksMVC.Services
{
    public class DrinkServices: IDrinkServices
    {
        private readonly AppDbContext _appDbContext;

        public DrinkServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferredDrinks => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId) => _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
    }
}
 