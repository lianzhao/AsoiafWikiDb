﻿namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using LinqToWiki.Generated;
    using LinqToWiki.Generated.Entities;

    public class Repository
    {
        public static readonly Repository Instance = new Repository();

        public IEnumerable<allcategoriesSelect> Categories { get; private set; }

        public IEnumerable<Page> Pages { get; private set; }

        private Repository()
        {
        }

        public void Refresh()
        {
            var wiki = new Wiki("AsoiafWikiDb", "zh.asoiaf.wikia.com", "/api.php");
            this.Categories = wiki.Query.allcategories().ToList();
            this.Pages =
                wiki.Query.allpages()
                    .Pages.Select(
                        p =>
                        new Page { info = p.info, categoryinfo = p.categoryinfo, categories = p.categories().ToList(), })
                    .ToList();
        }

        public IEnumerable<Page> GetPagesByCategory(params string[] categories)
        {
            return this.Pages.Where(p => p.categories.Any(c => categories.Contains(c.title)));
        }
    }

    public class Page
    {
        public infoResult info { get; set; }

        public categoryinfoResult categoryinfo { get; set; }

        public IEnumerable<categoriesSelect> categories { get; set; }
    }
}