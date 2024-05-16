using System.Data;

namespace Code_Assessment.Models
{
    public class UserRoles : BaseEntity
    { 
        public string UserId { get; set; }
        public User User { get; set; }
        public string RoleId { get; set; }
        public Role Role { get; set; }
    }
}
