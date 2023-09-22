namespace Sample.Core.Shared.Messages
{
    public abstract class Event
    {
        public Event()
        {
            Id = Guid.NewGuid().ToString("N");
            CreateDate = DateTime.Now;
        }

        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Content { get; set; }
    }
}