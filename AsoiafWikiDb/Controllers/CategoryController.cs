namespace AsoiafWikiDb.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Mvc;

    using AsoiafWikiDb.Models;

    public class CategoryController : Controller
    {
        public ViewResult Index([FromUri]CategoryIndexViewModel vm)
        {
            var categories = Repository.Instance.Categories;
            if (vm.Hide == Hide.Yes)
            {
                categories = categories.Where(c => c.info.hidden);
            }
            else if (vm.Hide == Hide.No)
            {
                categories = categories.Where(c => !c.info.hidden);
            }

            if (!string.IsNullOrEmpty(vm.OrderBy))
            {
                if (vm.OrderBy.Equals("pages", StringComparison.InvariantCultureIgnoreCase))
                {
                    categories = vm.Desc ? categories.OrderByDescending(c => c.info.pages) : categories.OrderBy(c => c.info.pages);
                }
            }

            if (vm.Top > 0)
            {
                categories = categories.Take(vm.Top);
            }

            vm.Categories = categories.ToList();
            return this.View(vm);
        }
    }
}