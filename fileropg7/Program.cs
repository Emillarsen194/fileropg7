using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileropg7
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists(@".\opg7")) //creates the directory we work in
            {
                Directory.CreateDirectory(@".\opg7");
            }

            else
            {
                Console.WriteLine("dir exist allready");
            }

            while (true) // keeps our code running
            {
                Gui.GuiOne();

                byte choice = byte.Parse(Console.ReadLine());

                // if choice == what menu we want could have maken a switch case but allready made if and im lazy :P

                if (choice == 1)
                {

                    Gui.GuiTwo();
                    logic.createFile();
                }


                else if (choice == 2)
                {
                    Gui.GuiThree();
                    logic.delFile();
                }

                else if (choice == 3)
                {
                    Gui.GuiFour();
                    logic.disFiles();
                }

                else if (choice == 4)
                {
                    Gui.Guifive();
                    logic.CreateDir();
                }

                else if (choice == 5)
                {
                    Gui.Guisix();
                    logic.SearchFiles();
                }

                else if (choice == 6)
                {
                    Environment.Exit(0);
                }



            }




        }
    }
}
