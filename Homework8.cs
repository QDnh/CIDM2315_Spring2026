namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        // Code to create Customer objects and customer_list.
        Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
        Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
        Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
        Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
        Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
        Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
        Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

 	    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};

        // Call Q1 method
        TotalCredits(customer_list);
        // Call Q2 method
        AmarilloAverageAge(customer_list);
        // Call Q3 method
        CanyonAge(customer_list);
    }
    
    // Create Q1 method.
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredits = 0;
        foreach(Customer cus in customer_list)
        {
            totalCredits += cus.CustomerCredit;
        }
        Console.WriteLine($"Q1: The total credits: {totalCredits}");
    }

    // Create Q2 method.
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        double amAvAge = 0;
        double numberInAmarillo = 0;
        foreach(Customer cus in customer_list)
        {
            if (cus.CustomerCity == "Amarillo")
            {
                amAvAge += Convert.ToDouble(cus.CustomerAge);
                numberInAmarillo++;
            }
        }
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {amAvAge/numberInAmarillo}");
    }

    // Create Q3 method.
    public static void CanyonAge(Customer[] customer_list)
    {
        Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");
        foreach(Customer cus in customer_list)
        {
            if (cus.CustomerCity == "Canyon" && cus.CustomerAge > 30)
            {
                Console.Write($"{cus.CustomerName}, ");
            }
        }
    }
}

// Code to create Q0 class Customer.
class Customer
{
    private string customerName;
    private int customerAge;
    private string customerCity;
    private double customerCredit;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }

    // Accessors.
    public string CustomerName
    {
        get { return this.customerName; }
    }
    public int CustomerAge
    {
        get { return this.customerAge; }
    }
    public string CustomerCity
    {
        get { return this.customerCity; }
    }
    public double CustomerCredit
    {
        get { return this.customerCredit; }
    }
}

