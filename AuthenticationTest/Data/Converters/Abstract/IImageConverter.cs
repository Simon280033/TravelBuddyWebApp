using System.Drawing;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace AuthenticationTest.Data
{
    public interface IImageConverter
    {
        public Task<byte[]> ImageToByteArray(Image imageIn);
        
        public Task<Image> ByteArrayToImage(byte[] byteArrayIn);

        public Task<string> UploadedFileToDisplayableString(IBrowserFile file);
        
        public string Base64ToDisplayableString(string base64);
    }
}