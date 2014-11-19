namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;

    public class PageIndexViewModel
    {
        public int Top { get; set; }

        public string OrderBy { get; set; }

        public bool Desc { get; set; }

        public Redirect Redirect { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public IEnumerable<string> NotInCategories { get; set; }

        public IEnumerable<Page> Pages { get; set; }
    }
}