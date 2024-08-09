namespace ModerationMicroservice.Entities
{
    public class Moderation
    {
        public int ModerationID { get; set; }
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public string ActionTaken { get; set; }
        public DateTime ActionDate { get; set; }

        public User User { get; set; }
    }
}
