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
                pages = pages.Where(p => p.InAllCategories(vm.Categories));
            }

            if (vm.NotInCategories != null)
            {
                pages = pages.Where(p => !p.InAnyCategories(vm.Categories));
            }

            if (vm.ImplicitCategories != null)
            {
                var categories =
                    vm.ImplicitCategories.SelectMany(
                        c =>
                        Repository.Instance.GetSubCategories(c, includeAllDescendants: true))
                        .Distinct()
                        .Select(c => c.info.value.ToCategoryTitleWithoutPrefix())
                        .Union(vm.ImplicitCategories)
                        .ToList();
                pages = pages.Where(p => p.InAnyCategories(categories));
            }

            if (vm.NotInImplicitCategories != null)
            {
                var categories =
                    vm.NotInImplicitCategories.SelectMany(
                        c =>
                        Repository.Instance.GetSubCategories(c, includeAllDescendants: true))
                        .Distinct()
                        .Select(c => c.info.value.ToCategoryTitleWithoutPrefix())
                        .Union(vm.NotInImplicitCategories)
                        .ToList();
                pages = pages.Where(p => !p.InAnyCategories(categories));
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