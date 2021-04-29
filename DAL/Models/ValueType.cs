using System;

namespace DAL.Models
{
    public class ValueType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Component { get; set; }
        public int TranslationId { get; set; }
        public string LookupCode { get; set; }
    }
}
