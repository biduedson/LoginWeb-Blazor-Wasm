namespace LoginWeb.Models
{
    public class SessionModel
    {
        public string Id { get; set; } = "";
        public string UserId { get; set; } = "";
        public DateTime ExpiresAt { get; set; }
        public bool IsActive { get; set; }
    }
}
