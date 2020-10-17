using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPIHost.Models
{
    public class SuggestionPaths
    {
        public string[] listOfLayers = {"Layer1","Layer2","Layer3" };
        public string[] layer1Members = { "BroadCategory1", "BroadCategory2", "BroadCategory3" };
        public int[] layer2Members = {1,2,3,4};
        public bool[] layer3Members = {true, false};

        public string NextLayer(string previousLayer)
        {
            //var LayerHierarchy = new Dictionary<string, string>()
            //    {{"Layer1", "Layer2"}, {"Layer2", "Layer3"}, {"Layer3", "lastLayer"}};
            //if(LayerHierarchy.ContainsKey(previousLayer))
            //{
            //    return LayerHierarchy[previousLayer];
            //}
            //else
            //{
            //    return "layer not found";
            //}
            return "nextLayer";
        }

        public string[] LayerMembers(string layer)
        {
            return new string[]{"LayerMember1", "LayerMember2", "LayerMember3"};
        }
    }
}
