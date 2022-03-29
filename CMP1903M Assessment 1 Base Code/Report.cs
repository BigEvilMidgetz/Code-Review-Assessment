using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {   
        public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //Handles the reporting of the analysis
        public void analysisOutput(List<int> values)
        {
            //This is data abstraction as it only shows the data to the user and not the working behind it.
            System.Console.WriteLine($"There are {values[0]} sentences ");
            System.Console.WriteLine($"There are {values[1]} vowels");
            System.Console.WriteLine($"There are {values[2]} consonants ");
            System.Console.WriteLine($"There are {values[3]} upper case letters");
            System.Console.WriteLine($"There are {values[4]} lower case letters");
            System.Console.WriteLine($"There are {values[3]+values[4]} characters");
        }

        public void letterOutput(List<int> freq)
        {
            for (int i = 0; i < freq.Count(); i++) 
            //Goes through the alphabet and their frequencies
            {
                System.Console.WriteLine($"There are {freq[i]} {alphabet[i]}'s ");
            }
        }

    }
}
