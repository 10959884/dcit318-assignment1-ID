
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        if (int.TryParse(Console.ReadLine(), out int age))
        {
            int standardPrice = 10;
            int discountedPrice = 7;

            if (age >= 65 || age <= 12)
            {
                Console.WriteLine("Ticket price: GHC " + discountedPrice);
            }
            else
            {
                Console.WriteLine("Ticket price: GHC " + standardPrice);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid age.");
        }
    }
}
