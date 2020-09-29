using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using WebApplication1.Models;
using System.Data;
using System.Data.Sql;

namespace WebApplication1.Controllers
{
    public class CargarController : Controller
    {
        public ActionResult Cargar()
        {
            return View();
        }
    }
}