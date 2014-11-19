namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;

    using LinqToWiki.Generated.Entities;

    public class AdminViewModel
    {
        public string Password { get; set; } 
    }

    public enum Hide
    {
        All = 0,
        Yes = 1,
        No = 2,
    }

    public enum RedirectFilter
    {
        All = 0,
        Yes = 1,
        No = 2,
    }

    public class CategoryIndexViewModel
    {
        public int Top { get; set; }

        public string OrderBy { get; set; }

        public bool Desc { get; set; }

        public Hide Hide { get; set; }

        public IEnumerable<allcategoriesSelect> Categories { get; set; }
    }

    public class PageIndexViewModel
    {
        public int Top { get; set; }

        public string OrderBy { get; set; }

        public bool Desc { get; set; }

        public RedirectFilter RedirectFilter { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<string> NotInCategories { get; set; }

        public IEnumerable<Page> Pages { get; set; }
    }
}