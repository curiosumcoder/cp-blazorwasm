using static NASA.Gallery.Models.ImageItem;

namespace NASA.Gallery.Models
{
    public class ImagesCollection
    {
        public ImageCollection Collection { get; set; } = new ImageCollection();

        public class ImageCollection
        {
            public List<ImageItem> Items { get; set; } = new List<ImageItem>();
        }
    }

    public class ImageItem
    {
        public List<ImageData> Data { get; set; } = new List<ImageData>();
        public List<ImageLink> Links { get; set; } = new List<ImageLink>();

        public class ImageData
        {
            public string Title { get; set; } = "";
            public string Location { get; set; } = "";
            public string Description { get; set; } = "";
        }

        public class ImageLink
        {
            public string Href { get; set; } = "";
        }
    }

    public class ImageDetail
    {
        public string Title { get; set; } = "";
        public string Location { get; set; } = "";
        public string Description { get; set; } = "";
        public string Href { get; set; } = "";

        public ImageDetail(ImageData id, ImageLink il)
        {
            this.Title = id.Title;
            this.Location = id.Location;
            this.Description = id.Description;
            this.Href = il.Href;
        }
    }
}