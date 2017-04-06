using System;
using System.Collections.Generic;

namespace PersonService.Core.Models
{
    public interface IPerson
    {
        string AlternateName { get; set; }
        DateTime BirthDate { get; set; }
        PostalAddress BusinessAddress { get; set; }
        ICollection<ContactPoint> ContactPoints { get; set; }
        DateTime DeathDate { get; set; }
        string Description { get; set; }
        ICollection<Person> DirectReports { get; set; }
        string Email { get; set; }
        Person EmergencyContact { get; set; }
        string FirstName { get; set; }
        GenderType Gender { get; set; }
        int Height { get; set; }
        PostalAddress HomeAddress { get; set; }
        string HonorificPrefix { get; set; }
        string HonorificSuffix { get; set; }
        string Id { get; set; }
        ImageObject Image { get; set; }
        string JobTitle { get; set; }
        string LastName { get; set; }
        Person Manager { get; set; }
        string MiddleName { get; set; }
        string Name { get; set; }
        string Nationality { get; set; }
        Person Spouse { get; set; }
        int Weight { get; set; }
        Organization WorksFor { get; set; }
    }
}