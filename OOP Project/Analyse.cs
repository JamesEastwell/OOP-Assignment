using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public static class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public static List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 6; i++)
            {
                values.Add(0);
            }
            string trimmed = Analyse.removeWhiteSpace(input);
            string characters = Analyse.removePunctuation(trimmed);
            values[0] = Analyse.sentences(trimmed, values[0]);
            values[1] = Analyse.vowels(characters, values[1]);
            values[2] = Analyse.consonants(characters, values[2]);
            values[3] = Analyse.upperCase(characters, values[3]);
            values[4] = Analyse.lowerCase(characters, values[4]);
            values[5] = Analyse.characterTotal(characters, values[5]);
            Analyse.frequency(characters);
            return values;
        }
        //Below are all the functions for doing the respective statistical analysis
        public static string removeWhiteSpace(string text)
        {
            string trimmed = String.Concat(text.Where(c => !Char.IsWhiteSpace(c)));
            return trimmed;

        }
        public static string removePunctuation(string text)
        {
            string characters = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            return characters;
        }
        public static int sentences(string text, int value)
        {
            foreach (char i in text)
            {
                string temp = i.ToString();
                if (temp == "." || temp == "!" || temp == "?") { value++; }
            }
            return value;
        }
        public static int vowels(string text, int value)
        {
            foreach (char i in text)
            {
                string temp = i.ToString();
                if (temp.ToLower() == "a" || temp.ToLower() == "e" || temp.ToLower() == "i" || temp.ToLower() == "o" || temp.ToLower() == "u") { value++; }
            }
            return value;
        }
        public static int consonants(string text, int value)
        {
            foreach (char i in text)
            {
                string temp = i.ToString();
                if (temp.ToLower() != "a" || temp.ToLower() != "e" || temp.ToLower() != "i" || temp.ToLower() != "o" || temp.ToLower() != "u") { value++; }
            }
            return value;
        }
        public static int upperCase(string text, int value)
        {
            foreach (char i in text)
            {
                string temp = i.ToString();
                if (temp == temp.ToUpper()) { value++; }
            }
            return value;
        }
        public static int lowerCase(string text, int value)
        {
            foreach (char i in text)
            {
                string temp = i.ToString();
                if (temp != temp.ToUpper()) { value++; }
            }
            return value;
        }
        public static int characterTotal(string text, int value)
        {
            value = text.Length;
            return value;
        }
        public static void frequency(string text)
        {
            Dictionary<char, int> charOccurences = new Dictionary<char, int>();
            foreach (char i in text.ToLower())
            {
                if (charOccurences.ContainsKey(i)) { charOccurences[i]++; }
                else { charOccurences.Add(i, 1); }
            }
            foreach (KeyValuePair<char, int> kvp in charOccurences) { Console.WriteLine(kvp); }
            return;
        }
    }
}
