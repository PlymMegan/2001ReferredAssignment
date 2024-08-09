namespace ModerationMicroservice.Entities
{
    public class Email
    {
        public int EmailID { get; set; }
        public int UserID { get; set; }
        public string EmailAddress { get; set; }

        public User User { get; set; }
    }
}
