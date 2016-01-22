using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDotNet.Models
{
    public class PieChartOptions
    {
        public PieChartOptions()
        {
            OuterRadius = 200;
            InnerRadius = 0;
            ColorScale = ColorScale.Category10;
            ShowLabels = true;
        }

        public int OuterRadius { get; set; }
        public int InnerRadius { get; set; }
        public ColorScale ColorScale { get; set; }
        public bool ShowLabels { get; set; }
    }
}
