using System;

namespace DAL.Models
{
    public class EntityAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EntityTypeId { get; set; }
        public int ValueTypeId { get; set; }
        public int? ActionTypeId { get; set; }
        public int TranslationId{get;set;}
        public int Index { get; set; }
    }
}
