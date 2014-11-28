namespace AsoiafWikiDb.Models
{
    public class MasterCode
    {
        public virtual int Id { get; set; }

        public virtual string Key { get; set; }

        public virtual string Value { get; set; }

        public virtual string Category { get; set; }
    }
}