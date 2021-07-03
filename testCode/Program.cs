using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCode
{
    class Program
    {
        static void Main()//entrypoint
        {
            //Ask user is they want to add new student info, if yes proceed if no safe exit

            //declare variable
            string mainOption;

            Console.WriteLine("Do you want to add a new student's info? [Y|N]\n");
            mainOption = Console.ReadLine().ToUpper();//fetch input from user & desenstivises letter case=

            switch(mainOption)//Sends user to desired destination
            {
                case "Y":
                    temp();
                    return;
                case "N":
                    Console.WriteLine("Press [ENTER] to exit...");
                    Console.ReadLine();
                    Environment.Exit(-1);//safe exit
                    return;
                default://Catches any invalid entries (anything other than Y or N)
                    Console.Clear();
                    Console.WriteLine("Please enter a valid option");
                    Main();
                    return;
            }
        }
        static void temp()//temporary in order to test Main()
        {
            Console.Clear();
            Console.WriteLine("Main works fine");
            Console.ReadLine();
        }
        static double averageScore()//Task 1 code will go here
        {
            return 0;//placeholder
        }
        static double progressScore()//Task 2 code will go here
        {
            return 0;//placeholder
        }
    }
}
