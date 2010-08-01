using System.Data.Entity;
using ChartisDomain;

namespace Chartis.DataAccess
{
    public class Repository : DbContext
    {
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Story> Stories { get; set; }
    }
}