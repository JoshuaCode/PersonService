namespace PersonService.Core.Models
{
    public class PostalAddress : ValueObject<PostalAddress>
    {
        protected PostalAddress()
        { }

        public PostalAddress(string addressCountry, string addressCity, string addressState, string postOfficeBoxNumber, string postalCode, string streetAddress)
        {
            AddressCountry = addressCountry;
            AddressCity = addressCity;
            AddressState = addressState;
            PostOfficeBoxNumber = postOfficeBoxNumber;
            PostalCode = postalCode;
            StreetAddress = streetAddress;
        }

        public string AddressCountry { get; protected set;  }
        public string AddressCity { get; protected set;  }
        public string AddressState { get; protected set;  }
        public string PostOfficeBoxNumber { get; protected set;  }
        public string PostalCode { get; protected set;  }
        public string StreetAddress { get; protected set;  }
    }
}
