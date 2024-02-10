using DrinksMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DrinksMVC.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryMenu(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryServices.Categories.OrderBy(p => p.CategoryName);
            return View(categories);
        }
    }
}
