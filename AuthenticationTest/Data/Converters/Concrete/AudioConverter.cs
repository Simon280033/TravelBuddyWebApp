using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace AuthenticationTest.Data.Converters.Concrete
{
    public class AudioConverter : IAudioConverter
    {
        const int OneMb = 1024 * 1024;

        public async Task<string> UploadedFileToBase64String(IBrowserFile file)
        {
            IBrowserFile audioFile = file;
            var buffers = new byte[audioFile.Size];
            await audioFile.OpenReadStream().ReadAsync(buffers);
            string fileType = audioFile.ContentType;

            return Convert.ToBase64String(buffers);
            // Below includes info for playing (doesn't work dynamically)
            //return $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
        }
    }
}