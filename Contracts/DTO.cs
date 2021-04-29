using System;

namespace Contracts
{
    public class ActionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Component { get; set; }
    }

    public class Entity
    {
        public int Id { get; set; }
        public int EntityTypeId { get; set; }
        public int FlowId { get; set; }
        public int Index { get; set; }
    }

    public class EntityAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EntityTypeId { get; set; }
        public int ValueTypeId { get; set; }
        public int? ActionTypeId { get; set; }
        public string TranslationCode { get; set; }
        public int Index { get; set; }
    }

    public class EntityType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Flow
    {
        public int Id { get; set; }
        public int Owner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Language
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Lookup
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string TranslationCode { get; set; }
    }

    public class Translation
    {
        public string Code { get; set; }
        public string LanguageCode { get; set; }
        public string Value { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string UserType { get; set; }
    }

    public class UserType
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class ValueType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Component { get; set; }
        public string TransCode { get; set; }
        public string LookupCode { get; set; }
    }
}
