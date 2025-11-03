
Console.WriteLine("enter score of 1st student");

double score1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter score of 2nd student");

double score2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter score of 3rd student");

double score3 = Convert.ToInt32(Console.ReadLine());


double average = (score1 + score2 + score3) / 3.0;

Console.WriteLine($"the Average score of the all strudent {average}");