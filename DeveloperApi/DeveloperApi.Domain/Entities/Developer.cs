using System;

namespace DeveloperApi.Data.Entities
{
    public partial class Developer
    {
        public Guid Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime? BirthDate {get; set;}
        public DateTime? JoinDate {get; set;}
        public string Position {get; set;}
        public Array<string>? KnownTechnologies {get; set;}
    }
}