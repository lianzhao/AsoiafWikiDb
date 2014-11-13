namespace AsoiafWikiDb.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Mvc;

    using AsoiafWikiDb.Models;

    using LinqToWiki.Generated.Entities;

    public class CategoryController : Controller
    {
        public ViewResult Index([FromUri]CategoryIndexViewModel vm)
        {
            IEnumerable<allcategoriesSelect> categories = Repository.Instance.Categories;
            if (vm.HiddenFilter == HiddenFilter.Hidden)
            {
                categories = categories.Where(c => c.hidden);
            }
            else if (vm.HiddenFilter == HiddenFilter.NoneHidden)
            {
                categories = categories.Where(c => !c.hidden);
            }

            if (!string.IsNullOrEmpty(vm.OrderBy))
            {
                if (vm.OrderBy.Equals("pages", StringComparison.InvariantCultureIgnoreCase))
                {
                    categories = vm.Desc ? categories.OrderByDescending(c => c.pages) : categories.OrderBy(c => c.pages);
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