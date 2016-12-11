using MultipleUploadWithBoostrapFileInput.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultipleUploadWithBoostrapFileInput.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(FileUpload model)
        {
            foreach (var file in model.FileUploads)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var path = Server.MapPath("~/Content/UploadImages/" + file.FileName);
                    file.SaveAs(path);
                }
            }

            return View("Index");
        }
    }
}