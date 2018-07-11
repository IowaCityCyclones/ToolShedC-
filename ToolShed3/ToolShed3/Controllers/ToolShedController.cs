using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToolShed.Controllers
{
    public class ToolShedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 

        // GET: ToolShed about page
        public ActionResult About() {
            return View();
        }

        // GET: ToolShed inventory page
        public ActionResult Inventory() {
            return View();
        }

        // GET: ToolShed contact page
        public ActionResult Contact() {
            return View();
        }
    }
}