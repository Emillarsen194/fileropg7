using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileropg7
{
    class logic
    {
        public static void createFile()
        {
            string fileName = Console.ReadLine(); //gets the filename of the file we want to create
            string path = @".\opg7\" + fileName + ".txt"; //makes the path
            if (File.Exists(path)) //if file allready exist write it allready exist
            {
                Console.WriteLine("File allready exist");
            }

            else //else create the file
            {

                File.Create(path).Close(); // creates the file then closes it so we can delete it in the same session 
                Console.WriteLine("created file: " + fileName + ".txt");

            }
            Gui.Space(); //makes some space

        }









        public static void delFile() //method that deletes a file
        {
            string filename = Console.ReadLine();
            string path = @".\opg7\" + filename + ".txt";


            if (File.Exists(path)) // if file exist then delete the file
            {
                File.Delete(path);
                Console.WriteLine("deleted file named: " + filename + ".txt");
            }

            else if (!File.Exists(path)) //if file dosent exist say it dosent exist 
            {
                Console.WriteLine("No file named: " + filename);
            }
            Gui.Space();
        }








        public static void disFiles()   // display all files in opg7 dir 
        {

            string[] files = Directory.GetFiles(@".\opg7"); // array of all our files

            for (int i = 0; i < files.Length; i++) //printing our files
            {
                Console.WriteLine(files[i]);
            }

            Gui.Space();
        }



        public static void CreateDir() //creates a directory 
        {
            string directoryName = Console.ReadLine();
            string path = @".\opg7\" + directoryName;



            if (Directory.Exists(path)) //if it exist say dir allready exist 
            {
                Console.WriteLine("Directory " + directoryName + "Allready exist");
            }

            else // else create the directory 
            {
                Directory.CreateDirectory(path);
            }
            Gui.Space();
        }

        public static void SearchFiles() //search for files
        {
            string searchterms = Console.ReadLine();
            string path = @".\opg7\" + searchterms + ".txt";

            if (File.Exists(path)) // if the file we searched for exist say it exist 
            {
                Console.WriteLine("File named: " + searchterms + " Exist");
            }

            else //else say we coudlent find the file
            {
                Console.WriteLine("File Named: " + searchterms + " Dosent Exist");
            }

        }

















    }
}

