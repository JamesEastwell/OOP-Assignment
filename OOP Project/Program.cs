//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            List<int> parameters = new List<int>();
            string text = Input.optioninput();
            parameters = Analyse.analyseText(text);
            Report.outputConsole(parameters);
        }
    }
}
