using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExercise
{
    class Program
    {
        // main method, code is run through here
        static void Main(string[] args)
        {
            string userInput = "";
            int treeDepth = 0;
            // begin user input sequence
            Console.WriteLine("Please enter an integer value greater than 0 for the depth of the tree:");
            userInput = Console.ReadLine();
            bool parsed = false;
            // loop until user enters a value that is an integer
            while(parsed == false)
            {
                // check to make sure the value is an integer
                parsed = int.TryParse(userInput, out treeDepth);
                if(parsed == true && treeDepth != 0)
                {
                    Console.WriteLine("Value accepted. Creating tree...");
                }
                // if not, get the input again until it is
                else
                {
                    Console.WriteLine(userInput + " is not a valid value. Please enter an integer greater than 0.");
                    userInput = Console.ReadLine();
                }
            }
            // create the base Node of the tree
            Node root = new Node();
            Console.WriteLine(root.Data); // print the root's data
            Node current = null; // control Node for keeping track of position in the tree
            // if depth of tree is greater than 1
            if(treeDepth > 1)
            {
                // make the root the current Node
                current = root;
                // and loop for as many times as the user entered - 1
                for(int i = 1; i < treeDepth; i++)
                {
                    // make children of the current Node
                    current.MakeChildren();
                    // make sure that the children are aware of each other
                    current.LChild.RNeighbor = current.RChild;
                    current.RChild.LNeighbor = current.LChild;
                    // while the current Node has another Node to its right,
                    while (current.RNeighbor != null)
                    {
                        // make that Node the current Node
                        current = current.RNeighbor;
                        // make children for that Node
                        current.MakeChildren();
                        // and make the children aware of each other
                        current.LChild.RNeighbor = current.RChild;
                        current.RChild.LNeighbor = current.LChild;
                    }
                    // while the current Node has another Node to its Left,
                    while(current.LNeighbor != null)
                    {
                        // set the current Node to the left
                        current = current.LNeighbor;
                        // this is sort of equivalent to starting over from the left
                    }
                    // if there is a Node to the current Node's right
                    if(current.RNeighbor != null)
                    {
                        // tell the right child of this Node that the left child of the other node is its neighbor
                        current.RChild.RNeighbor = current.RNeighbor.LChild;
                        // and set the child's data
                        current.RChild.Data = current.Data + current.RNeighbor.Data;
                    }
                    // while there is a Node to the current Node's right
                    while (current.RNeighbor != null)
                    {
                        // set that Node to be the current Node
                        current = current.RNeighbor;
                        // if it also has a Node to its right
                        if (current.RNeighbor != null)
                        {
                            // tell the right child of this Node that the left child of the other node is its neighbor
                            current.RChild.RNeighbor = current.RNeighbor.LChild;
                            // and set the child's data
                            current.RChild.Data = current.Data + current.RNeighbor.Data;
                        }
                        // if it has a Node to its left
                        if (current.LNeighbor != null)
                        {
                            // tell the left child of this Node that the right child of the other node is its neighbor
                            current.LChild.LNeighbor = current.LNeighbor.RChild;
                            // and set the child's data
                            current.LChild.Data = current.Data + current.LNeighbor.Data;
                        }
                    }
                    // while the current Node has another Node to its Left,
                    while (current.LNeighbor != null)
                    {
                        // set the current Node to the left
                        current = current.LNeighbor;
                    }
                    // print out the current Node's data
                    Console.Write(current.LChild.Data + " " + current.RChild.Data + " ");
                    // and while there is a Node to the right of this Node,
                    while (current.RNeighbor != null)
                    {
                        // change to that Node and print out its data as well
                        current = current.RNeighbor;
                        Console.Write(current.LChild.Data + " " + current.RChild.Data + " ");
                    }
                    // while the current Node has another Node to its Left,
                    while (current.LNeighbor != null)
                    {
                        // set the current Node to the left
                        current = current.LNeighbor;
                    }
                    // last but not least, set the current Node to be the left child of the
                    // current Node, which should be the farthest left Node in the whole tree
                    current = current.LChild;
                    Console.WriteLine(); // line break
                }
            }
            Console.WriteLine("Tree complete. Press enter to close program.");
            string closed = Console.ReadLine();
        }
    }
}
