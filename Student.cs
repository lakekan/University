using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University;

//Creating Student class
class Student : Person, IGraduatable
{

    public List<string> Courses { get; private set; }

    //Checking if the GPA is correct and throwing exeption if needed
    private double _gpa;
    public double GPA
    {
        get { return _gpa; }
        set {
            if(value > 4 || value<0)
                throw  new GPAException();
            _gpa = value; 
        }
    }

    
    public Student(string id, string name, int age, double gpa) : base(id, name, age)
    {
        GPA = gpa;
        Courses = new List<string>();
    }

    //Creating EnrollCourse method that add's course to a student and throwing exeption if needed
    public void EnrollCourse(string course)
    {
        if (string.IsNullOrEmpty(course))
            throw new ArgumentException("Course name cannot be empty.");
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            Console.WriteLine($"{course} was added to {Name}");
        }
        else
            throw new InvalidOperationException($"{Name} already enrolled to this course.");
    }

    //Overriding GetInfo method
      public override void GetInfo()
    {
       Console.WriteLine($"Student: {Name}, Age: {Age}, GPA: {GPA}, Courses: {string.Join(", ", Courses)}");
    }

    //Calling the interface to get the GPA from the Student class and checking if they are above 3 .5
    public bool Graduate() => GPA >= 3.5;

}
