namespace AsoiafWikiDb.Models
{
    using System;

    public static class Extensions
    {
        public const string CategoryPrefix = "Category:";

        public static readonly int CategoryPrefixLength = CategoryPrefix.Length;

        public static string ToCategoryTitle(this string category)
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
    }
}