using System;

class Practice1
{
    static void Main()
    {
        /* //Practice 1
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

       if (number % 2 == 0)
       {
            Console.WriteLine("The " + number + " is even");
        }
        else
        {
            Console.WriteLine("The " + number + " is odd\n");
        }

         //Practice 2
        int number ;
        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is negative.");
        }

          //Practice 3
        int age ;
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        int monthlyIncome;
        Console.Write("Enter your monthly income: ");
        monthlyIncome = int.Parse(Console.ReadLine());

        if ((age >= 25 && age <= 35) && (monthlyIncome >= 50000 && monthlyIncome <= 70000))
        {
            Console.WriteLine("Young Professional.");
        }
        else if ((age >= 35 && age <= 55) && monthlyIncome >= 70000)
        {
            Console.WriteLine("Middle-Aged Professional.");
        }
        else if (age >= 56 && monthlyIncome <= 30000)
        {
            Console.WriteLine("Senior Citizen.");
        }
        else
        {
            Console.WriteLine("No category matched.");
        }

          //practice 4

        Console.Write("Enter your exam score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        string result = score >= 50 ? "PASSED" : "FAILED";

        Console.WriteLine("Result: " + result);

        */ //practice 5

        Console.WriteLine("Circle Calculator");
        Console.WriteLine("A - Area");
        Console.WriteLine("P - Perimeter");
        Console.WriteLine("X - Exit");

        Console.Write("Enter your choice: ");
        char choice = Convert.ToChar(Console.ReadLine().ToUpper());

        if (choice == 'X')
        {
            Console.WriteLine("Application exited.");
        }
        else if (choice == 'A' || choice == 'P')
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            if (choice == 'A')
            {
                double area = Math.PI * radius * radius;
                Console.WriteLine("The area of the circle is: " + area);
            }
            else if (choice == 'P')
            {
                double perimeter = 2 * Math.PI * radius;
                Console.WriteLine("The perimeter of the circle is: " + perimeter);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

    
    }
}