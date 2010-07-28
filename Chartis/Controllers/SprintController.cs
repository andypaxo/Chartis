using System.Web.Mvc;
using System.Linq;
using Alchemy.DataAccess;
using Chartis.Models;
using Chartis.ViewModels.Sprint;
using Chartis.ViewModels.Story;

namespace Chartis.Controllers
{
    public class SprintController : Controller
    {
        public ActionResult Listing()
        {
            return View(Repository.GetEvery<Sprint>().Select(x =>
                new SprintSummary
                {
                    Id = x.Id,
                    Title = x.Goal
                }));
        }

        public ActionResult Details(long id)
        {
            var sprint = Repository.Get<Sprint>(id);
            var stories = sprint.Stories.Select(x =>
                new StorySummary {
                    Id = x.Id,
                    Title = x.Name
                });
            return View(new SprintDetails
            {
                Id = sprint.Id,
                Title = sprint.Goal,
                StartDate = sprint.StartDate.ToLongDateString(),
                Stories = stories
            });
        }
    }
}
