using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web;
using Chartis.DataAccess;
using ChartisDomain;

namespace Chartis
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ChartisData : DataService<Repository>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.SetServiceOperationAccessRule("GetAllSprints", ServiceOperationRights.AllRead);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }

        protected override void OnStartProcessingRequest(ProcessRequestArgs args)
        {
            base.OnStartProcessingRequest(args);
            //Cache for a minute based on querystring
            var context = HttpContext.Current;
            var c = HttpContext.Current.Response.Cache;
            c.SetCacheability(HttpCacheability.ServerAndPrivate);
            c.SetExpires(HttpContext.Current.Timestamp.AddSeconds(60));
            c.VaryByHeaders["Accept"] = true;
            c.VaryByHeaders["Accept-Charset"] = true;
            c.VaryByHeaders["Accept-Encoding"] = true;
            c.VaryByParams["*"] = true;
        }

        [WebGet]
        public IQueryable<Sprint> GetAllSprints()
        {
            return new Repository().Sprints;
        }
    }
}
