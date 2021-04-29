using System;

namespace DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }

        public int UserTypeId{get;set;}

        public int? ParentId{get;set;}
    }
}
