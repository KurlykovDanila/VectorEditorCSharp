using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vector.src.Model
{
    class VecRectangle : VecShape
    {
        public Point TopLeftPoit { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public override void ConvertShapeToSVG()
        {
            throw new NotImplementedException();
        }

        public override List<Point> ReturnAllPoints()
        {
            throw new NotImplementedException();
        }

        public override void Rotate(int angle)
        {
            throw new NotImplementedException();
        }

        public override void ScaledResizing(double scale)
        {
            throw new NotImplementedException();
        }
    }
}
