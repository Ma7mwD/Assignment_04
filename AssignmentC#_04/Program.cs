using System.ComponentModel;
using System.Xml.Linq;

namespace AssignmentC__04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3),
            //and determines whether these points lie on a single straight line.

             Console.Write("x1 = ");
             int x1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("y1 = ");
             int y1 = int.Parse(Console.ReadLine());
             Console.Write("x2 = ");
             int x2 = int.Parse(Console.ReadLine());
             Console.Write("y2 = ");
             int y2 = Convert.ToInt32(Console.ReadLine());
             Console.Write("x3 = ");
             int x3 = int.Parse(Console.ReadLine());
             Console.Write("y3 = ");
             int y3 = Convert.ToInt32(Console.ReadLine());

             int Area = 1 / 2 * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
             string msg = Area == 0 ? "points lie on a single straight line." : "points not lie on a single straight line.";
             Console.WriteLine(msg);


             //2- Within a company, the efficiency of workers is evaluated based on the duration required
             //to complete a specific task. 
             Console.WriteLine("Enter the time taken by the worker to complete the task (in hours): ");
             double timeTaken;
             if (double.TryParse(Console.ReadLine(), out timeTaken))
             {

                 if (timeTaken >= 2 && timeTaken <= 3)
                     Console.WriteLine("The worker is highly efficient.");

                 else if (timeTaken > 3 && timeTaken <= 4)
                     Console.WriteLine("The worker needs to increase their speed.");

                 else if (timeTaken > 4 && timeTaken <= 5)
                     Console.WriteLine("The worker needs training to enhance their speed.");

                 else if (timeTaken > 5)
                     Console.WriteLine("The worker is required to leave the company.");

                 else
                     Console.WriteLine("Invalid input. Time taken cannot be less than 2 hours.");

             }
             else
                 Console.WriteLine("Invalid input. Please enter a valid number.");


             //3- . Write a program that prints an identity matrix using for loop,
             //in other words takes a value n from the user and shows the identity table of size n * n.

             int n = Convert.ToInt32(Console.ReadLine());
             if (n <= 0)
                 Console.WriteLine($"Invalid Matrix {n}");
             else
             {
                 Console.WriteLine($"Identity Matrix of size {n} x {n}:");
                 for (int i = 0; i < n; i++)
                 {
                     for (int j = 0; j < n; j++)
                     {
                         if (i == j)
                             Console.Write("1 ");
                         else
                             Console.Write("0 ");
                     }
                     Console.WriteLine();       
                 }
             }


             //20- Write a program in C# Sharp to find the sum of all elements of the array.
             int x, sum = 0;
             Console.Write("Enter the size of the array: ");
             x = int.Parse(Console.ReadLine());
             int[] elements = new int[x];
             for (int i = 0; i < elements.Length; i++)
             {
                 elements[i] = Convert.ToInt16(Console.ReadLine());
                 sum += elements[i];
             }
             Console.WriteLine(sum);

            //22 - Write a program in C# Sharp to count the frequency of each element of an array.

            int z;
            Console.Write("Enter the size of the array: ");
            z = int.Parse(Console.ReadLine());
            int[] arr = new int[z];
            bool[] visited = new bool[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }

            Console.WriteLine("Number of repetitions for each element:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        visited[j] = true;
                    }
                }

                Console.WriteLine($"Number {arr[i]} repeats {count} time(s).");
            }

            
        }
    }
}
