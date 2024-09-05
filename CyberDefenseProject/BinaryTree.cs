using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CyberDefenseProject
{
    internal class BinaryTree
    {
        public NodeDefense root;
        /// <summary>
        /// Initializes a new instance of the BinaryTree class with a null root.
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }
        /// <summary>
        /// Inserts a new NodeDefense object into the binary tree.
        /// </summary>
        /// <param name="Defense">The NodeDefense object to be inserted.</param>
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
            //בודק את המינמום בכדי לדעת אם לימין או לשמאל
            if (Defense.MinSeverity < node.MinSeverity)
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
        /// <summary>
        /// Finds a suitable defense based on a given severity value.
        /// </summary>
        /// <param name="value">The severity value to search for.</param>
        /// <returns>The NodeDefense object if found, otherwise null.</returns>
        //מציאת הגנה מתאימה
        public NodeDefense FindProtection(int value)
        {
            if (root == null)
            {
                return null;
            }
            return FindProtection(root, value);
        }
        //מוצא הגנה מתאימה
        private NodeDefense FindProtection(NodeDefense node, int value)
        {
            //בודק אם הגיע לסוף אז כנראה אין הגנה מתאימה
            if (node == null)
            {
                return null;
            }
            if (value == node.MinSeverity||value==node.MaxSeverity)
            {
                return node;
            }
            if (value < node.MinSeverity)
            {
                return FindProtection(node.Left, value);

            }
            else
            {
                return FindProtection(node.Right, value);
            }
        }
        /// <summary>
        /// Prints the binary tree.
        /// </summary>
        //מדפיס את העץ
        public void PrintTree()
        {
            if (root != null)
            {
                PrintTree(root, "", true);
            }
        }
        //מדפיס את העץ

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
