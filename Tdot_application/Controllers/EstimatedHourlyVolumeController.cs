using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tdot_application.Models;

namespace Tdot_application.Controllers
{
    public class EstimatedHourlyVolumeController : Controller
    {
        // GET: EstimatedHourlyVolume
        public ActionResult HourlyVolume()
        {
            var hourly_volume = new EstimatedHourlyVolume()
            {
                HourOne = 893,
                HourTwo = 594,
                HourThree = 577,
                HourFour = 638,
                HourFive = 888,
                HourSix = 1767,
                HourSeven = 3484,
                HourEight = 6213,
                HourNine = 5611,
                HourTen = 5450,
                HourEleven = 4921,
                HourTweleve = 5048,
                HourThriteen = 5259,
                HourFourteen = 5510,
                HourFifteen = 5816,
                HourSixteen = 6022,
                HourSeventeen = 6281,
                HourEighteen = 6418,
                HourNineteen = 4973,
                HourTwenty = 3879,
                HourTwentyOne = 3314,
                HourTwentyTwo = 2580,
                HourTwentyThree = 1834,
                HourTwentyFour = 1206,
            };
            //return View(hourly_volume);
            //return HttpNotFound();
            return RedirectToAction("Index", "Home");
        }
    }
}