using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileropg7
{
    class Gui
    {
        public static void Space()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void GuiOne()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        H1 Queue Operations Menu     ");
            Console.WriteLine("=======================================");
            Console.WriteLine();

            Console.WriteLine("1. Add File");
            Console.WriteLine();
            Console.WriteLine("2. Delete File");
            Console.WriteLine();
            Console.WriteLine("3. Display Files");
            Console.WriteLine();
            Console.WriteLine("4. Add Folder");
            Console.WriteLine();
            Console.WriteLine("5. Search Files");
            Console.WriteLine();
            Console.WriteLine("6. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice:");
            Console.WriteLine();

        }

        public static void GuiTwo()
        {
            Console.Clear();
            Console.WriteLine("File to create:");

        }

        public static void GuiThree()
        {
            Console.Clear();
            Console.WriteLine("which file do u want to delete:");

        }

        public static void GuiFour()
        {
            Console.Clear();

        }

        public static void Guifive()
        {
            Console.Clear();
            Console.WriteLine("Name of the folder u want to create: ");

        }

        public static void Guisix()
        {
            Console.Clear();
            Console.WriteLine("enter the name for the file u want to search for: ");

        }





    }
}
