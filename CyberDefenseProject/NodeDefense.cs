using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberDefenseProject
{
    internal class NodeDefense
    {
        public int MinSeverity { get; set; }

        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }
        public NodeDefense Left { get; set; }
        public NodeDefense Right { get; set; }




    }

}
