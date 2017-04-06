namespace PersonService.Core.Models
{
    public class ImageObject : ValueObject<ImageObject>
    {
        public ImageObject()
        {
        }

        public byte[] bytes { get;  }
        public string Caption { get;  }
        public string ExifData { get;  }
        public string EncodingFormat { get;  } //jpg, gif, png
        public int ContentSize { get;  }
        public int Height { get;  }
        public int Width { get;  }
        public string Description { get; }
        public ImageObject Image { get; }
        public string Name { get; }
    }
}
