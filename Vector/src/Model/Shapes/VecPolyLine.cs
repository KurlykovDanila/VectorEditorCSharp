using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vector.src.Model.Shapes
{
    class VecPolyLine : VecShape
    {
        public List<Point> Points { get; set; }
        public double Curve { get; set; }
        public bool Closed { get; set; }
    }
}
