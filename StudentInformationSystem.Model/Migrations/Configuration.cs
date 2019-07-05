namespace StudentInformationSystem.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

   public sealed class Configuration : DbMigrationsConfiguration<StudentInformationSystem.Model.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentInformationSystem.Model.Context";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(StudentInformationSystem.Model.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AutomaticMigrationsEnabled=true;
            AutomaticMigrationDataLossAllowed=true;
        }
    }
}
