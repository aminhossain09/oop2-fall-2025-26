using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== Mortgage Calculator (BANGLADESH) ====");

        Console.Write("Enter Loan Amount: ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annRate = Convert.ToDouble(Console.ReadLine()) / 100; 

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        int months = years * 12;
        double monthlyRate = annRate / 12;

       
        double monthlyPayment = (loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                                (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - loanAmount;

       
        CultureInfo bdCulture = new CultureInfo("en-BD");

        Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }
}
