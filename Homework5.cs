namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Code for calling Q1 Method.
        Console.WriteLine("Enter the first int: ");
        int a1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the second int: ");
        int b1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a1}; b = {b1}");
        Console.WriteLine("The larger number is: " + FindLarger(a1, b1));

        // Blank line to separate Q1 and Q2.
        Console.WriteLine("");

        // Code for calling Q2 Method.
        Console.WriteLine("Enter the first int: ");
        int a2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the second int: ");
        int b2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the third int: ");
        int c2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter the fourth int: ");
        int d2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {a2}; b = {b2}; c = {c2}; d = {d2}");
        Console.WriteLine("The largest number is: " + FindLargest(a2, b2, c2, d2));

        // Blank line to separate Q2 and Q3.
        Console.WriteLine("");

        // Call Q3 Method.
        CreateAccount();
    }

    // Q1 Method.
    static int FindLarger(int input1, int input2)
    {
        if (input1 >= input2)
        {
            return input1;
        }
        else
        {
            return input2;
        }
    }

    // Q2 Method.
    static int FindLargest(int input1, int input2, int input3, int input4)
    {
        int max1 = FindLarger(input1, input2);
        int max2 = FindLarger(input3, input4);
        int max = FindLarger(max1, max2);
        return max;
    }

    // Q3 Methods.
    // Q3 First Method.
    static bool CheckAge(int birth_year)
    {
        int current_year = 2026;
        int age = current_year - birth_year;
        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Q3 Second Method.
    static void CreateAccount()
    {
        // Input code.
        Console.WriteLine("Enter Your Username: ");
        string? username = Console.ReadLine();

        Console.WriteLine("Enter Your Password: ");
        string? password = Console.ReadLine();

        Console.WriteLine("Enter Your Password Again: ");
        string? password2 = Console.ReadLine();
        
        Console.WriteLine("Enter Your Birthyear: ");
        int birthyear = Convert.ToInt16(Console.ReadLine());

        // Logic code.
        if (CheckAge(birthyear))
        {
            if (password == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }

}
