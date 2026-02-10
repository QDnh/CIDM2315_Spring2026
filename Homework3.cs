namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1.
        Console.WriteLine("Input an integer:");
        int input1 = Convert.ToInt16(Console.ReadLine());
        int primeCheck = 0;
        
        // Determine if input is prime.
        for (int i = 2; i < input1; i++)
        {
            if ((input1 % i) == 0)
            {
                primeCheck++;
                break;
            }
        }
        
        if(input1 < 2) // Check if input is greater than 1.
        {
            Console.WriteLine("N is non-prime");
        }
        else if (primeCheck > 0) // Check if input is not prime.
        {
            Console.WriteLine("N is non-prime");
        }
        else // State input is prime.
        {
            Console.WriteLine("N is prime");
        }

        // Blank line to separate Q1 and Q2.
        Console.WriteLine(" ");

        // Code for Q2.
        Console.WriteLine("Assign an int value to N:");
        int input2 = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < input2; i++)
        {
            for (int j = 0; j < input2; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }

        // Blank line to separate Q2 and Q3.
        Console.WriteLine(" ");

        // Code for Q3.
        Console.WriteLine("Assign an int value to N:");
        int input3 = Convert.ToInt16(Console.ReadLine());

        for (int i = 0; i < input3; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }

        // Blank line to separate Q3 and Bonus.
        Console.WriteLine(" ");

        // Code for Bonus.
        Console.WriteLine("Assign an int value to N:");
        int input4 = Convert.ToInt16(Console.ReadLine());
        
        // Number of rows.
        for (int i = 1; i <= input4; i++) 
        {
            // Number of spaces per row.
            for (int j = (input4 - i); j > 0; j--) 
            {
                Console.Write(" ");
            }

            // Number of numbers per row.
            for (int k = 1; k <= i; k++)
            {
                Console.Write(i);
            }
            
            // Move to new row.
            Console.WriteLine(""); 
        }
    }
}
