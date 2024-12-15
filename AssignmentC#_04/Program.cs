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
        }
    }
}
