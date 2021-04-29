using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public class UserType
    {
        public int Id{get;set;}
        public string Code { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
