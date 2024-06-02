using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of side 1:");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of side 2:");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the length of side 3:");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 > 0 && side2 > 0 && side3 > 0)
        {
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Equilateral triangle: All three sides are equal.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Isosceles triangle: Two sides are equal.");
            }
            else
            {
                Console.WriteLine("Scalene triangle: No sides are equal.");
            }
        }
        else
        {
            Console.WriteLine("Please enter valid side lengths greater than 0.");
        }
    }
}
