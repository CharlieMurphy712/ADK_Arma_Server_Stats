using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepApplication.Models
{
    public class HomeViewModel
    {
        public List<account> ids { get; set; }
        public List<account> deaths { get; set; }
        public List<account> karma { get; set; }
        public List<account> money { get; set; }
        public List<account> joined { get; set; }
        public string AnotherProperty { get; set; }
    }
}