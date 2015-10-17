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
            */
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
        }
    }
}
