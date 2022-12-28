using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8_BinarySearchTree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        // COnstructor for the Node Class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }

    }
    /* A node class consist of three things, the information, references to the right child, and references*/

    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; /* Initializing ROOT to null */
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /* This function serachs the currentNode of the specified Node as well as the currentNode of its parents */
            currentNode = ROOT;
            parent = null;
            while ((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element,currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }

        class BinaryTree
        {

        }

        static void Main(string[] args)
        {
        }
    }
}
