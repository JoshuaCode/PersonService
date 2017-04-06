namespace PersonService.Core.Models
{
    public class Place : ValueObject<Place>
    {
        protected Place()
        { }

        public Place(PostalAddress address, GeoCoordinates geo,  string description, ImageObject image, string name)
        {
            Address = address;
            Geo = geo;
            Description = description;
            Image = image;
            Name = name;
        }

        public PostalAddress Address { get; protected set; }
        public GeoCoordinates Geo { get; protected set; }
        public string Description { get; protected set;}
        public ImageObject Image { get; protected set;}
        public string Name { get; protected set;}
    }
}
