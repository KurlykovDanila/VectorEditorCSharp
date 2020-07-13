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
        public Point LeftTop;
        public double Width;
        public double Height;
        public double AngleOfRotation = 0;

        public void Rotate(double angle)
        {
            AngleOfRotation = (AngleOfRotation + angle) % 360;
            // Write how the points will change when turning
            throw new NotImplementedException();
        }
    }
}
