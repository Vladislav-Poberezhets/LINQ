using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class GeoCordinate
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }


        public GeoCordinate(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public double Distance(GeoCordinate a)
        {
            return Math.Sqrt(Math.Pow(Latitude - a.Latitude, 2) +
                   Math.Pow(Longitude - a.Longitude, 2));
        }
    }
}
