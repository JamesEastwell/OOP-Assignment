using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public static void outputConsole(List <int>parameters)
        {
            Console.Write("The total number of sentences are: " + parameters[0] + " \nThe total number of vowels are: " + parameters[1] + "\nThe total number of consonants are: " + parameters[2] + "\nThe total number of upper case letters is: " + parameters[3] + "\nThe total number of lower case letters is: " + parameters[4] + "\nThe total number of characters in the text are: " + parameters[5]);
        }
    }
}
