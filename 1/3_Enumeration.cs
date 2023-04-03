using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{

    /// Enumerations -- a.k.a Enum
    /// English definition - 
    /// Enumeration  - the action of mentioning a number of things one by one.
    /// 
    /// So, in programming enumeration is used to give a list of options to user.
    /// Why? So that they could choose only from the values given to them  and not anything at random,
    /// limits the choice to the user and saves the headache of dealing with unncessary values.
    /// 
    /// **** Enumeration is a value type
    /// 
    /// You can directly declare an Enum with values or assign some numeric values for the items in them
    /// 

    /// lets see couple of examples


    enum Department
    {
        CSE,
        IT,
        Mech
    }

    enum Subject
    {
        
        /// Each subject is provided with a weightage which we can use later.
        
        DataBase = 20,
        Programming = 30,
        Project = 40
    }

    internal class EnumerationExamples
    {

        private static void PublishStudentInfo(string name, Department enumDept)
        {
            /// Here the user cannot select any other department other than one
            /// present in the Department Enum.

            /// Also, all enum will be associated with int values by default.
            /// These values will be given based on the order they are in.
            /// The last item in the print statement is trying to get the integer
            /// value out and print it.

            Console.WriteLine("\n Student : "+name+
                            "\n Department : "+enumDept+
                            "\n Department ID: "+(int)enumDept);
        }

        private static void PublishStudentMarksByPercent(string name, int mark, Subject subjectEnum)
        {

            /// Here we will try to use the values we stored against the names of the 
            /// subjects in the Subjects enum.

            Console.WriteLine("\n Name: " + name + "\n" +
                                " Original Mark: " + mark + "\n" +
                               " Mark with weightage: " + mark * (int)subjectEnum);
        }


        public static void Example()
        {
            // Execute the code and infer the results.

            Console.WriteLine("\n Direct usage of Enum ");
            PublishStudentInfo("Ranjana", Department.CSE);
            PublishStudentInfo("Uppin", Department.Mech);
            // Understand why Uppin gets dept id as 2 and Ranjana gets the ID as 0.

            Console.WriteLine("\n An example to use the int value stored in Enum");
            PublishStudentMarksByPercent("Anjana", 20, Subject.Project);
            // Did you understand why the final score is 800?
;        
        }

        /// Link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
    }
}
