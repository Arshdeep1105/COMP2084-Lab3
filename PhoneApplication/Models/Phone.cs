using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            this.DateReleased = DateTime.Now;
            this.PhoneName = "";
        }

        [Key]
        public int PhoneID { get; set; }
        public string PhoneName { get; set; }
        public int MSRP { get; set; }
        public double ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }
        public string Manufacturer { get; set; }
    }
}