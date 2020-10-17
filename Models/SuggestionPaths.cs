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

        public Dictionary <string ,List<string>> LayerHierarchy = new Dictionary<string, List<string>>()
            {
                { "BroadCategory1",new List<string>{ "1","2"} },
                { "BroadCategory2",new List<string>{ "1","3"} },
                { "BroadCategory3",new List<string>{ "4","2"} },
                { "1",new List<string>{"Battery"} },
                { "2",new List<string>{"weight"} },
                { "3",new List<string>{"weight"} },
                { "4",new List<string>{"Battery"} },
               



            };
       
        public bool checkvalid(string response1,string response2)
        {
            var list1 =LayerHierarchy[response1];
            if(list1.Contains(response2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public List<string> NextLayer(string previousLayer)
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
           
            if(LayerHierarchy.ContainsKey(previousLayer))
            {
                
                var list = LayerHierarchy[previousLayer];
                return list;
            }
            else
            {
                return null;   
            }
            //return "nextLayer";
        }

      
        public string[] LayerMembers(string layer)
        {
            return new string[]{"LayerMember1", "LayerMember2", "LayerMember3"};
        }
    }
}
