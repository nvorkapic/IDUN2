using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDUN2.Models
{
    public class SetupConfiguration
    {
        public string Measurement { get; set; }


        public bool ThresholdEnabled { get; set; }
        public double? ThresholdMin { get; set; }
        public double? ThresholdMax { get; set; }

        public int Interval { get; set; }

        //Quick Report without Service Request 1
        //Quick Report with Service Request 2
        //Fault Report 3
        public int ReportOption { get; set; }

        public int MeasurementDensity { get; set; }
    }
}
