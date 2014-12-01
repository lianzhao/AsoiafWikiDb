namespace AsoiafWikiDb.Models
{
    using System;

    using LinqToWiki;

    using Newtonsoft.Json.Linq;

    public class NamespaceConverter : JsonCreationConverter<Namespace>
    {
        protected override Namespace Create(Type objectType, JObject jObject)
        {
            var id = jObject["Id"];
            if (id != null)
            {
                int intId;
                if (int.TryParse(id.ToString(), out intId))
                {
                    return Namespace.Get(intId);
                }
            }
            return null;
        }
    }
}