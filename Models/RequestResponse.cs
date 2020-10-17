using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPIHost.Models
{
    public class RequestResponse
    {
        public List<string[]> choiceList;
        public string layer;
        public string[] layerMembers;

        public RequestResponse()
        {
            this.choiceList= new List<string[]>{} ;
            this.layerMembers = new string[]{};
            this.layer = "";
        }

        public RequestResponse(List<string[]> choices, string[] layerMembers, string nextLayer)
        {
            this.choiceList = choices;
            this.layerMembers = layerMembers;
            this.layer = nextLayer;
        }
    }
}
