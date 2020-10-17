using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPIHost.Models
{
    public class Products
    {
        public string ID { get; set; }
        public string BroadCategory { get; set; }
        public int Performance { get; set; }
        public bool Specification { get; set; }

        public Products(string name, string category, int performance, bool specs)
        {
            this.ID = name;
            this.BroadCategory = category;
            this.Performance = performance;
            this.Specification = specs;
        }

        public Products()
        {
            this.ID = default(string);
            this.BroadCategory = default(string);
            this.Performance = default(int);
            this.Specification = false;
        }
    }
}
