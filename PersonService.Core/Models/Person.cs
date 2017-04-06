using System;
using System.Collections.Generic;

namespace PersonService.Core.Models
{
    public class Person : Entity, IPerson
    {

        public string FirstName { get; set; }
        public string MiddleName { get;  set; }
        public string LastName { get;  set; }
        public string HonorificPrefix { get;  set; }
        public string HonorificSuffix { get;  set; }
        public string Email { get;  set; }
        public PostalAddress BusinessAddress { get;  set; }
        public PostalAddress HomeAddress { get;  set; }
        public DateTime BirthDate { get;  set; }
        public ICollection<ContactPoint> ContactPoints { get;  set; }
        public DateTime DeathDate { get;  set; }
        public int Height { get;  set; }
        public int Weight { get;  set; }
        public GenderType Gender { get;  set; }
        public string JobTitle { get;  set; }
        public Organization WorksFor { get;  set; }
        public Person Manager { get;  set; }
        public ICollection<Person> DirectReports { get;  set; }
        public string Nationality { get;  set; }
        public Person Spouse { get;  set; }
        public Person EmergencyContact { get;  set; }
        public string AlternateName { get;  set; }
        public string Description { get;  set; }
        public string Id { get;  set; }
        public ImageObject Image { get;  set; }
        public string Name { get;  set; }
    }
}
