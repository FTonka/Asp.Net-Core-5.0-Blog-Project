using Microsoft.AspNetCore.Http;
using System.IO;
using System;

namespace BlogProject.Models
{
    public class AddImageFile
    {

        public IFormFile WriterImage { get; set; }

    }
}
