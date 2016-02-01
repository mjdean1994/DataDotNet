using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using DataDotNet.Models;
using RazorEngine;
using RazorEngine.Templating;

namespace DataDotNet
{
    public static class DataDotNetExtensions
    {
        public static MvcHtmlString BarChart(this HtmlHelper helper, BarChart model)
        {
            //if (model.Data == null || model.Data.Count <= 0)
            //{
            //    return new MvcHtmlString("Cannot generate Pie Chart without data.");
            //}

            var template = GetTemplate("DataDotNet.Views.BarChart.cshtml");

            // parse template using RazorEngine
            var html = Engine.Razor.RunCompile(template, "BarChart", null, model);

            return new MvcHtmlString(html);
        }

        /// <summary>
        /// Read an embedded resource as a string
        /// </summary>
        private static string GetTemplate(string resourceName)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new System.IO.StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
        }
    }
}
