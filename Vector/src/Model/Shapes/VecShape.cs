using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Vector.src.Model
{
    abstract class VecShape : IConvertibleToSVG, IReturnPoints, IChangeableScale
    {
        public Color ShapeColor { get; set; }
        public Color OutlineColor { get; set; }
        public double OutlineSize { get; set; }
        public double TiltAngle { get; set; }
        public uint LevelOfVisibility { get; set; }
        public bool Visible { get; set; } = true;
        public string Name { get; set; }

        public abstract void ConvertShapeToSVG();
        public abstract List<Point> ReturnAllPoints();
        public abstract void ScaledResizing(double scale);
    }
}
