using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class fileUploadController : Controller
    {
        // GET: /file/
        public ActionResult Index()
        {
            return View();
        }
        [System.Web.Mvc.HttpPost]
        public JsonResult upload(HttpPostedFileBase file)
        {
            bool result = false;
            StringBuilder strbuild = new StringBuilder();
            try
            {
                if (file.ContentLength == 0)
                    throw new Exception("Zero length file!");
                else
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var filePath = Path.Combine(Server.MapPath("~/Document"), fileName);
                    file.SaveAs(filePath);
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        using (StreamReader sr = new StreamReader(Path.Combine(Server.MapPath("~/Document"), fileName)))
                        {
                            while (sr.Peek() >= 0)
                            {
                                strbuild.AppendFormat(sr.ReadLine());
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return new JsonResult()
            {
                Data = strbuild.ToString()
            };
        }

    }
}