using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Services.Common;

namespace ChartisDomain
{
    [DataServiceKey("SprintId")]
    public class Sprint
    {
        public int SprintId { get; set; }
        public ICollection<Story> Stories { get; set; }
        public string Goal { get; set; }
        //public DateTime StartDate { get; set; }
    }
}