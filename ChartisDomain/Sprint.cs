using System;
using System.Collections.Generic;

namespace ChartisDomain
{
    public class Sprint
    {
        public int SprintId { get; set; }
        public virtual ICollection<Story> Stories { get; set; }
        public string Goal { get; set; }
        //public DateTime StartDate { get; set; }
    }
}