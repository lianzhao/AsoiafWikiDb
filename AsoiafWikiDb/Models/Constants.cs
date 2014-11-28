namespace AsoiafWikiDb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LinqToWiki.Generated.Entities;

    public static class Constants
    {
        public const string WikiSiteUri = "http://zh.asoiaf.wikia.com/wiki/";

        public const string EnWikiSiteUri = "http://awoiaf.westeros.org/index.php/";

        public const string CategoryPrefix = "Category:";

        public static readonly int CategoryPrefixLength = CategoryPrefix.Length;

        public static string ToCategoryTitleWithPrefix(this string category)
        {
            if (category.StartsWith(CategoryPrefix, StringComparison.OrdinalIgnoreCase))
            {
                return category;
            }
            else
            {
                return string.Format("{0}{1}", CategoryPrefix, category);
            }
        }

        public static string ToCategoryTitleWithoutPrefix(this string category)
        {
            if (category.StartsWith(CategoryPrefix, StringComparison.OrdinalIgnoreCase))
            {
                return category.Substring(CategoryPrefixLength);
            }
            else
            {
                return category;
            }
        }

        public static string ToWikiPageUri(this string pageTitle, string siteUri = WikiSiteUri)
        {
            return string.Format("{0}{1}", siteUri, pageTitle);
        }

        public static bool InCategory(this Page page, string category)
        {
            return page.categories.Select(c => c.title.ToCategoryTitleWithoutPrefix()).Contains(category);
        }

        public static bool InAnyCategories(this Page page, IEnumerable<string> categories)
        {
            return page.categories.Select(c => c.title.ToCategoryTitleWithoutPrefix()).Intersect(categories).Any();
        }

        public static bool InAllCategories(this Page page, IEnumerable<string> categories)
        {
            var count = categories.Count();
            return page.categories.Select(c => c.title.ToCategoryTitleWithoutPrefix()).Intersect(categories).Count()
                   == count;
        }

        public static string GetUri(this langlinksSelect langlink)
        {
            if (langlink.lang == "en")
            {
                return string.Format("{0}{1}", EnWikiSiteUri, langlink.value);
            }
            return null;
        }
    }
}