namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;

    using LinqToWiki.Generated.Entities;

    public class Page
    {
        public infoResult info { get; set; }

        public categoryinfoResult categoryinfo { get; set; }

        public IEnumerable<categoriesSelect> categories { get; set; }

        public IEnumerable<langlinksSelect> langlinks { get; set; }
    }
}