internal class Program
{
    private static void Main(string[] args)
    {

        double radius;
        double thickness = 0.3;

        Console.Write("Yarıçapını giriniz: ");
        radius =double.Parse(Console.ReadLine());
        


        Console.WriteLine();
        double rIn = radius - thickness, rOut = radius + thickness;

        for (double y = radius; y >=-radius; --y)
        {
            for (double x = -radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        
    }
}

