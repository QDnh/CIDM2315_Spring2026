using System.Net.Mail;

namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        // Create Student objects.
        Student stu1 = new Student(111, "Alice");
        Student stu2 = new Student(222, "Bob");
        Student stu3 = new Student(333, "Cathy");
        Student stu4 = new Student(444, "David");

        // Create Dictionary.
        Dictionary<string, double> gradeBook = new Dictionary<string, double>();
        gradeBook.Add("Alice", 4.0);
        gradeBook.Add("Bob", 3.6);
        gradeBook.Add("Cathy", 2.5);
        gradeBook.Add("David", 1.8);

        // Check if Tom is in gradeBook.
        if (!gradeBook.ContainsKey("Tom"))
        {
            gradeBook.Add("Tom", 3.3);
        }

        // Calculate and print the average grade in gradeBook.
        Console.WriteLine($"The average GPA is: {gradeBook.Values.Average()}");

        // Print out students with GPAs greater than the average.
        foreach(var grade in gradeBook)
        {
            if (grade.Value > gradeBook.Values.Average())
            {
                foreach(Student stu in Student.studentList)
                {
                    if (stu.GetStudentName == grade.Key)
                    {
                        stu.PrintInfo();
                    }
                }
                
            }
        }
    }
}

// Create Student class.
class Student
{
    private int studentID;
    private string studentName;

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    } 

    public static List<Student> studentList = new List<Student>();

    public Student(int input_stuID, string input_stuName)
    {
        studentID = input_stuID;
        studentName = input_stuName;
        studentList.Add(this);
    }

    // Accessors.
    public string GetStudentName
    {
        get { return this.studentName; }
    }
}
