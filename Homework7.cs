namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        // Create Customer objects.
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);
        
        // Print the Customer objects info.
        c1.PrintCusInfo();
        c2.PrintCusInfo();

        // Update the Customer objects IDs.
        c1.ChangeID(220);
        c2.ChangeID(221);

        // Print the Customer objects info again.
        c1.PrintCusInfo();
        c2.PrintCusInfo();
        
        // Compare Customer objects age.
        c1.CompareAge(c2);
    }
}

// Code for Customer class.
class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age >= objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }
}
