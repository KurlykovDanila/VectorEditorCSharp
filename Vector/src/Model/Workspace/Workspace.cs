using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.src.Model
{
    class Workspace
    {
        public string name { get; set; }
        private List<Layer> Layers = new List<Layer>();

        public Workspace(string name)
        {
            this.name = name;
        }

        public Layer CreateNewLayer(uint LevelOfVisibility)
        {
            Layers.Add(new Layer(LevelOfVisibility));
            return Layers.Last();
        }
    }
}
