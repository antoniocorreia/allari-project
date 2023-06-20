namespace allari_project.Models
{
    public class Plant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BotanicalName { get; set; }
        public string? Type { get; set; }
        public string? CommonNames { get; set; }
        public string? Link { get; set; }
        public string? ImageUrl { get; set; }
    }
}
