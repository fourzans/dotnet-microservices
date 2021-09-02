using System;

namespace DeveloperApi
{
    public class CreateDeveloperModel
    {
        [Required]
        public string FirstName {get; set;}

        [Required]
        public string LastName {get; set;}

        public DateTime? BirthDate {get; set;}

        public DateTime? JoinDate {get; set;}

        [Required]
        public string Position {get; set;}

        public Array<string>? KnownTechnologies {get; set;}
    }
}
