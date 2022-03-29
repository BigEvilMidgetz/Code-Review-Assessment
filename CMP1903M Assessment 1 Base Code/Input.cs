using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {   
            System.Console.WriteLine("Enter the text to be analysed, then end the text with an \'*\'");
            while(true)
            {
                text += Console.ReadLine();
                if (text.Contains("*")) break;
                else text += " ";
            }
            return text;

        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput()
        {
            bool check = true;
            while (check is true)
            {
                try
                {
                    string fileName = Console.ReadLine();
                    text = File.ReadAllText(fileName);
                    //return text;
                    check = false;
                }
                catch (FileNotFoundException) //Catches if the file doesn't exist
                {
                    System.Console.WriteLine("File Doesn't exist. Try again: ");
                }
            }
            return text;
        }

    }
}
