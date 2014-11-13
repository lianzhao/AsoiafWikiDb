using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsoiafWikiDb.Controllers
{
    using System.Threading.Tasks;

    using AsoiafWikiDb.Models;

    using LinqToWiki.Generated;

    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Index(string password)
        {
            Repository.Instance.Refresh();
            //var wiki = new Wiki("AsoiafWikiDb", "zh.asoiaf.wikia.com", "/api.php");
            //var allCategories = wiki.Query.allcategories().ToList();
            //var allPages = wiki.Query.allpages().ToList();
            //var allPageDetails =
            //    wiki.Query.allpages()
            //        .Pages.Select(p => new { p.info, p.categoryinfo, categories = p.categories().ToList(), })
            //        .ToList();
            //var allNightWatchers = allPageDetails.Where(p => p.categories.Any(c => c.title.EndsWith("守夜人成员"))).ToList();
            //var allBirthplaces = allCategories.Where(c => c.value.EndsWith("人物") && c.value != "人物").ToList();
            //var tmp =
            //    allBirthplaces.ToDictionary(
            //        p => p.value,
            //        p => allNightWatchers.Count(watcher => watcher.categories.Any(c => c.title.Contains(p.value))))
            //        .Where(kvp => kvp.Value > 0)
            //        .ToDictionary(kvp => kvp.Key);

            return this.View();
        }
    }
}
