using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vector.src.Model
{
    class RectangularArea : IRotatable
    {
        public Point RightTop;
        public Point LeftTop;
        public Point RightBottom;
        public Point LeftBottom;
        public Point CenterPoint;
        public int AngleOfRotation = 0;

        public void Rotate(int angle)
        {
            AngleOfRotation = (AngleOfRotation + angle) % 360;
            // Write how the points will change when turning
            throw new NotImplementedException();
        }
    }
}
