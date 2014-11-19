namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;

    using LinqToWiki.Generated.Entities;

    public class CategoryIndexViewModel
    {
        public int Top { get; set; }

        public string OrderBy { get; set; }

        public bool Desc { get; set; }

        public Hide Hide { get; set; }

        public string ChartType { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}