using System;

namespace DAL.Models
{
    public class Flow
    {
        public int Id { get; set; }
        public int Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
