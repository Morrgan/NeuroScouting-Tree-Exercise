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
            lChild.RNeighbor = rChild;
            // if this is the root Node or this Node has no left Neighbor,
            if (this.Parent == null || this.LNeighbor == null)
            {
                // set the left Child's data to this Node's data
                lChild.Data = this.Data;
            }
            else
            {
                // otherwise set the left Child's data to
                // this Node's + the left Neighbor's data
                lChild.Data = this.Data + this.LNeighbor.Data;
            }
            // if this is the root Node or this Node has no right Neighbor,
            if (this.Parent == null || this.RNeighbor == null)
            {
                // set the right Child's data to this Node's data
                rChild.Data = this.Data;
            }
            else
            {
                // otherwise set the right Child's data to
                // this Node's + the right Neighbor's data
                rChild.Data = this.Data + this.RNeighbor.Data;
            }
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
            
            // if the parent Node has a left Neighbor,
            if(par.LNeighbor != null)
            {
                // make the left Neighbor's right Child this
                // Node's left Neighbor
                this.LNeighbor = par.LNeighbor.RChild;
                if (par.LNeighbor.RChild != null)
                {
                    par.LNeighbor.RChild.RNeighbor = this;
                    par.LNeighbor.RChild.Data = this.Parent.Data + par.LNeighbor.Data;
                }
            }
            // otherwise, if the parent Node has a left Child
            if(par.LChild != null)
            {
                // make that child this Node's left Neighbor
                this.LNeighbor = par.LChild;
            }
            // otherwise, leave the left Neighbor null; this is an
            // edge Node
            // if the parent Node has a right Neighbor,
            if (par.RNeighbor != null)
            {
                // make the right Neighbor's left Child this
                // Node's right Neighbor
                this.RNeighbor = par.RNeighbor.LChild;
                if (par.RNeighbor.LChild != null)
                {
                    par.RNeighbor.LChild.LNeighbor = this;
                }
            }
            // otherwise, if the parent Node has a right Child
            if (par.RChild != null)
            {
                // make that child this Node's right Neighbor
                this.RNeighbor = par.RChild;
            }
            // otherwise, leave the right Neighbor null; this is an
            // edge Node
        }
    }
}
