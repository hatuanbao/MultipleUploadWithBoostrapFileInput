using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleUploadWithBoostrapFileInput.Models
{
    public class FileUpload
    {
        public FileUpload()
        {
            this.FileUploads = new List<HttpPostedFileBase>();
        }

        public List<HttpPostedFileBase> FileUploads { get; set; }
    }
}