﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vector.src.Model.Shapes
{
    class VecEllipse : VecShape
    {
        public Point TopLeftPoint { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
