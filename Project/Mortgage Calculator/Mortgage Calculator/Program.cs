using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo bdCulture = new CultureInfo("en-BD");

        Console.WriteLine("==== Mortgage Calculator (BANGLADESH) ====");

        double salary = 0;
        int creditScore = 0;
        bool criminalRecord = false;

        // === Monthly Salary ===
        while (true)
        {
            Console.Write("Enter your monthly salary: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out salary))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a numeric value.");
            }
        }

        // === Credit Score ===
        while (true)
        {
            Console.Write("Enter your credit score (0-500): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(input, out creditScore))
            {
                if (creditScore >= 0 && creditScore <= 500)
                    break;
                else
                    Console.WriteLine("Credit score must be between 0 and 500.");
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a numerical value.");
            }
        }

        // === Criminal Record ===
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();
            if (input == "true")
            {
                Console.WriteLine("Sorry, you are not eligible for a loan due to a criminal record.");
                return;
            }
            else if (input == "false")
            {
                criminalRecord = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input, Please enter 'true' or 'false'.");
            }
        }

        // === Loan Amount ===
        double loanAmount = 0;
        while (true)
        {
            Console.Write("Enter Loan Amount: ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out loanAmount))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a numeric value.");
            }
        }

        // === Annual Interest Rate ===
        double annualRate = 0;
        while (true)
        {
            Console.Write("Enter annual interest rate (in %): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (double.TryParse(input, out annualRate))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a numeric value.");
            }
        }

        // === Loan Period ===
        int years = 0;
        while (true)
        {
            Console.Write("Enter loan period (in years): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();
            if (int.TryParse(input, out years))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter a numeric value.");
            }
        }

        // === Mortgage Calculations ===
        double monthlyRate = annualRate / 100 / 12;
        int months = years * 12;

        double monthlyPayment = (loanAmount * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                                (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - loanAmount;

        
        Console.WriteLine("\n==== Mortgage Calculator (Bangladesh) ====");
        Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Paid: {totalPaid.ToString("C", bdCulture)}");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("C", bdCulture)}");
    }
}
