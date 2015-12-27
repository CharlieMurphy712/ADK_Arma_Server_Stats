using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WepApplication.Models;

namespace WepApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.ids = ModelRepository.GetItemSet();
            vm.deaths = ModelRepository.GetHighestDeaths();
            vm.AnotherProperty = "Exile Taviana Leaderboards";

            return View(vm);
        }

    }
}
