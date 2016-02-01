using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DataDotNet.Models
{
    public class BarChart
    {
        public BarChart()
        {
            Data = new List<DataPoint>();
            Height = 500;
            ShowXAxis = true;
            ShowYAxis = true;
        }

        [Serializable]
        public class DataPoint
        {
            public string Label { get; set; }
            public double Value { get; set; }
            public string Color { get; set; }
        }

        public List<DataPoint> Data { get; set; }
        public int Height { get; set; }
        public bool ShowXAxis { get; set; }
        public bool ShowYAxis { get; set; }

        /// <summary>
        /// Converts the data element of the BarChart to JSON.
        /// </summary>
        /// <returns></returns>
        public string JsonData()
        {
            var serializer = new JavaScriptSerializer();

            return serializer.Serialize(Data);
            var returnObject = "[";

            List<string> objects = Data.Select(point => "{ \"label\": \"" + point.Label + "\", \"value\":" + point.Value + "}").ToList();

            returnObject += String.Join(",", objects) + "]";

            return returnObject;
        }
    }
}
