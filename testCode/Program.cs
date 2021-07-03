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
                    Console.Clear();
                    Console.WriteLine("Enter which type of operation you want to perform:\nTask1\nTask2\n\nEnter the number of the task:");
                    int taskOption = Int32.Parse(Console.ReadLine());
                    switch (taskOption)
                    {
                        case 1:
                            Task1.getInfoTask1();
                            return;
                        case 2:
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please enter a valid option");
                            Main();
                            return;
                    }
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
        static double progressScore()//Task 2 code will go here
        {
            return 0;//placeholder
        }
    }
    class Task1
    {
        public static void getInfoTask1()//Get student information from user
        {
            //Clear console window - for aesthetic reasons only
            //declare variables
            string studentID = "", combinedScores = "", currentScore = "";
            double matScore = 0, engScore = 0 , sciScore = 0, avgScore = 0;
            Console.WriteLine("Enter student's ID: ");
            studentID = Console.ReadLine();
            Console.WriteLine("Enter the student with ID " + studentID + "'s Maths, English and Science scores in that order, separated by commas.\n\n");
            combinedScores = Console.ReadLine();

            //split the combined scores apart
            string[] scoreArray = combinedScores.Split(',');

            if(scoreArray.Count() != 3)//Not entering enough scores caused several errors while testing this function so this check has been put in place
            {
                Console.WriteLine("Make sure to enter 3 scores");
                getInfoTask1();
            }

            int i = 0;
            foreach(string x in scoreArray)//remove any spaces before converting to numbers
            {
                if (x.Contains(' '))
                {
                    currentScore = x;
                    foreach (char h in currentScore)
                    {
                        if (h == ' ')
                            currentScore.Remove(h);
                    }
                    scoreArray[i] = currentScore;
                }
                i++;
            }

            matScore = Int32.Parse(scoreArray[0]);
            engScore = Int32.Parse(scoreArray[1]);
            sciScore = Int32.Parse(scoreArray[2]);
            avgScore = averageScore(matScore, engScore, sciScore);
        }
        static double averageScore(double matScore, double engScore, double sciScore)//Task 1 code will go here
        {
            return 0;//placeholder
        }
    }
    class Task2
    {
        static void temp()//Empty void present before I code task2
        {

        }
    }
}
