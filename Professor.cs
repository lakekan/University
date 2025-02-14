using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University;

class Professor : Person
{
    public List<string> SubjectsTaught { get; private set; }

    //Checking if the salary is correct and throwing exeption if needed
    private decimal _salary;
    public decimal Salary
    {
        get { return _salary; }
        set {
            if (value > 0 && value < 60000)
                _salary = value;
            else throw new SalaryException();
        }
    }

    public Professor(string id, string name, int age, decimal salary) : base(id, name, age)
    {
        Salary = salary;
        SubjectsTaught = new List<string>();
    }


    //Creating AssignSubject method that is adding a subject to a professor and throwing exeption if needed
    public void AssignSubject(string subject)
    {
        if (string.IsNullOrEmpty(subject))
            throw new ArgumentException("subject name cannot be empty.");
        if (!SubjectsTaught.Contains(subject))
        {
            SubjectsTaught.Add(subject);
            Console.WriteLine($"{subject} was added to {Name}");
        }
        else
            throw new InvalidOperationException($"{Name} already assign to this subject.");
        
    }

    //Overriding GetInfo
    public override void GetInfo()
    {
        Console.WriteLine($"Professor: {Name}, Age: {Age}, Salary: {Salary}, Subjects: {string.Join(", ", SubjectsTaught)}"); 
    }
}
