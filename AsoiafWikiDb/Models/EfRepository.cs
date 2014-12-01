namespace AsoiafWikiDb.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using Newtonsoft.Json;

    public class EfRepository
    {
        public const string CategoriesKey = "Categories";

        public const string PagesKey = "Pages";

        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Page> Pages { get; set; }

        public void Refresh()
        {
            var setting = new JsonSerializerSettings();
            setting.ContractResolver = new PrivateSetterContractResolver();
            setting.ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor;
            setting.Converters.Add(new NamespaceConverter());
            setting.Converters.Add(new categorymemberstypeConverter());
            using (var db = new AsoiafWikiDbContext())
            {
                Categories =
                    db.MasterCodes.Where(mc => mc.Category == CategoriesKey)
                        .ToList()
                        .Select(mc => JsonConvert.DeserializeObject<Category>(mc.Value, setting))
                        .ToList();
                Pages =
                    db.MasterCodes.Where(mc => mc.Category == PagesKey)
                        .ToList()
                        .Select(mc => JsonConvert.DeserializeObject<Page>(mc.Value, setting))
                        .ToList();
            }
        }

        public void Save()
        {
            using (var db = new AsoiafWikiDbContext())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE [MasterCodes]");
                var categories =
                    Categories.Select(
                        c =>
                        new MasterCode
                            {
                                Key = c.info.value,
                                Value = JsonConvert.SerializeObject(c),
                                Category = CategoriesKey,
                            });
                db.MasterCodes.AddRange(categories);
                var pages =
                    Pages.Select(
                        p =>
                        new MasterCode
                            {
                                Key = p.info.title,
                                Value = JsonConvert.SerializeObject(p),
                                Category = PagesKey
                            });
                db.MasterCodes.AddRange(pages);
                db.SaveChanges();
            }
        }
    }
}