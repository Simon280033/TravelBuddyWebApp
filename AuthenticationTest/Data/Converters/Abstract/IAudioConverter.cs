using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Forms;

namespace AuthenticationTest.Data
{
    public interface IAudioConverter
    {
        public Task<string> UploadedFileToBase64String(IBrowserFile file);
    }
}