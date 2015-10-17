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
            /*
            Note: the following is test code;
            it is not reflective of the final product in any way
            these are a series of hard coded tests to ensure 
            the Node class works properly before making a user interface
            
            Node root = new Node();
            Console.WriteLine("Root Node: " + root.Data);
            root.MakeChildren();
            Console.WriteLine("          " + root.LChild.Data + " " + root.RChild.Data);
            root.LChild.MakeChildren();
            root.RChild.MakeChildren();
            Console.WriteLine("        " + root.LChild.LChild.Data + " " + root.LChild.RChild.Data
                + " " + root.RChild.LChild.Data + " " + root.RChild.RChild.Data);
            root.LChild.LChild.MakeChildren();
            root.LChild.RChild.MakeChildren();
            root.RChild.LChild.MakeChildren();
            root.RChild.RChild.MakeChildren();
            Console.WriteLine();
            Console.WriteLine("    " + root.LChild.LChild.LChild.Data + " " + root.LChild.LChild.RChild.Data
                + " " + root.LChild.RChild.LChild.Data + " " + root.LChild.RChild.RChild.Data + " "
                + root.RChild.LChild.LChild.Data + " " + root.RChild.LChild.RChild.Data
                + " " + root.RChild.RChild.LChild.Data + " " + root.RChild.RChild.RChild.Data);
            root.LChild.LChild.LChild.MakeChildren();
            root.LChild.LChild.RChild.MakeChildren();
            root.LChild.RChild.LChild.MakeChildren();
            root.LChild.RChild.RChild.MakeChildren();
            root.RChild.LChild.LChild.MakeChildren();
            root.RChild.LChild.RChild.MakeChildren();
            root.RChild.RChild.LChild.MakeChildren();
            root.RChild.RChild.RChild.MakeChildren();
            Console.WriteLine("    " + root.LChild.LChild.LChild.LChild.Data + " " + root.LChild.LChild.LChild.RChild.Data
                + " " + root.LChild.LChild.RChild.LChild.Data + " " + root.LChild.LChild.RChild.RChild.Data + " "
                + root.LChild.RChild.LChild.LChild.Data + " " + root.LChild.RChild.LChild.RChild.Data
                + " " + root.LChild.RChild.RChild.LChild.Data + " " + root.LChild.RChild.RChild.RChild.Data + " "
                + root.RChild.LChild.LChild.LChild.Data + " " + root.RChild.LChild.LChild.RChild.Data + " "
                + root.RChild.LChild.RChild.LChild.Data + " " + root.RChild.LChild.RChild.RChild.Data + " "
                + root.RChild.RChild.LChild.LChild.Data + " " + root.RChild.RChild.LChild.RChild.Data + " "
                + root.RChild.RChild.RChild.LChild.Data + " " + root.RChild.RChild.RChild.RChild.Data);
            */
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
                for(int i = 1; i < treeDepth; i++)
                {
                    current.MakeChildren();
                    Console.Write(current.LChild.Data + " " + current.RChild.Data);
                    while (current.RNeighbor != null)
                    {
                        current = current.RNeighbor;
                        current.MakeChildren();
                        Console.Write(" " + current.LChild.Data + " " + current.RChild.Data);
                    }
                    while(current.LNeighbor != null)
                    {
                        current = current.LNeighbor;
                    }
                    current = current.LChild;
                    Console.WriteLine();
                }
            }
        }
    }
}
