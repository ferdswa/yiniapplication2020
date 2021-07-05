using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCode
{
    class Program
    {
        public static void Main()//entrypoint
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
                    Console.WriteLine("Enter which type of operation you want to perform:\n1) Calculate average score\n2) Calculate progress score\n\nEnter the number of the task:");
                    int taskOption = Int32.Parse(Console.ReadLine());
                    switch (taskOption)
                    {
                        case 1:
                            Task1.getInfoTask1();
                            return;
                        case 2:
                            Task2.getInfoTask2();
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
    }
    class Task1
    {
        public static void getInfoTask1()//Get student information from user
        {
            //Clear console window - for aesthetic reasons only
            //declare variables
            string studentID = "", combinedScores = "";
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
            foreach(string x in scoreArray)//remove any spaces before converting to numbers
            {
                if (x.Contains(' '))
                {
                    x.Trim();
                }
            }
            try{//stops invalid user entry from crashing program
            matScore = double.Parse(scoreArray[0]);
            engScore = double.Parse(scoreArray[1]);
            sciScore = double.Parse(scoreArray[2]);
            avgScore = averageScore(matScore, engScore, sciScore);
            Console.Clear();
            //outputs the subject scores and average score
            Console.WriteLine("Student "+studentID+"'s scores are as following: \nMaths: "+matScore+"%\nEnglish: "+engScore+"%\nScience: "+sciScore+"%\nGiving them an average score of "+avgScore+"%");
            Console.WriteLine("Press [ENTER] to go back to the task selection menu");
            Console.ReadLine();
            Program.Main();
            }
            catch
            {
                Console.WriteLine("Only enter numbers as scores please");
                getInfoTask1();
            }
        }
        static double averageScore(double matScore, double engScore, double sciScore)//Task 1 code will go here
        {
            double sumOfScores = matScore+engScore+sciScore;
            double avgScore = (sumOfScores/3);
            return avgScore;
        }
    }
    class Task2
    {
        public static void getInfoTask2()
        {
            //variables
            string studentID = "";
            double[] matScores,engScores,sciScores = new double[1];
            Console.WriteLine("Enter the student's ID");
            studentID=Console.ReadLine();

            //get required info from user & try so that invalid entries don't cause crash
            try
            {
                Console.WriteLine("Enter the student's Maths scores, mock first and actual second, separated by a comma");
                string rawMaths = Console.ReadLine();
                matScores=GetScores(rawMaths);
                Console.WriteLine("Enter the student's English scores, mock first and actual second, separated by a comma");
                string rawEnglish = Console.ReadLine();
                engScores=GetScores(rawEnglish);
                Console.WriteLine("Enter the student's Science scores, mock first and actual second, separated by a comma");
                string rawScience = Console.ReadLine();
                sciScores=GetScores(rawScience);
            }
            catch
            {
                Console.WriteLine("Please enter a valid set of scores");
                getInfoTask2();
            }
        }
        static double[] GetScores(string rawValues)
        {
            //Split apart input into constituent scores and remove unnecessary spaces
            string[] splitScores = rawValues.Split(',');
            double[] scores = new double[splitScores.Length];
            int i = 0;
            foreach(string x in splitScores)
            {
                if(x.Contains(' '))
                {
                    x.Trim();
                }
                scores[i]=double.Parse(x);
                i++;
            }
            return scores;
        }
        static double calculateProgressScore()
        {
            return 0;
        }
        static double calculateAvgPScore()
        {
            return 0;
        }
    }
}
