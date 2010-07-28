using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Chartis.ViewModels.Story;
using System.ComponentModel;

namespace Chartis.ViewModels.Sprint
{
    public class SprintDetails : EntityViewModel
    {
        [DisplayName("Started On")]
        public string StartDate { get; set; }
        public IEnumerable<StorySummary> Stories { get; set; }
    }
}