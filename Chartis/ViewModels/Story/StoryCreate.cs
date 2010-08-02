namespace Chartis.ViewModels.Story
{
    public class StoryCreate : EntityCreateModel
    {
        public int SprintId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public override string EntityType { get { return "Story"; } }
    }
}