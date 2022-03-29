using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    public static class Input
    {
        //Handles the text input for Assessment 1
        public static string optioninput()
        {
            string text = "";
            bool check = false;
            while (check == false)
            {
                Console.WriteLine("Please enter 'Manual' to analyse a manually inputted text or 'File' to analyse a file");
                string option = Console.ReadLine();
                if (option == "Manual")
                {
                    check = true;
                    //Call manualtextInput
                    text = Input.manualTextInput();
                }
                if (option == "File")
                {
                    //Call fileTextInput
                    Console.WriteLine("Please input the file directory and name of the file that you wish to analyse:");
                    string filePath = Console.ReadLine();
                    bool fileExists = File.Exists(filePath);
                    if (fileExists == true)
                    {
                        check = true;
                        Console.WriteLine("This file does exist");
                        text = Input.fileTextInput(filePath);
                    }
                    else
                    {
                        Console.WriteLine("This file does not exist");
                    }
                }
            }
            return text;
        }
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public static string manualTextInput()
        {
            Console.WriteLine("Please enter the text that you would like analysed: ");
            string text = Console.ReadLine();
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public static string fileTextInput(string filePath)
        {
            string text = System.IO.File.ReadAllText(filePath);
            return text;
        }

    }
}
