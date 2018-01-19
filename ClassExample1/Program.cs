using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1
{
    class Program
    {
        static void Main()
        {
            //DECLARATIONS
            //This program will allow the end-user to select course they would like to add to their schedule and output the cost of the course.
            string[ , ] classes = { 
                                    { "CWEB1010", "CWEB1111", "CWEB1000", "CWEB1011", "GRAPH1100" },
                                    { "CWEB2400", "SENG2000", "SENG2000", "SENG2100", "SENG2130" },
                                    { "GENGS3000", "GENS3100", "WRIT3000", "CWEB3100", "CWEB3000" },
                                    { "SENG5000", "SENG4100", "BCSA2000", "BCSA3000", "HIST4000" }
                                  };
            double[,] courseTuition = {
                                        { 1200.00, 1200.00, 1400.00, 1400.00, 1600.00 },
                                        { 1300.00, 1300.00, 1500.00, 1500.00, 1700.00 },
                                        { 1400.00, 1400.00, 1600.00, 1600.00, 1800.00 },
                                        { 1500.00, 1500.00, 1700.00, 1700.00, 1900.00 }

                                     };
            double[,] creditHour = {
                                    {2.0,3.0,1.0,2.0, 4.0 },
                                    {3.0,2.0,1.0,2.0, 4.0 },
                                    {4.0,1.0,1.0,2.0, 4.0 },
                                    {1.0,3.0,1.0,2.0, 5.0 }

                                    };
            string userInput;  //Declaring a variable
            int row, column, accurateRow, accurateColumn;
            bool keepAdding = true;
            List<String> courseList = new List<String>();

            //Output courses to console
            for(var x = 0; x < classes.GetLength(0); x++)
            {
                Console.Write($" Term {x+1}:   ");
                for(var w = 0; w < classes.GetLength(1); w++)
                {
                    Console.Write($" {x+1}{w+1}) {classes[x,w]}"); //Interpolation
                }
                Console.WriteLine(" \n");
            }//closing bracket for outer loop
            do
            {
                //Ask the user to select a course
                Console.WriteLine("Please enter a course number from the list above");
                userInput = Console.ReadLine();
                row = Int32.Parse(userInput.Substring(0, 1));
                column = Convert.ToInt32(userInput.Substring(1, 1));
                accurateRow = row - 1;
                accurateColumn = column - 1;

           
                Console.WriteLine($" You have selected {classes[accurateRow, accurateColumn]} that will cost {courseTuition[accurateRow, accurateColumn].ToString("c")}");
                courseList.Add(classes[accurateRow, accurateColumn]);
                Console.WriteLine("Would you like to add another course to your schedule");
                keepAdding = Convert.ToBoolean(Console.ReadLine());

            } while (keepAdding);
            /** Delete everything below this line **/
            //Iterate through list and output the course added to list
            foreach(string r in courseList)
            {
                Console.WriteLine($"{r}");
            }
            Console.WriteLine($"The current count is {courseList.Count()}"); 





        }
    }
}
