using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataDotNet.Models;
using WowDotNetAPI;
using WowDotNetAPI.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bar = new BarChart();
            
            var Explorer = new WowDotNetAPI.WowExplorer(Region.US, Locale.en_US, "d6f48me7k79cqjtnhqqwzktqkjnc57g8");
            bar.Data =
                Explorer.GetGuild("wyrmrest-accord", "The Red Vanguard", GuildOptions.GetMembers)
                    .Members.Select(x => x.Character)
                    .GroupBy(x => x.Class)
                    .Select(sel => new DataPoint
                    {
                        Label = sel.Key.ToString(),
                        Value = Convert.ToDouble(sel.Count()),
                        Color = GetClassColor(sel.Key)
                    }).OrderBy(x => x.Label).ToList();
            return View(bar);
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

        public string GetClassColor(CharacterClass charClass)
        {
            switch (charClass)
            {
                case CharacterClass.DEATH_KNIGHT:
                    return "#C41F3B";
                case CharacterClass.DRUID:
                    return "#FF7D0A";
                case CharacterClass.HUNTER:
                    return "#ABD473";
                case CharacterClass.MAGE:
                    return "#69CCF0";
                case CharacterClass.MONK:
                    return "#00FF96";
                case CharacterClass.PALADIN:
                    return "#F58CBA";
                case CharacterClass.PRIEST:
                    return "#CCCCCC";
                case CharacterClass.ROGUE:
                    return "#FFF569";
                case CharacterClass.SHAMAN:
                    return "#0070DE";
                case CharacterClass.WARLOCK:
                    return "#9482C9";
                case CharacterClass.WARRIOR:
                    return "#C79C6E";
            }

            return "black";
        }
    }
}