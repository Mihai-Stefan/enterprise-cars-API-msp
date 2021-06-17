using Microsoft.AspNetCore.Http;

namespace cardata_api_v3.Models
{
    public class FileModel
    {
        public string FileName { get; set; }
        public IFormFile FormFile { get; set; }
    }
}
