using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDotNet.Models
{
    public class PieChartData
    {
        /// <summary>
        /// The human-readable description of the data point.
        /// </summary>
        public string Label { get; set; }
        /// <summary>
        /// The value of the data point.
        /// </summary>
        public float Value { get; set; }
        /// <summary>
        /// The color of this data point. Uses the d3.js color scale defined in chart options by default.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// The color of this data point when hovered over.
        /// </summary>
        public string HighlightColor { get; set; }
    }
}
