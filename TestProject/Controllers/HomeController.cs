using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataDotNet.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pieChart = new PieChart("Test Pie Chart");
            pieChart.Options.ShowLabels = false;
            pieChart.AddDataPoint(new PieChartData
            {
                Color = "#993366",
                HighlightColor = "#882255",
                Label = "Red Label",
                Value = 10
            });
            pieChart.AddDataPoint(new PieChartData
            {
                Color = "#669933",
                HighlightColor = "#558822",
                Label = "Green Label",
                Value = 20
            });
            pieChart.AddDataPoint(new PieChartData
            {
                Color = "#336699",
                HighlightColor = "#225588",
                Label = "Blue Label",
                Value = 30
            });
            return View(pieChart);
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