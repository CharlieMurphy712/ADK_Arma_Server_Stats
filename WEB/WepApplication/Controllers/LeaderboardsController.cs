using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WepApplication.Models;

namespace WepApplication.Controllers
{
    public class LeaderboardsController : Controller
    {
        //
        // GET: /Leaderboards/

        public ActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel();
            vm.ids = ModelRepository.GetItemSet();
            vm.deaths = ModelRepository.GetHighestDeaths();
            vm.karma = ModelRepository.GetKarma();
            vm.money = ModelRepository.GetMoney();
            vm.joined = ModelRepository.GetJoined();
            vm.AnotherProperty = "Exile Taviana Leaderboards";

            return View(vm);
        }

    }
}
