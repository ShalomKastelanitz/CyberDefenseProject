using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberDefenseProject
{
    internal class BinaryTree
    {
        public NodeDefense root;
        public BinaryTree()
        {
            root = null;
        }
        public void Insert(NodeDefense Defense)
        {
            if (root == null)
            {
                root = Defense;
                return;
            }
            else
            {

                Insert(root, Defense);

            }
        }
        private void Insert(NodeDefense node, NodeDefense Defense)
        {
            if ((Defense.MinSeverity+Defense.MaxSeverity) < (node.MinSeverity+node.MaxSeverity))
            {
                if (node.Left != null)
                {
                    Insert(node.Left, Defense);
                }
                else
                {
                    node.Left = Defense;
                    return;
                }

            }
            else
            {
                if (node.Right != null)
                {
                    Insert(node.Right, Defense);
                }
                else
                {
                    node.Right = Defense;
                    return;
                }
            }

        }
       
    }
}
