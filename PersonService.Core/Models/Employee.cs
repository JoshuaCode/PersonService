using System;
using System.Collections.Generic;

namespace PersonService.Core.Models
{
    public class Employee : Entity, IPerson
    {
        public Employee()
        {
            
        }

        public string Scid { get;  set; }
        public string Sid { get;  set;}
        public string ManagerScid { get;  set;}
        public string AlternateName { get;  set;}
        public string Description { get;  set;}
        public string Id { get;  set;}
        public ImageObject Image { get;  set;}
        public string Name { get;  set;}
        public DateTime BirthDate { get;  set;}
        public PostalAddress BusinessAddress { get;  set;}
        public ICollection<ContactPoint> ContactPoints { get;  set;}
        public DateTime DeathDate { get;  set;}
        public ICollection<Person> DirectReports { get;  set;}
        public string Email { get;  set;}
        public Person EmergencyContact { get;  set;}
        public string FirstName { get;  set;}
        public GenderType Gender { get;  set;}
        public int Height { get;  set;}
        public PostalAddress HomeAddress { get;  set;}
        public string HonorificPrefix { get;  set;}
        public string HonorificSuffix { get;  set;}
        public string JobTitle { get;  set;}
        public string LastName { get;  set;}
        public Person Manager { get;  set;}
        public string MiddleName { get;  set;}
        public string Nationality { get;  set;}
        public Person Spouse { get;  set;}
        public int Weight { get;  set;}
        public Organization WorksFor { get;  set;}
        public string RcnNumber { get;  set; }
        public string UnionCode { get;  set; }
        public string JobCode { get;  set; }
        public string JobSecription { get;  set; }
        public string AnnualRate { get;  set; }
        public string SocialSecurityNumber { get;  set; }
        public string LocationCode { get;  set; }
        public string LocationDescription { get;  set; }
        public string BinNumberDescription { get;  set; }
        public string EmployeeStatusCode { get;  set; }
        public string EmployeeStatusDescription { get;  set; }
        public string FlsaStatusCode { get;  set; }
        public string FlsaStatusDescription { get;  set; }
        public string RegularTempCode { get;  set; }
        public string RegularTempDescription { get;  set; }
        public string EmployeeClassCode { get;  set; }
        public string EmployeeClassDescription { get;  set; }
        public string FullPartTimeCode { get;  set; }
        public string FullPartTimeDescription { get;  set; }
        public string PerStatusCode { get;  set; }
        public string PerStatusDescription { get;  set; }
        public string PositionNumber { get;  set; }
        public string JobGradeCode { get;  set; }
        public DateTime OriginalHireDateTime { get;  set; }
        public DateTime HireDateTime { get;  set; }
        public DateTime ServiceDateTime { get;  set; }
        public DateTime JobEntryDateTime { get;  set; }
        public string SalaryAdministrationPlanCode { get;  set; }
        public string StepCode { get;  set; }
        public string ManagerLevel { get;  set; }
        public string CompensationFrequencyCode { get;  set; }
        public string NetworkId { get;  set; }
        public string EwoId { get;  set; }
        public string FunctionCode { get;  set; }
        public string HourlyRate { get;  set; }
        public string StandardHours { get;  set; }
        public DateTime TerminationDateTime { get;  set; }
        public string VendorId { get;  set; }
    }
}
