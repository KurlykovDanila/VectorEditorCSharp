using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.src.Model
{
    class Workspace
    {
        public double Scale { get; set; } = 1;
        public string Name { get; set; }
        private List<Layer> Layers = new List<Layer>();
        private Layer FocusLayer = null;

        public Workspace(string name)
        {
            this.Name = name;
        }

        public void CreateNewLayer()
        {
            if (FocusLayer == null)
            {
                Layers.Add(new Layer(Layer.minLevelOfVisibility));
            }
            else
            {
                Layers.FindAll(i => i.LevelOfVisibility > FocusLayer.LevelOfVisibility)?.ForEach(i => i.LevelOfVisibility++);
                Layers.Add(new Layer(FocusLayer.LevelOfVisibility + 1));
            }
            FocusLayer = Layers.Last();
            Layer.maxLevelOfVisibility = (uint)Layers.Count - 1;
        }

        public void ChangeFocusLayer(string name)
        {
            if (FocusLayer.Name == name)
            {
                return;
            }
            FocusLayer = Layers.Find(i => i.Name == name) ?? FocusLayer;
        }

        public void ChangeLayerLevel(string name, uint newLevel)
        {
            var VariableLayer = Layers.Find(i => i.Name == name);
            if (VariableLayer == null)
            {
                return;
            }
            Layers.FindAll(i => i.LevelOfVisibility >= newLevel)?.ForEach(i => i.LevelOfVisibility++);
            VariableLayer.LevelOfVisibility = newLevel;
        }

        public void DeleteLayer(string name)
        {
            var RemovableLayer = Layers.Find(i => i.Name == name);
            Layers.FindAll(i => i.LevelOfVisibility > RemovableLayer.LevelOfVisibility)?.ForEach(i => i.LevelOfVisibility--);
            Layers.Remove(RemovableLayer);
        }


    }
}
