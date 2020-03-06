using PhoneApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        [NonAction]
        public List<Phone> GetPhoneList()
        {
            return new List<Phone>
            {
                new Phone
                {
                    PhoneID = 5,
                    PhoneName = "S20",
                    MSRP = 1000,
                    ScreenSize = 13.2,
                    DateReleased = DateTime.Now,
                    Manufacturer = "Samsung"
                },
            };
        }
        // GET: Phone
        public ActionResult Index()
        {

            var Phone = from p in GetPhoneList() orderby p.PhoneID select p;
            return View(Phone);
        }

    }
}