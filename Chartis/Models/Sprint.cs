using System;
using System.Collections.Generic;
using Alchemy.DataAccess;

namespace Chartis.Models
{
    public class Sprint : Entity
    {
        public ICollection<Story> Stories { get; set; }
        public string Goal { get; set; }
        public DateTime StartDate { get; set; }
    }
}