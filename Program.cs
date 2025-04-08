namespace Module1Review;

class Program
{

    public static double FindAreaOfCircle(double radius)
    {

        return Math.PI * Math.Pow(radius, 2);

    }

    public static double FindAreaOfTriangle(double baseLength, double height)
    {

        return baseLength * height / 2;

    }

    public static double FindTheAreaOfRectangle(double length, double width)
    {

        return length * width;

    }

    public static double FindTheAreaOfSquare(double side)
    {
        
        return side * side;
        
    }
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the radius of your circle?");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of your circle is {FindAreaOfCircle(radius)}.");
        
        Console.WriteLine("What is the height of your triangle?");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the length of the base of your triangle?");
        double baseLength = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of your triangle is {FindAreaOfTriangle(baseLength, height)}.");
        
        Console.WriteLine("What is the lenght of your rectangle?");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("What is the width of your rectangle?");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of your rectangle is {FindTheAreaOfRectangle(length, width)}");
        
        Console.WriteLine("What is the measurement of one side of your square?");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine($"The area of your square is {FindTheAreaOfSquare(side)}"); 
        
    }
}