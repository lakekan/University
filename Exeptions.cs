using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University
{
    //Creating costume Exceptions

    internal class AgeException : Exception
    {
        public AgeException() : base("The age must be between 0 to 150!") { }

    }

    internal class GPAException : Exception
    {
        public GPAException() : base("GPA must be between 0 to 4!") { }
    }

    internal class DuplicateIdException : Exception
    {
        public DuplicateIdException(string id) : base($"ID: {id} already in use") { }
    }

    internal class PersonNotFoundException : Exception
    {
        public PersonNotFoundException(string id) : base($"There is no person with same id: {id}") { }
    }

    internal class SalaryException : Exception
    {
        public SalaryException() : base("Salary must be between 0 to 60,000$") { }
    }

    internal class IdSetupException : Exception
    {
        public IdSetupException() : base("Invalid ID! ID cannot be empty or contain spaces.") { }
    }


    internal class NameSetupException : Exception
    {
        public NameSetupException() : base("Invalid Name! Name cannot be empty.") { }
    }

    internal class CourseNameException : Exception
    {
        public CourseNameException() : base("Invalid Course Name! Name cannot be empty.") { }
    }

    internal class SubjectNameException : Exception
    {
        public SubjectNameException() : base("Invalid Subject Name! Name cannot be empty.") { }
    }

}
    
