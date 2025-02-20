namespace ProjectHive.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int ProjectId { get; set; }
    }
}
