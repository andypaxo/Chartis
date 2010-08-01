using System.Linq;
using System.Web.Mvc;
using Chartis.DataAccess;
using Chartis.ViewModels.Sprint;
using Chartis.ViewModels.Story;

namespace Chartis.Controllers
{
    public class SprintController : Controller
    {
        public ActionResult Listing()
        {
            var repository = new Repository();
            return View(repository.Sprints.Select(x =>
                new SprintSummary
                {
                    Id = x.SprintId,
                    Title = x.Goal
                }));
        }

        public ActionResult Details(long id)
        {
            var repository = new Repository();
            var sprint = repository.Sprints.Find(id);
            
            var stories =
                from story in sprint.Stories
                select new StorySummary
                {
                    Id = story.StoryId,
                    Title = story.Name,
                    Notes = story.Notes
                };

            return View(new SprintDetails
            {
                Id = sprint.SprintId,
                Title = sprint.Goal,
                //StartDate = sprint.StartDate.ToLongDateString(),
                Stories = stories
            });
        }
    }
}
