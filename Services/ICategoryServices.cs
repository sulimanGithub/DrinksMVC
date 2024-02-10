using DrinksMVC.Models;

namespace DrinksMVC.Services
{
    public interface ICategoryServices
    {
        IEnumerable<Category> Categories { get; }
    }
}