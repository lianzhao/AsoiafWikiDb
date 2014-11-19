namespace AsoiafWikiDb.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Mvc;

    using AsoiafWikiDb.Models;

    public class PageController : Controller
    {
        public ViewResult Index([FromUri]PageIndexViewModel vm)
        {
            var pages = Repository.Instance.Pages;
            if (vm.Redirect == Models.Redirect.Yes)
            {
                pages = pages.Where(p => p.info.redirect);
            }
            else if (vm.Redirect == Models.Redirect.No)
            {
                pages = pages.Where(p => !p.info.redirect);
            }

            if (vm.Categories != null)
            {
                var count = vm.Categories.Count();
                pages =
                    pages.Where(
                        p =>
                        p.categories.Select(c => c.title.Substring(Extensions.CategoryPrefixLength)).Intersect(vm.Categories).Count() == count);
            }

            if (vm.NotInCategories != null)
            {
                pages =
                    pages.Where(
                        p =>
                        !p.categories.Select(c => c.title.Substring(Extensions.CategoryPrefixLength)).Intersect(vm.NotInCategories).Any());
            }

            if (vm.Top > 0)
            {
                pages = pages.Take(vm.Top);
            }

            if (!string.IsNullOrEmpty(vm.OrderBy))
            {
                if (vm.OrderBy.Equals("title", StringComparison.InvariantCultureIgnoreCase))
                {
                    pages = vm.Desc ? pages.OrderByDescending(p => p.info.title) : pages.OrderBy(p => p.info.title);
                }
            }

            vm.Pages = pages.ToList();

            return this.View(vm);
        }
    }
}