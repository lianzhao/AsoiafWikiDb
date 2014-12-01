namespace AsoiafWikiDb.Models
{
    using System.Data.Entity;

    public class AsoiafWikiDbContext : DbContext
    {
        public DbSet<MasterCode> MasterCodes { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    Database.SetInitializer(new MigrateDatabaseToLatestVersion<AsoiafWikiDbContext, DbConfiguration>());
        //}
    }
}