using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDotNet.Models
{
    [Serializable]
    public class DataPoint
    {
        public string Label { get; set; }
        public double Value { get; set; }
        public string Color { get; set; }
    }
}
