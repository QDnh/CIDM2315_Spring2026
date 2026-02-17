namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1 method.
        int a = 3;
        int b = 5;
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {FindGreater(a, b)}");

        // Blank line to separate Q1 and Q2.
        Console.WriteLine("");

        // Call Q2 method.
        int c = 5;
        string d = "left";
        MakeShape(c, d);
    }
    
    // Q1 Method.
    static int FindGreater(int input1, int input2)
    {
        if (input1 > input2)
        {
            return input1;
        }
        else
        {
            return input2;
        }
    }

    // Q2 Method.
    static void MakeShape(int input3, string input4)
    {
        Console.WriteLine($"N is: {input3}; shape is {input4}");
        if (input4 == "left")
        {
            for (int i = 1; i <= input3; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
        else if (input4 == "right")
        {
            for (int i = 1; i <= input3; i++)
            {
                // Number of spaces.
                for (int j = input3; j > i; j--)
                {
                    Console.Write(" ");
                }
                // Number of asterisks.
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
