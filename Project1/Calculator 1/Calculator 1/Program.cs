int count = 0;
string opinion;

do
{
    Console.WriteLine("     -Calculator-     ");

    Console.WriteLine("Enter 1st number ");
    double number1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter 2nd number ");
    double number2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Which method do you want?");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Substraction");
    Console.WriteLine("2. Multiplication");
    Console.WriteLine("4. Division");


    string choice = Console.ReadLine();


    switch (choice)
    {
        case "1":
            double add = number1 + number2;
            Console.WriteLine($"Addition is = {add}");
            break;

        case "2":
            double subs = number1 - number2;
            Console.WriteLine($"Substraction is = {subs}");
            break;

        case "3":
            double mult = number2 * number1;
            Console.WriteLine($"Multiplication is = {mult}");
            break;

        case "4":

            if (number2 != 0)
              Console.WriteLine("Division is = " + (number1/number2));

            else
              Console.WriteLine($"Cant division");
              break;

        default:
              Console.WriteLine("Cant operate");
              break;
              
    }

    count++;
    Console.WriteLine("Do You want to continue? (Yes/No) ");
    opinion = Console.ReadLine();

}


while (opinion.ToLower() == "yes");

    Console.WriteLine("End of your program.Total " + count + " calculations" );

