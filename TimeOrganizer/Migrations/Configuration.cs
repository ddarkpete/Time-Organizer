namespace TimeOrganizer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using TimeOrganizer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TimeOrganizer.Models.TimeOrganizerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TimeOrganizer.Models.TimeOrganizerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            
                context.Users.AddOrUpdate(
                    u => u.Id,
                    new User() { Id = 1, Nickname = "Marik1234", Password = "dupa1234" },
                    new User() { Id = 2, Nickname = "Testoviron", Password = "blendzior1" },
                    new User() { Id = 3, Nickname = "Kapitan Bomba", Password = "nap1340L4my" }
                    );
                context.Activities.AddOrUpdate(
                    a => a.Id,
                    new Activity() { Id = 1, ActivityName = "Przegrywienie", ActivityDescription = "bycie pechowcem", ActivityTime = 1440, UserId = 1 },
                    new Activity() { Id = 2, ActivityName = "Wyzywanie w internecie", ActivityDescription = "szkalowanie wszstkich i wzystkiego na potêge", ActivityTime = 900, UserId = 1 },
                    new Activity() { Id = 3, ActivityName = "Trening brzucha", ActivityDescription = "utrzymanie najlepszego brzucha na polskim jutubie", ActivityTime = 60, UserId = 2 },
                    new Activity() { Id = 4, ActivityName = "Bycie na misji", ActivityDescription = "strzelanie do kosmitów", ActivityTime = 240, UserId = 3 }
                    );
                SaveChanges(context);
            
            


        }
        private void SaveChanges(DbContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var failure in ex.EntityValidationErrors)
                {
                    sb.AppendFormat("{0} failed validation\n", failure.Entry.Entity.GetType());
                    foreach (var error in failure.ValidationErrors)
                    {
                        sb.AppendFormat("- {0} : {1}", error.PropertyName, error.ErrorMessage);
                        sb.AppendLine();
                    }
                }

                throw new DbEntityValidationException(
                    "Entity Validation Failed - errors follow:\n" +
                    sb.ToString(), ex
                ); // Add the original exception as the innerException
            }
        }
    }
}
