using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University;

//Creating abstract class person
abstract class Person
{
    public string Id { get; private set; }
    public string Name { get; private set; }
    private int _age;


    //Checking if the age is correct and throwing exeption if needed
    public int Age
    {
        get { return _age; }
        set {
            if(value <0 || value >= 150)
                throw new AgeException();
            _age = value; 
        }
    }

    protected Person(string id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    ////Creating GetInfo retrive the info for the relevent person and each inharate class will override it 
    public virtual void GetInfo()
    {
        Console.WriteLine($"Person Id: {Id}, Name: {Name}, Age: {Age} ");
    }

}
