using Azure;

namespace ModerationMicroservice.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Moderation> Moderations { get; set; }
        public ICollection<Email> Emails { get; set; }
    }
}
