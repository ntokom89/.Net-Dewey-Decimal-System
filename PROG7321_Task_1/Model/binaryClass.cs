using PROG7321_Task_1.Model;
using PROG7321_Task_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace trees
{
    internal class binaryClass
    {

        public Node root { get; set; }
        Node b4 = null;
        Node after;
        public List<Node> list = new List<Node>();
        //Method to add the CallNumber to binary tree
        // //https://iq.opengenus.org/select-random-node-from-binary-tree/
        public bool Add(CallNumber value)
        {
             after = this.root;
            while (after != null)
            {
                b4 = after;
                if(value.CallNumInt < after.Data.CallNumInt)
                {
                    after = after.leftNode;
                }else if(value.CallNumInt > after.Data.CallNumInt)
                {
                    after = after.rightNode;
                }
                else
                {
                    return false;

                }
            }

            Node newN = new Node();
            newN.Data = value;
            if(this.root == null)
            {
                this.root = newN;
            }
            else
            {
                if(value.CallNumInt < b4.Data.CallNumInt)
                {
                    b4.leftNode = newN;
                }
                else
                {
                    b4.rightNode = newN;
                }
            }
            return true;
        }

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                //list.Items.Add(parent.Data.CallNum + " " + parent.Data.CallNumDescription);
                if(parent.Data.CallNum.Contains("00 "))
                {
                    list.Add(parent);  
                }
                TraversePreOrder(parent.leftNode);
                TraversePreOrder(parent.rightNode);
            }
        }

        // //https://iq.opengenus.org/select-random-node-from-binary-tree/
        public static int getChild(Node root)
        {
            if (root == null)
                return 0;
            return getChild(root.leftNode) +
                    getChild(root.rightNode) + 1;
        }

        // the following function just counts the number of children for a given root
        // //https://iq.opengenus.org/select-random-node-from-binary-tree/
        public static Node ChildCount(Node root)
        {
            if (root == null)
                return null;

            root.child = getChild(root) - 1;
            root.leftNode = ChildCount(root.leftNode);
            root.rightNode = ChildCount(root.rightNode);
            return root;
        }
        // //https://iq.opengenus.org/select-random-node-from-binary-tree/
        static int children(Node root)
        {
            if (root == null)
                return 0;
            return root.child + 1;
        }

        //The following function is basically used to return the required random node of the binary tree
        //returns random node for third level node
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        static Node randomNodeUtilThirdLevel(Node root, int count)
        {
            if (root == null)
                return null;

            if (count == children(root.leftNode))
                if (root.Data.CallNum.Contains('	'))
                {
                    return root;
                }

            if (count < children(root.leftNode))
                return randomNodeUtilThirdLevel(root.leftNode, count);

            return randomNodeUtilThirdLevel(root.rightNode,
                    count - children(root.leftNode) - 1);
        }
        //returns random node for level one or Top level node
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        static Node randomNodeUtilTopLevel(Node root, int count)
        {
            if (root == null)
                return null;

            if (count == children(root.leftNode))
                if (root.Data.CallNum.Contains("00 "))
                {
                    return root;
                }

            if (count < children(root.leftNode))
                return randomNodeUtilTopLevel(root.leftNode, count);

            return randomNodeUtilTopLevel(root.rightNode,
                    count - children(root.leftNode) - 1);
        }
        //returns random node for level two node
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        static Node randomNodeUtilTSecondLevel(Node root, int count)
        {
            if (root == null)
                return null;

            if (count == children(root.leftNode))
                if (root.Data.CallNum.Contains("  "))
                {
                    return root;
                }

            if (count < children(root.leftNode))
                return randomNodeUtilTSecondLevel(root.leftNode, count);

            return randomNodeUtilTSecondLevel(root.rightNode,
                    count - children(root.leftNode) - 1);
        }

        // Returns Random node
        //https://iq.opengenus.org/select-random-node-from-binary-tree/
        public static Node randomNode(Node root, string level)
        {
            Random r = new Random();
            int index = (int)(r.NextDouble() * (root.child + 1));
            if (level.Equals("Third Level"))
            {
                return randomNodeUtilThirdLevel(root, index);
            }
            else if(level.Equals("Top Level"))
            {
                return randomNodeUtilTopLevel(root, index);
            }
            else if (level.Equals("Second Level"))
            {
                return randomNodeUtilTSecondLevel(root, index);
            }
            else
            {
                return null;
            }
        }


        public virtual CallNumber minvalue(Node node)
        {
           
            /* loop down to find the leftmost leaf */
            while (node.leftNode != null)
            {
                node = node.leftNode;
            }
            return (node.Data);
        }

        private Node FindMax(Node node)
        {
            while (node.leftNode != null)
            {
                node = node.leftNode;
            }
            return node;
        }

        int maxDepth(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = maxDepth(node.leftNode);
                int rDepth = maxDepth(node.rightNode);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }
        }

        //Method to find the node based on Call Number value
        //https://www.geeksforgeeks.org/binary-search-tree-set-1-search-and-insertion/
        public Node Find(int value)
        {
            return this.Find(value, this.root);
        }
        //Method to find the node based on Call Number value
        //https://www.geeksforgeeks.org/binary-search-tree-set-1-search-and-insertion/
        private Node Find(int value, Node parent)
        {
            if (parent != null)
            {
                if (value == parent.Data.CallNumInt) 
                    return parent;
                if (value < parent.Data.CallNumInt)
                    return Find(value, parent.leftNode);
                else
                    return Find(value, parent.rightNode);
            }

            return null;
        }


        public Node RemoveHelper(Node root, int key)
        {


            if (root == null)
                return root;
            //if key is less than the root node,recurse left subtree
            if (key < root.Data.CallNumInt)
                root.leftNode = RemoveHelper(root.leftNode, key);
            // if key is more than the root node,recurse right subtree
            else if (key > root.Data.CallNumInt)
            {
                root.rightNode = RemoveHelper(root.rightNode, key);
            }

            //else we found the key
            else
            {
                //case 1: Node to be deleted has no children
                if (root.leftNode == null && root.rightNode == null)
                {
                    //update root to null
                    root = null;
                }
                //case 2 : node to be deleted has two children
                else if (root.leftNode != null && root.rightNode != null)
                {
                    var maxNode = FindMax(root.rightNode);
                    //copy the value
                    root.Data = maxNode.Data;
                    root.rightNode = RemoveHelper(root.rightNode, maxNode.Data.CallNumInt);
                }
                //node to be deleted has one children
                else
                {
                    var child = root.leftNode != null ? root.leftNode : root.rightNode;
                    root = child;
                }

            }


            return root;

        }

    }
}
