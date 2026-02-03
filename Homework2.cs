namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1.
        Console.WriteLine("Please input a letter grade:");
        string input1 = Console.ReadLine();

        switch (input1)
        {
            case "A":
                Console.WriteLine("GPA point: 4");
                break;

            case "B":
                Console.WriteLine("GPA point: 3");
                break;

            case "C":
                Console.WriteLine("GPA point: 2");
                break;

            case "D":
                Console.WriteLine("GPA point: 1");
                break;

            case "F":
                Console.WriteLine("GPA point: 0");
                break;
            
            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        // Blank line to separate Q1 and Q2.
        Console.WriteLine(" ");

        // Code for Q2.
        Console.WriteLine("Please input the first num:");
        int input2 = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Please input the second num:");
        int input3 = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Please input the third num:");
        int input4 = Convert.ToInt16(Console.ReadLine());

        if ((input2 <= input3) && (input2 <= input4))
        {
            Console.WriteLine("The smallest value is: " + input2);
        }
        else if ((input3 <= input2) && (input3 <= input4))
        {
            Console.WriteLine("The smallest value is: " + input3);
        }
        else if ((input4 <= input2) && (input4 <= input3))
        {
            Console.WriteLine("The smallest value is: " + input4);
        }

        // Blank line to separate Q2 and Bonus.
        Console.WriteLine(" ");

        // Code for Bonus.
        Console.WriteLine("Please input a year:");
        int input5 = Convert.ToInt16(Console.ReadLine());

        if ((input5%4) == 0)
        {
            // Check if century.
            if ((input5%100) == 0)
            {
                // Check if century is divisible by 400.
                if ((input5%400) == 0)
                {
                    Console.WriteLine(input5 + " is a Leap year.");
                }
                else
                {
                    Console.WriteLine(input5 + " is not a Leap year.");
                }
            }
            else
            {
                Console.WriteLine(input5 + " is a Leap year.");
            }
        }
        else
        {
            Console.WriteLine(input5 + " is not a Leap year.");
        }
    }
}
