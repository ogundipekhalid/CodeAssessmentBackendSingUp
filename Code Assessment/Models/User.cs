namespace Code_Assessment.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IList<UserRoles> UserRoles { get; set; } = new List<UserRoles>();
    }
}
