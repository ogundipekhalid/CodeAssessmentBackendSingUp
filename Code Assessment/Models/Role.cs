﻿namespace Code_Assessment.Models
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<UserRoles> UserRoles { get; set; } = new List<UserRoles>();
    }
}