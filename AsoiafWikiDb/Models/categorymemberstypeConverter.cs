namespace AsoiafWikiDb.Models
{
    using System;

    using LinqToWiki.Generated;

    using Newtonsoft.Json.Linq;

    public class categorymemberstypeConverter : JsonCreationConverter<categorymemberstype>
    {
        protected override categorymemberstype Create(Type objectType, JObject jObject)
        {
            var obj = jObject["Value"];
            if (obj != null)
            {
                var value = obj.ToString();
                if (value == categorymemberstype.file.Value)
                {
                    return categorymemberstype.file;
                }
                else if (value == categorymemberstype.page.Value)
                {
                    return categorymemberstype.page;
                }
                else if (value == categorymemberstype.subcat.Value)
                {
                    return categorymemberstype.subcat;
                }
            }
            return null;
        }
    }
}