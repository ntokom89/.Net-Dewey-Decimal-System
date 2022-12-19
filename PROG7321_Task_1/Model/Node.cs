using PROG7321_Task_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_2.Model
{
    internal class Node
    {
        public Node leftNode { get; set; }
        public Node rightNode { get; set; }

        public CallNumber Data { get; set; }

        //Child int variable
        // //https://iq.opengenus.org/select-random-node-from-binary-tree/
        public int child { get; set; }
    }
}
