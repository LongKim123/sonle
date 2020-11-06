using buoi4_lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace buoi4_lab4.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getScreenResolution()
        {
            var ListResolution = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListResolution);
        }

        public ActionResult getTypeName()
        {
            var ListTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeName);
        }
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }

        public ActionResult getGPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }

        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOS);
        }

        public ActionResult getInches()
        {
            var ListInches = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInches);
        }

        //public ActionResult getSpeed()
        //{
        //    var ListSpeeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key.ToString());
        //    return PartialView(ListSpeeed);
        //}

        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key.ToString());
            return PartialView(ListRam);
        }
    }
}