using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using RazorEngine;

namespace DataDotNet
{
    public static class DataDotNetExtensions
    {
        public static MvcHtmlString PieChart(this HtmlHelper helper)
        {
            var template = GetTemplate("DataDotNet.Views.Test.cshtml");

            // parse template using RazorEngine
            var html = RazorEngine.Razor.Parse(template);

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
