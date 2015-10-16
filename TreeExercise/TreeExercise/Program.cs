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
            Node root = new Node();
            Console.WriteLine("Root Node: " + root.Data);
            root.MakeChildren();
            Console.WriteLine(root.LChild.Data + "  " + root.RChild.Data);
            root.LChild.MakeChildren();
            root.RChild.MakeChildren();
            Console.WriteLine(root.LChild.LChild.Data + " " + root.LChild.RChild.Data
                + "  " + root.RChild.LChild.Data + "  " + root.RChild.RChild.Data);
        }
    }
}
