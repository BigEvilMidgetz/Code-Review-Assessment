//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            List<int> letterFreq = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            string text = "";
            var input = new Input();
            while (true) //Loop until chosen an input type
            {
                System.Console.WriteLine("If you want to enter text from a file type \'f\'");
                System.Console.WriteLine("If you want to type your text in type \'t\'");
                string type = Console.ReadLine();
                type = type.ToLower();
                if (type == "t") 
                {
                    text = input.manualTextInput();
                    break;
                }
                else if (type == "f")
                {
                    System.Console.WriteLine("Enter the file path here: ");
                    text = input.fileTextInput();
                    break;
                }
                System.Console.WriteLine("Invalid entry.");
            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            var analyse = new Analyse();

            //Receive a list of integers back
            parameters = analyse.analyseText(text);
            letterFreq = analyse.letterFreq(text);

            //Report the results of the analysis
            var report = new Report();
            File.WriteAllLines("LongWords.txt", analyse.LongWords(text));
            report.analysisOutput(parameters);
            report.letterOutput(letterFreq);
            //TO ADD: Get the frequency of individual letters?
            
        }
    }
}
