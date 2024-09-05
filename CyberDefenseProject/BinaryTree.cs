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
        //פונקצית הוספה לעץ
        private void Insert(NodeDefense node, NodeDefense Defense)
        {
            //בודק את סכום 2 המשתנים בכדי לדעת אם לימין או לשמאל
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
        //public bool Find(int value)
        //{
        //    if (root == null)
        //    {

        //        return false;




        //    }
        //    return Find(root, value);

        //}
        //    public bool Find(NodeDefense node, int value)
        //    {
        //        if (node == null)
        //        {
        //            return false;
        //        }
        //        if (value == node.value)
        //        {
        //            return true;
        //        }
        //        if (value < node.value)
        //        {
        //            return Find(node.Left, value);

        //        }
        //        else
        //        {
        //            return Find(node.Right, value);
        //        }
        //    }
        //    public int Min()
        //    {
        //        if (root == null)
        //        {
        //            return 0;
        //        }
        //        TreeNode temp = root;

        //        while (temp.Left != null)
        //        {
        //            temp = temp.Left;
        //        }
        //        return temp.value;
        //    }
        //    public int Max()
        //    {
        //        if (root == null)
        //        {
        //            return 0;
        //        }
        //        TreeNode temp = root;

        //        while (temp.Right != null)
        //        {
        //            temp = temp.Right;
        //        }
        //        return temp.value;
        //    }
        public void PrintTree()
        {
            PrintTree(root, "", true);
        }

        private void PrintTree(NodeDefense node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("└── ");
                    indent += "    ";
                }
                else
                {
                    Console.Write("├── ");
                    indent += "│   ";
                }

                Console.WriteLine($"[{node.MinSeverity}-{node.MaxSeverity}] Defenses: {string.Join(", ", node.Defenses)}");

                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }

        

    }




    
}
