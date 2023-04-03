using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    /// Here we will go through the way IEnumerator can be implemented in user created class.
    /// 
    /// I will explain it on call.. for now just go through the code if possible.
    ///  
    /// Link: https://stackoverflow.com/questions/558304/can-anyone-explain-ienumerable-and-ienumerator-to-me
    /// 
    /// Also, ask me about why For loop is faster than for each loop.
    /// 
    /// I constructed the example by ripping the code from the below link, I added some extra bits though.
    /// Link: https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator?view=net-6.0#System_Collections_IEnumerable_GetEnumerator


    // Simple business object.
    public class Person
    {
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }

        public string firstName;
        public string lastName;
    }

    // Collection of Person objects. This class implements IEnumerable so that it can be used with ForEach syntax.
    public class BankEmployees : IEnumerable
    {
        private Person[] _people;
        public BankEmployees(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        
        public void AssignTechnologyTraining()
        { 
         // Does something to improve the skillset of the employees.
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public BankEmployeesEnum GetEnumerator()
        {
            return new BankEmployeesEnum(_people);
        }
    }

    // When you implement IEnumerable, you must also implement IEnumerator.
    public class BankEmployeesEnum : IEnumerator
    {
        public Person[] _people;

        // Enumerators are positioned before the first element until the first MoveNext() call.
        int position = -1;

        public BankEmployeesEnum(Person[] list)
        {
            _people = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    public class FireFighters : IEnumerable
    {
        private Person[] _people;
        public FireFighters(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        public void ProvideLivesSavedData()
        {
            // Does something to improve the skillset of the employees.
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _people.GetEnumerator();
        }

    }

    class App
    {
        public static void Example()
        {
            Person[] peopleArray = new Person[3]
            {
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
            };

            BankEmployees peopleList = new BankEmployees(peopleArray);
            
            // Explain why there are no braces after the for each loop.
            // Explain the difference between for and for each loop.
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);

            FireFighters frontLineWorkers = new FireFighters(peopleArray);
            frontLineWorkers.ProvideLivesSavedData();
            foreach(Person p in frontLineWorkers)
            {
                string name = p.firstName;
            }
        }
    }
}
