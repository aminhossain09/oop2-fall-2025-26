using System;
public class House;
{
public int Year { get; set; }
public double Size { get; set; }

public  House (int Year, double Size)
{
         Year = year;
         Size = size;
}
private int HowOld()
{
      int thisYear = Date.Time.Now.Year;
}

public bool CanBeSold()
{
    return HowOld() > 15;
}
     

public void ShowInfo()
{
    Console.WriteLine(" House Details");
    Console.WriteLine("Built Year = {Year}");
    Console.WriteLine("House Size = {Year}");
}




class Program
{
    static void Main(string[] args)
    {
        House House1 = new House(2000,1500.0);
        House House2 = new House(2011, 1000.0);
        House1.ShowInfo();
        House2.ShowInfo();
    }
}