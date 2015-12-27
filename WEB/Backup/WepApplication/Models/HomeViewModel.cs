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
        public string AnotherProperty { get; set; }
    }
}