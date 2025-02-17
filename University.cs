using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University;

class University
{
   
    private Dictionary<string, Person> universityMembersDict = new Dictionary<string, Person>();


    //Creating AddPerson method that adds student/professor
    public void AddPerson(Person person)
    {
        if (!universityMembersDict.ContainsKey(person.Id))
        {
            universityMembersDict[person.Id] = person;
            Console.WriteLine($"{person.Name} added successfully.");
            if(person is Student student && student.Graduate())
            {
                    universityMembersDict.Remove(person.Id);
                    Console.WriteLine($"{person.Name} have graduated and was removed.");
            }
        }
        else
            throw new DuplicateIdException(person.Id);        
    }

    //Creating FindPerson method that finds person by ID
    public Person? FindPerson(string id)
    {
        return universityMembersDict.ContainsKey(id) ? universityMembersDict[id] : null;
    }


    //Creating DisplayAllPeople method
    public void DisplayAllPeople()
    {
        if (universityMembersDict.Count == 0)
        throw new NoPeopleException();

        foreach (Person person in universityMembersDict.Values)
           person.GetInfo();
        
    }

    
}
