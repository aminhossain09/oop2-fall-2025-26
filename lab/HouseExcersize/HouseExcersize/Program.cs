using System;

class House
{
    public int BuildYear { get; set; }
    public double Size { get; set; }

    public House(int buildYear, double size)
    {
        BuildYear = buildYear;
        Size = size;
    }

    public int HowOld()
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - BuildYear;
        return age;
    }

    public void CanBeSold()
    {
        int age = HowOld();
        if (age >= 15)
        {
            Console.WriteLine(" The house is old enough to be sold.");
        }
        else
        {
            Console.WriteLine(" The house cannot be sold .");

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== House Information ===");

        Console.Write("Enter the build year of the house: ");
        int buildYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the size of the house :");
        double size = Convert.ToDouble(Console.ReadLine());

        House myHouse = new House(buildYear, size);

        Console.WriteLine($"\n The house is about  {myHouse.HowOld()} years old.");
        myHouse.CanBeSold();
    }
}
