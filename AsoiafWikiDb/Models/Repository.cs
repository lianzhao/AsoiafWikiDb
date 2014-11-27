namespace AsoiafWikiDb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    using LinqToWiki;
    using LinqToWiki.Download;
    using LinqToWiki.Generated;

    public class Repository
    {
        public static readonly Repository Instance = new Repository();

        public IEnumerable<Category> Categories { get; private set; }

        public IEnumerable<Page> Pages { get; private set; }

        private Repository()
        {
        }

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
                                                       p.info.title.ToCategoryTitleWithoutPrefix()
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

        public IEnumerable<Category> GetSubCategories(string title, bool includeAllDescendants = false)
        {
            var root =
                this.Categories.FirstOrDefault(c => c.info.value.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (root == null)
            {
                // 这里本应 throw new ArgumentException("no such category");
                // 但维基里有一些特殊分类，它属于某上级分类的子分类，但它不在所有分类中，导致root为空
                // 目前已知的这种分类包括：
                // 1. Category:拉扎林人物，它是Category:东大陆人物的子分类
                // 2. Category:罗拉斯人物，它是Category:自由贸易城邦人物的子分类
                // 猜测其共通的特性为
                // 1. 它有上级分类
                // 2. 本身不包含任何page、file或者subcat
                // 3. 本身是一个page
                return Enumerable.Empty<Category>();
            }

            if (root.subCategories == null)
            {
                return Enumerable.Empty<Category>();
            }

            var subCats = root.subCategories.Select(c => c.title.ToCategoryTitleWithoutPrefix()).ToList();
            var rv = this.Categories.Where(c => subCats.Contains(c.info.value));
            if (!includeAllDescendants)
            {
                return rv;
            }

            return subCats.Aggregate(rv, (current, subCat) => current.Union(this.GetSubCategories(subCat, true)));
        }
    }
}