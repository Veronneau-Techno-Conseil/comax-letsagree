using System;

namespace DAL.Models
{
    public class Entity
    {
        public int Id { get; set; }
        public int EntityTypeId { get; set; }
        public int FlowId { get; set; }
        public int Index { get; set; }
    }
}
