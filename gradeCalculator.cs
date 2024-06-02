using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your numerical grade between 0 and 100:");
        if (double.TryParse(Console.ReadLine(), out double grade))
        {
            if (grade >= 90)
            {
                Console.WriteLine("Your letter grade is: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your letter grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your letter grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your letter grade is: D");
            }
            else
            {
                Console.WriteLine("Your letter grade is: F");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid numerical grade.");
        }
    }
}
