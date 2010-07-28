using Chartis.Models;
using Alchemy.DataAccess;
using System;

namespace Chartis.Mess
{
    public static class Startup
    {
        public static void Execute()
        {
            Repository.AddStore(typeof(Sprint));
            Repository.AddStore(typeof(Story));

            Repository.Save(new Sprint {
                Goal = "Undertake a long project",
                StartDate=new DateTime(1449, 03, 27),
                Stories=new [] {
                    Repository.Save(new Story { Name = "Build a long wall", Notes = "As long as China" })
                }
            });

            Repository.Save(new Sprint {
                Goal = "Build a Scrum system",
                StartDate = new DateTime(2010, 07, 24),
                Stories = new[] {
                    Repository.Save(new Story { Name = "Test <Encoding>", Notes = "Use some \"unusual\" characters" }),
                    Repository.Save(new Story { Name = "Try a story with no extra notes" })
                }
            });
        }
    }
}