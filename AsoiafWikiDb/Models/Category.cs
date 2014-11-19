namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;

    using LinqToWiki.Generated.Entities;

    public class Category
    {
        public allcategoriesSelect info { get; set; }

        public IEnumerable<categorymembersSelect> subCategories { get; set; }
    }
}