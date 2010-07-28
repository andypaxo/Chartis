using Alchemy.DataAccess;

namespace Chartis.Models
{
    public class Story : Entity
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public Sprint Sprint { get; set; }
    }
}