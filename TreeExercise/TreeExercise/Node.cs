using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    // code for the individual nodes in the tree
    class Node
    {
        // class attributes
        private int data; // the data contained in the Node
        // important Nodes initialized to null because not all Nodes
        // will have values for them
        private Node parent = null; // the parent Node, if it exists
        private Node lChild = null; // the left child Node
        private Node rChild = null; // the right child Node
        private Node lNeighbor = null; // the left neighbor Node, if it exists
        private Node rNeighbor = null; // the right neighbor Node, if it exists

        // attribute properties
        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        public Node LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }
        public Node RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }
        public Node LNeighbor
        {
            get { return lNeighbor; }
            set { lNeighbor = value; }
        }
        public Node RNeighbor
        {
            get { return rNeighbor; }
            set { rNeighbor = value; }
        }

        public void MakeChildren()
        {
            // set the left Child
            lChild = new Node(this);
            // set the right Child
            rChild = new Node(this);
        }

        // default constructor
        public Node()
        {
            // set data to default value of one
            data = 1;
        }

        // parameterized constructor for child Nodes
        public Node(Node par)
        {
            // set the parent Node to the given value
            this.Parent = par;
            data = 1;
        }
        
    }
}
