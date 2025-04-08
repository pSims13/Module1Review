namespace Module1Review;

class Program
{

    //Method to find the area of a circle
    public static double FindAreaOfCircle(double radius)
    {

        return Math.PI * Math.Pow(radius, 2); //Returns input from user on line 42

    }

    //Method to find the area of a triangle
    public static double FindAreaOfTriangle(double baseLength, double height)
    {

        return baseLength * height / 2; //Returns input from user on lines 46 , 48

    }

    //Method to find the area of a rectangle
    public static double FindTheAreaOfRectangle(double length, double width)
    {

        return length * width; //Returns input from user on lines 52 , 54

    }

    //Method to find the area of a square
    public static double FindTheAreaOfSquare(double side)
    {
        
        return side * side; //Returns input from user on line 58
        
    }
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the radius of your circle?");
        double radius = double.Parse(Console.ReadLine()); // Gave user ability to input radius of their circle & assign to method
        Console.WriteLine($"The area of your circle is {FindAreaOfCircle(radius)}."); //Called method to calculate users area of their circle
        
        Console.WriteLine("What is the height of your triangle?");
        double height = double.Parse(Console.ReadLine()); //Gave user ability to input height of their triangle assign to method
        Console.WriteLine("What is the length of the base of your triangle?");
        double baseLength = double.Parse(Console.ReadLine()); //Gave user ability to input the base lenght of their triangle & assign to method
        Console.WriteLine($"The area of your triangle is {FindAreaOfTriangle(baseLength, height)}."); //Called method to calculate users area of their triangle
        
        Console.WriteLine("What is the lenght of your rectangle?");
        double length = double.Parse(Console.ReadLine()); //Gave user ability to input length of rectangle & assign to method
        Console.WriteLine("What is the width of your rectangle?");
        double width = double.Parse(Console.ReadLine()); //Gave user ability to input width of rectangle & assign to method
        Console.WriteLine($"The area of your rectangle is {FindTheAreaOfRectangle(length, width)}"); //Called method to calculate users area of their rectangle
        
        Console.WriteLine("What is the measurement of one side of your square?");
        double side = double.Parse(Console.ReadLine()); //Gave user ability to input the side measurement of their square & assign to method
        Console.WriteLine($"The area of your square is {FindTheAreaOfSquare(side)}"); //Called method to calculate users area of their square
        
    }
}