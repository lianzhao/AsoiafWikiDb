namespace AsoiafWikiDb.Models
{
    using System.Data.Entity.Migrations;

    public class DbConfiguration : DbMigrationsConfiguration<AsoiafWikiDbContext>
    {
        public DbConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }
    }
}