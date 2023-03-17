using NASA.Gallery.Models;

namespace NASA.Gallery.Services
{
    public interface IImageService
    {
        Task<ImagesCollection> Search(string filter);
    }
}
