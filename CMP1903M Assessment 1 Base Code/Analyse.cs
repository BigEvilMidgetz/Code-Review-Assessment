using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Sets of characters needed later when analysing text
        //They are encapsulated within the class as they aren't needed elsewhere
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private string vowels = "aeiouAEIOU";
        private string consonants = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        private string punctuation = ".!?";

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            foreach (char c in input) //go through all the characters in the string
            {
                if (c == '*') break; // end of text detected be an *
                else if (punctuation.Contains(c)) values[0] ++; //using the earlier sets for analysis
                else if (vowels.Contains(c)) values[1] ++;
                else if (consonants.Contains(c)) values[2] ++;
                if (char.IsUpper(c)) values[3] ++;
                if (char.IsLower(c)) values[4] ++;
            }
            return values;
        }
        
        public List<string> LongWords(string input)
        //Additional method: LongWords
        //Argument: string
        //Returns: List of strings
        //Separates the words longer than 6 characters
        {
            string[] words = input.Split(' '); //separates the string into individual words
            List<string> longWords = new List<string> ();
            foreach(var word in words)
            //Takes off any punctuation attached to the words
            //As punctuation may add to the length of the words
            {
                var sb = new StringBuilder();
                foreach (char c in word)
                {
                    if (!char.IsPunctuation(c))
                        sb.Append(c);
                }
                string word2 = sb.ToString();
                if(word2.Length > 7) 
                //If the word is larger than 7 characters it gets added to a list
                {
                    longWords.Add(word2);
                }
            }
            return longWords;
        }

        //Additional method: letterFreq
        //Argument: string
        //Returns: List of integers
        //Counts the frequency of individual letters in the text
        public List<int> letterFreq(string input)
        {
            string lowerInput = input.ToLower();
            List<int> letterFreq = new List<int>();
            foreach (char c in alphabet)
            {
                int count = lowerInput.Count(x=> x== c);
                letterFreq.Add(count);
            }
            return letterFreq;
        }
    }
}
