namespace AsoiafWikiDb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LinqToWiki;
    using LinqToWiki.Download;
    using LinqToWiki.Generated;

    public class WikiRepository
    {
        public IEnumerable<Category> Categories { get; private set; }

        public IEnumerable<Page> Pages { get; private set; }

        public void Refresh()
        {
#if DEBUG
            Downloader.LogDownloading = true;
#endif
            var wiki = new Wiki("AsoiafWikiDb", "zh.asoiaf.wikia.com", "/api.php");
            var categoryPages =
                wiki.Query.allpages()
                    .Where(p => p.@namespace == Namespace.Category)
                    .Pages.Select(
                        p =>
                        new Page
                            {
                                info = p.info,
                                categoryinfo = p.categoryinfo,
                                categories = p.categories().ToList(),
                                langlinks = p.langlinks().ToList()
                            })
                    .ToList();
            this.Categories = wiki.Query.allcategories().ToList().Select(
                c =>
                    {
                        var category = new Category
                                           {
                                               info = c,
                                               Page =
                                                   categoryPages.FirstOrDefault(
                                                       p =>
                                                       Constants.ToCategoryTitleWithoutPrefix(p.info.title)
                                                           .Equals(c.value, StringComparison.OrdinalIgnoreCase))
                                           };
                        if (c.subcats > 0)
                        {
                            category.subCategories =
                                wiki.Query.categorymembers()
                                    .Where(
                                        cm =>
                                        cm.title == c.value.ToCategoryTitleWithPrefix() && cm.type == categorymemberstype.subcat)
                                    .ToList();
                        }

                        return category;
                    }).ToList();
            this.Pages =
                wiki.Query.allpages()
                    .Pages.Select(
                        p =>
                        new Page
                            {
                                info = p.info,
                                categoryinfo = p.categoryinfo,
                                categories = p.categories().ToList(),
                                langlinks = p.langlinks().ToList()
                            })
                    .ToList();
        }
    }
}