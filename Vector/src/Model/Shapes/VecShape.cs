using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.src.Model.Shapes
{
    class VecShape
    {
        private double outlineSize;
        private Color outlineColor;
        private Color shapeColor;
        private double tiltAngle;

        public Color ShapeColor { get => shapeColor; set => shapeColor = value; }
        public Color OutlineColor { get => outlineColor; set => outlineColor = value; }
        public double OutlineSize { get => outlineSize; set => outlineSize = value; }
        public double TiltAngle { get => tiltAngle; set => tiltAngle = value; }
    }
}
