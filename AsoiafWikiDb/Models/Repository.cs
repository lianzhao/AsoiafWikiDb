namespace AsoiafWikiDb.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Repository
    {
        public static readonly Repository Instance = new Repository();

        private readonly WikiRepository _wiki = new WikiRepository();

        private readonly EfRepository _db = new EfRepository();

        private Repository()
        {
        }

        public IEnumerable<Category> Categories
        {
            get
            {
                EnsureData();
                return _db.Categories;
            }
        }

        public IEnumerable<Page> Pages
        {
            get
            {
                EnsureData();
                return _db.Pages;
            }
        }

        public void Refresh()
        {
            _wiki.Refresh();
            _db.Categories = _wiki.Categories;
            _db.Pages = _wiki.Pages;
            _db.Save();
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

        private void EnsureData()
        {
            if (_db.Categories == null || !_db.Categories.Any())
            {
                _db.Refresh();
            }
            if (_db.Categories == null || !_db.Categories.Any())
            {
                Refresh();
            }
        }
    }
}