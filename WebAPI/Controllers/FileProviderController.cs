using Contracts.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.FileProviders;
using System.IO;
using System.Net.Http.Headers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProviderController : ControllerBase
    {
        string MediaFolder { get; set; }
        IConfiguration _configuration;
        private IAttachmentsService attachments;
        public FileProviderController( IConfiguration _configuration, IAttachmentsService attach) :base(){

            MediaFolder = _configuration.GetSection("Configuration:Media").Value;
            attachments = attach;
        
        }



        [HttpGet("File/{fileName}")]
        public async Task<IActionResult> GetFile(string fileName)
        {
            
                var content = await System.IO.File.ReadAllBytesAsync(Directory.GetCurrentDirectory()+ Path.DirectorySeparatorChar + MediaFolder + Path.DirectorySeparatorChar + fileName);
                new FileExtensionContentTypeProvider().TryGetContentType(fileName, out string contentType);
                return File(content, contentType, fileName);
                
            
        }

        [HttpGet("File")]
        public async Task<IActionResult> GetFile2(Guid FileId)
        {
            var attach =await attachments.GetFromStore(FileId);
          
            var content = await System.IO.File.ReadAllBytesAsync(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + MediaFolder + Path.DirectorySeparatorChar + attach.FileCategory + Path.DirectorySeparatorChar + attach.FileName);
            new FileExtensionContentTypeProvider().TryGetContentType(attach.FileName, out string contentType);
            return File(content, contentType, attach.FileName);


        }


    }
}
