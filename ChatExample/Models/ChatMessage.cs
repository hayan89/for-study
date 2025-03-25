namespace ChatExample.Models
{
    public class ChatMessage
    {
        public string? Username { get; set; }
        public string? Message { get; set; }
        public string? Time { get; set; }
        public string Guid { get; set; } = string.Empty;
    }
}
