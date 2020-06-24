using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vector.src.Model.Shapes
{
    class VecLine : VecShape
    {
        public List<Point> points { get; set; }
        public double curve { get; set; }
    }
}
