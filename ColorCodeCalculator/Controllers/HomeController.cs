using ColorCodeCalculator.BLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ColorCodeCalculator.Controllers
{
    public class HomeController : Controller
    {
        ResistorOhmCalculator obj = new BLogic.ResistorOhmCalculator();

        public ActionResult Index()
        {

            List<SelectListItem> colBand1 = obj.getColorBand1List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString() })
                .ToList<SelectListItem>();

            List<SelectListItem> colBand2 = obj.getColorBand2List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString() })
                .ToList<SelectListItem>();

            List<SelectListItem> colBand3 = obj.getColorBand3List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString() })
                .ToList<SelectListItem>();

            List<SelectListItem> colBand4 = obj.getColorBand4List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString() })
                .ToList<SelectListItem>();

            ViewBag.band1 = colBand1;
            ViewBag.band2 = colBand2;
            ViewBag.band3 = colBand3;
            ViewBag.band4 = colBand4;
            return View();
        }
        [HttpPost]
        public ActionResult Index(int colBands1, int colBands2, float colBands3, float colBands4)
        {

            ViewBag.result = obj.CalculateOhmValue(colBands1, colBands2, colBands3, colBands4).ToString();
            ViewBag.tolerance = colBands4;
            List<SelectListItem> colBand1Lst = obj.getColorBand1List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString(), Selected = t.ResistanceValue == colBands1 ? true : false })
                .ToList<SelectListItem>();

            List<SelectListItem> colBand2Lst = obj.getColorBand2List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString(), Selected = t.ResistanceValue == colBands2 ? true : false })
                .ToList<SelectListItem>();

            List<SelectListItem> colBand3Lst = obj.getColorBand3List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString(), Selected = t.ResistanceValue == colBands3 ? true : false })
                .ToList<SelectListItem>();

            List<SelectListItem> colBand4Lst = obj.getColorBand4List()
                .Select(t => new SelectListItem { Text = t.Color, Value = t.ResistanceValue.ToString(), Selected = t.ResistanceValue == colBands4 ? true : false })
                .ToList<SelectListItem>();


            ViewBag.colBands1 = colBand1Lst;
            ViewBag.colBands2 = colBand2Lst;
            ViewBag.colBands3 = colBand3Lst;
            ViewBag.colBands4 = colBand4Lst;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}