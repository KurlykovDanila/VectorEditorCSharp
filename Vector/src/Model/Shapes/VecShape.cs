using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Vector.src.Model.Shapes
{
    class VecShape
    {
        public Color ShapeColor { get; set; }
        public Color OutlineColor { get; set; }
        public double OutlineSize { get; set; }
        public double TiltAngle { get; set; }
    }
}
