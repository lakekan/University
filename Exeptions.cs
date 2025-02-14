using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    //Creating costume Exceptions

    internal class AgeException: Exception
    {
        public AgeException()  : base("The age must be between 0 to 150!") {}
        
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
}
