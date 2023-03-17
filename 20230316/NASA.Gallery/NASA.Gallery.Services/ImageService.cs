using NASA.Gallery.Models;
using System.Net.Http.Json;

namespace NASA.Gallery.Services
{
    public class ImageService : IImageService
    {
        private readonly HttpClient _httpClient;

        public ImageService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ImagesCollection> Search(string filter)
        {
            return await _httpClient.GetFromJsonAsync<ImagesCollection>($"search?q={filter}&description={filter}&media_type=image") ?? new ImagesCollection();
        }
    }
}
