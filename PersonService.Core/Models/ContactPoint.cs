using System;

namespace PersonService.Core.Models
{
    public class ContactPoint : ValueObject<ContactPoint>
    {
        protected ContactPoint()
        {
        }
        public ContactPoint(string contactType, string email, string faxNumber, string telephone, string alternateName, string description, string name)
        {
            ContactType = contactType;
            Email = email;
            FaxNumber = faxNumber;
            Telephone = telephone;
            AlternateName = alternateName;
            Description = description;
            Name = name;
        }

        public string ContactType { get; protected set; }
        public string Email { get; protected set; }
        public string FaxNumber { get; protected set; }
        public string Telephone { get; protected set; }
        public string AlternateName { get; protected set;}
        public string Description { get; protected set;}
        public string Name { get; protected set;}
    }
}
