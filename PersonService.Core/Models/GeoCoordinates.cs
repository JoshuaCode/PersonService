namespace PersonService.Core.Models
{
    public class GeoCoordinates : ValueObject<GeoCoordinates>
    {
        protected GeoCoordinates()
        { }

        public GeoCoordinates(PostalAddress address, string country, double elevation, double latitude, double longitude, string postalCode)
        {
            Address = address;
            Country = country;
            Elevation = elevation;
            Latitude = latitude;
            Longitude = longitude;
            PostalCode = postalCode;
        }

        public PostalAddress Address { get; protected set;  }
        public string Country { get; protected set;  }
        public double Elevation { get; protected set;  }
        public double Latitude { get; protected set;  }
        public double Longitude { get; protected set;  }
        public string PostalCode { get; protected set;  }
    }
}
