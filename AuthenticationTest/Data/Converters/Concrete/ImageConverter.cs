using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace AuthenticationTest.Data.Converters.Concrete
{
    public class ImageConverter : IImageConverter
    {
        public async Task<byte[]> ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms,System.Drawing.Imaging.ImageFormat.Jpeg);
            return  ms.ToArray();        
        }

        public async Task<Image> ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;        
        }

        public async Task<string> UploadedFileToDisplayableString(IBrowserFile file)
        {
            var imageFile = file;
            var format = imageFile.ContentType;

            var resizedImageFile = await imageFile.RequestImageFileAsync(format, 300, 300);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream().ReadAsync(buffer);

            return $"data:{format};base64,{Convert.ToBase64String(buffer)}";
        }

        public string Base64ToDisplayableString(string base64)
        {
            return "data:image/*;base64," + base64;
        }
    }
}