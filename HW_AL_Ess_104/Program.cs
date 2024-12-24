using HW_AL_Ess_104.Parts;

namespace HW_AL_Ess_104

{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Point pointA = new Point(10, 10, "A");
            Point pointB = new Point(5, 7, "B");
            Point pointC = new Point(2, 3, "C");
            Point pointD = new Point(1, 1, "D");

            Figure triangle = new Figure(pointA, pointB, pointC);

            //double lengthSide = triangle.LengthSide(pointA, pointB);                     
            triangle.PerimeterCalculator();
            triangle.PrintName();

            Figure fiveLine = new Figure(pointA, pointB, pointC, pointD);
            fiveLine.PerimeterCalculator();
            fiveLine.PrintName();
            
        }
    }
}
