using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.src.Model
{
    class Layer
    {
        public Layer(uint levelOfVisibility)
        {
            LevelOfVisibility = levelOfVisibility;
        }

        public List<VecShape> VecShapes { get; set; } = new List<VecShape>();
        public uint LevelOfVisibility { get; set; }
        public bool visible { get; set; } = true;
        public string name { get; set; }
    }
}
