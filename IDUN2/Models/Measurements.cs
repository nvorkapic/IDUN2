using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDUN2.Models
{
    class Measurements
    {
        public int Usage { get; set; }
        //Max Threshold Value
        public int MaxUsage { get; set; } 

        public double Pressure { get; set; }
        //Min Threshold Value
        public double minPressure { get; set; } 
        //Max Threshold Value
        public double maxPressure { get; set; } 

        public double Temperature { get; set; }
        //Min Threshold Value
        public double minTemperature { get; set; } 
        //Max Threshold Value
        public double maxTemperature { get; set; } 

        public double Humidity { get; set; }
        //Min Threshold Value
        public double minHumidity { get; set; } 
        //Max Threshold Value
        public double maxHumidity { get; set; } 

        //Scalar
        public double MagneticField { get; set; } 
        //Max Threshold Value (need scalar)
        public double maxMagneticField { get; set; } 
        //Vector components
        public double MagneticFieldX { get; set; }
        public double MagneticFieldY { get; set; }
        public double MagneticFieldZ { get; set; }
        
        //Scalar
        public double Gyroscope { get; set; } 
        //Max Threshold Value (need scalar)
        public double maxGyroscope { get; set; } 
        //Vector components
        public double GyroscopeX { get; set; } 
        public double GyroscopeY { get; set; }
        public double GyroscopeZ { get; set; }
        
        //Scalar
        public double Acceleration { get; set; } 
        //Max Threshold Value (need scalar)
        public double maxAcceleration { get; set; } 
        //Vector components
        public double AccelerationX { get; set; } 
        public double AccelerationY { get; set; }
        public double AccelerationZ { get; set; } 

        //Checker
        public string Measurement { get; set; }
        public bool MChecked { get; set; }
    }

}
