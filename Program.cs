using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace University;

class Program
{
    //Creating a static University object
    static University university = new University(); 

    static void Main()
    {
        bool loop = true;
        //Running an endless loop 
        while (loop)
        {
            Console.WriteLine("\nUniversity Management System");
            Console.WriteLine("1. Add a Student");
            Console.WriteLine("2. Add a Professor");
            Console.WriteLine("3. Enroll Student in a Course");
            Console.WriteLine("4. Assign Subject to Professor");
            Console.WriteLine("5. Display All People");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            //Using try catch to avoid crashing
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                //Using switch:case 
                switch (choice)
                {
                    case 1: AddStudent(); break;
                    case 2: AddProfessor(); break;
                    case 3: EnrollStudentInCourse(); break;
                    case 4: AssignSubjectToProfessor(); break;
                    case 5: university.DisplayAllPeople(); break;
                    case 6: { Console.WriteLine("Have a good day!");loop= false; break; }
                    default: Console.WriteLine("Invalid choice. The number must between 1-6 ! "); break;                  
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        //Creating Student
        static void AddStudent()
        {
                Console.Write("Enter ID: ");
                string id = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(id) || id.Contains(" "))
                throw new IdSetupException();
            
            Console.Write("Enter Name: ");
                string name = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(name))
                throw new NameSetupException();

            Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine()!);
                Console.Write("Enter GPA: ");
                double gpa = Convert.ToDouble(Console.ReadLine()!);

                university.AddPerson(new Student(id, name, age, gpa));
        }

        //Creating Professor
        static void AddProfessor()
        {
            Console.Write("Enter ID: ");
            string id = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(id) || id.Contains(" "))
                throw new IdSetupException();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(name))
                throw new NameSetupException();
            
            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Enter Salary: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine()!);

            university.AddPerson(new Professor(id, name, age, salary));
        }

        //Enrolling student into course
        static void EnrollStudentInCourse()
        {
            Console.Write("Enter Student ID: ");
            string id = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(id) || id.Contains(" "))
                throw new IdSetupException();


            Console.Write("Enter Course Name: ");
            string course = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(course))
                throw new CourseNameException();

            Student? student = university.FindPerson(id) as Student;
            if (student != null)
                student.EnrollCourse(course);
            else
                Console.WriteLine("Student not found!");
        }

        //Assigning professor into subject
        static void AssignSubjectToProfessor()
        {
            Console.Write("Enter Professor ID: ");
            string id = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(id) || id.Contains(" "))
                throw new IdSetupException();

            Console.Write("Enter Subject Name: ");
            string subject = Console.ReadLine()!;
            if (string.IsNullOrWhiteSpace(subject))
                throw new SubjectNameException();

            Professor? professor = university.FindPerson(id) as Professor;
            if (professor != null)
                professor.AssignSubject(subject);
            else
                Console.WriteLine("Professor not found!");
        }

    }
}