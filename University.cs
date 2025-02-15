using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University;

class University
{
   
    private Dictionary<string, Person> people = new Dictionary<string, Person>();


    //Creating AddPerson method that adds student/professor
    public void AddPerson(Person person)
    {
        if (!people.ContainsKey(person.Id))
        {
            people[person.Id] = person;
            Console.WriteLine($"{person.Name} added successfully.");
            if(person is Student student && student.Graduate())
            {
                    people.Remove(person.Id);
                    Console.WriteLine($"{person.Name} have graduated and was removed.");
            }
        }
        else
            throw new DuplicateIdException(person.Id);        
    }

    //Creating FindPerson method that finds person by ID
    public Person? FindPerson(string id)
    {
        return people.ContainsKey(id) ? people[id] : null;
    }


    //Creating DisplayAllPeople method
    public void DisplayAllPeople()
    {
        if (people.Count == 0)
        {
            Console.WriteLine("No people in the university.");
            return;
        }

        foreach (Person person in people.Values)
           person.GetInfo();
        
    }

    
}
