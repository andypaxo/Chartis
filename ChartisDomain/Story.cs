using System.Data.Services.Common;

namespace ChartisDomain
{
    [DataServiceKey("StoryId")]
    public class Story
    {
        public int StoryId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public Sprint Sprint { get; set; }
    }
}