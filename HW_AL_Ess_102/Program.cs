namespace HW_AL_Ess_102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;

            Console.WriteLine("Hello User!");
            Console.Write("Enter side 1: ");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            side2 = Convert.ToDouble(Console.ReadLine());


            Rectangle rectangle01 = new Rectangle(side1, side2);

            Console.WriteLine($"Rectangle Area is: {rectangle01.Area} \nRectangle Perimeter: {rectangle01.Perimeter}");

        }
    }
}
