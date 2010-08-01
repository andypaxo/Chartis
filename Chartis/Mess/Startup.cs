using System.Data.Entity.Infrastructure;
using Chartis.DataAccess;
using ChartisDomain;

namespace Chartis.Mess
{
    public static class Startup
    {
        public static void ConfigureRepository()
        {
            Database.DefaultConnectionFactory = new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0");
            Database.SetInitializer(new AlwaysRecreateDatabase<Repository>());

            using (var context = new Repository())
                CreateSampleData(context);
        }

        public static void CreateSampleData(Repository repository)
        {
            repository.Sprints.Add(new Sprint
            {
                Goal = "Undertake a long project",
                //StartDate = new DateTime(1449, 03, 27),
                Stories = new[] { new Story { Name = "Build a long wall", Notes = "As long as China" } }
            });

            repository.Sprints.Add(new Sprint
            {
                Goal = "Build a Scrum system",
                //StartDate = new DateTime(2010, 07, 24),
                Stories = new[] {
                    new Story { Name = "Test <Encoding>", Notes = "Use some \"unusual\" characters" },
                    new Story { Name = "Try a story with no extra notes" } }
            });

            repository.SaveChanges();
        }
    }
}