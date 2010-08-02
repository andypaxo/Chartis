using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chartis.ViewModels.Story;
using Chartis.DataAccess;
using ChartisDomain;

namespace Chartis.Controllers
{
    public class StoryController : Controller
    {
        public ViewResult Create(int sprintId)
        {
            return View(new StoryCreate
            {
                SprintId = sprintId
            });
        }

        [HttpPost]
        public RedirectToRouteResult Create(StoryCreate model)
        {
            var repository = new Repository();
            var sprint = repository.Sprints.Find(model.SprintId);
            sprint.Stories.Add(new Story
            {
                Name = model.Name,
                Notes = model.Notes
            });
            repository.SaveChanges();

            return RedirectToAction("Details", "Sprint", new { id = model.SprintId });
        }
    }
}
