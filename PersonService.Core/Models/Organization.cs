using System.Collections.Generic;

namespace PersonService.Core.Models
{
    public class Organization : ValueObject<Organization>
    {
       protected Organization()
        { }

        public Organization(PostalAddress address, Organization department, string duns, string email, ICollection<Person> employees, string legalName, int numberOfEmployees, Organization parentOrganization, string telephone, string taxId, ImageObject logo, string alternateName, string description, ImageObject image, string name)
        {
            Address = address;
            Department = department;
            Duns = duns;
            Email = email;
            Employees = employees;
            LegalName = legalName;
            NumberOfEmployees = numberOfEmployees;
            ParentOrganization = parentOrganization;
            Telephone = telephone;
            TaxId = taxId;
            Logo = logo;
            AlternateName = alternateName;
            Description = description;
            Image = image;
            Name = name;
        }

        public PostalAddress Address { get; protected set;  }
        public Organization Department { get; protected set;  }
        public string Duns { get; protected set;  }
        public string Email { get; protected set;  }
        public ICollection<Person> Employees { get; protected set;  }
        public string LegalName { get; protected set;  }
        public int NumberOfEmployees { get; protected set;  }
        public Organization ParentOrganization { get; protected set;  }
        public string Telephone { get; protected set;  }
        public string TaxId { get; protected set;  }
        public ImageObject Logo { get; protected set;  }
        public string AlternateName { get; protected set; }
        public string Description { get; protected set; }
        public ImageObject Image { get; protected set; }
        public string Name { get; protected set; }
    }
}
