using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public static class UI
    {
        public static bool UserAnswersYes(string question)
        {
            // TODO: Improve this method and make it cleaner

            Console.WriteLine(question);

            string response = Console.ReadLine().ToLower();

            if(response == "y" || response == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
