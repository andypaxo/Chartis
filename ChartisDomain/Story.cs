namespace ChartisDomain
{
    public class Story
    {
        public int StoryId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public virtual Sprint Sprint { get; set; }
    }
}