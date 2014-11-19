namespace AsoiafWikiDb.Models
{
    using System;

    public static class Constants
    {
        public const string WikiSiteUri = "http://zh.asoiaf.wikia.com/wiki/";

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

        public static string ToWikiPageUri(this string pageTitle)
        {
            return string.Format("{0}{1}", WikiSiteUri, pageTitle);
        }
    }
}