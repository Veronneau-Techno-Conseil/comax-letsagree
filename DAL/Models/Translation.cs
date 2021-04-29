using System;

namespace DAL.Models
{
    public class Translation
    {
        public int Id {get;set;}
        public string Code { get; set; }
        public string LanguageCode { get; set; }
        public string Value { get; set; }
    }
}
