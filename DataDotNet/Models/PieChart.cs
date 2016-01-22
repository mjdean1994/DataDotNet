using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DataDotNet.Models
{
    public class PieChart
    {
        public PieChart()
        {
            Options = new PieChartOptions();
            Data = new List<PieChartData>();
        }

        public PieChart(string title)
        {
            Title = title;
            Options = new PieChartOptions();
            Data = new List<PieChartData>();
        }

        public PieChart(IList<PieChartData> data)
        {
            Data = data;
            Options = new PieChartOptions();
        }

        public PieChart(string title, IList<PieChartData> data)
        {
            Title = title;
            Data = data;
            Options = new PieChartOptions();
        } 
        
        public string Title { get; set; }
        public IList<PieChartData> Data { get; private set; }
        public PieChartOptions Options { get; set; }

        public void AddDataPoint(PieChartData dataPoint)
        {
            Data.Add(dataPoint);
        }

        public void AddDataPoints(IEnumerable<PieChartData> dataPoints)
        {
            foreach (var dataPoint in dataPoints)
            {
                Data.Add(dataPoint);
            }
        }

        public void RemoveDataPoint(PieChartData dataPoint)
        {
            Data.Remove(dataPoint);
        }

        public void RemoveDataPoints(IEnumerable<PieChartData> dataPoints)
        {
            foreach (var dataPoint in dataPoints)
            {
                Data.Remove(dataPoint);
            }
        }

        public string DataToJsonArray()
        {
            List<string> dataStrings = new List<string>();

            foreach (var dataPoint in Data)
            {
                var dataString = string.Format("\"label\": \"{0}\", \"value\": {1}",
                        dataPoint.Label, dataPoint.Value);
                if (!string.IsNullOrEmpty(dataPoint.Color))
                {
                    dataString += string.Format(", \"color\": \"{0}\"", 
                        dataPoint.Color);
                }
                if (!string.IsNullOrEmpty(dataPoint.HighlightColor))
                {
                    dataString += string.Format(", \"highlight\": \"{0}\"",
                        dataPoint.HighlightColor);
                }

                dataStrings.Add("{" + dataString + "}");
            }

            return "[" + string.Join(",", dataStrings) + "]";
        }
    }
}
