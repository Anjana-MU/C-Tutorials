using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    public class Student
    {
        // If you declare some variable as protected, then it will be 
        // visible only to the classes that are deriving from it.

        protected string name;
        protected string dept;
        protected int year;
        protected int points;

        public int Points { get { return points; }  }

        public Student()
        {
            // We are creating an empty constructor, nothing will get set here.
            // Variables belonging to this class will be set to their defaults.
        }

        public Student(string name, int year, string dept)
        {
            this.name = name;
            this.dept = dept;
            this.year = year;
            this.points = 10;
        }

        public void StudentInfo()
        {
            Console.WriteLine("\n Student info :");
            Console.WriteLine(" Name: " + name + " | Dept : " + dept + " | Year : " + year);
        }

        public void Feedback()
        {
            Console.WriteLine("\n A very studious student who made his/her way into " + year);
        }

        /// A method marked as abstract, virtual or override can be overriden by any class 
        /// that derives this class.
        public virtual void Responsibility()
        {
            Console.WriteLine(this.name + " needs to complete the current year with 85% marks");
        }

    }

    public class Scholar : Student
    {
        /// Just focus on how we are updating the points for this Scholar vs
        /// the points updation for the SportsPerson (next inherited class).

        public new int Points { get { return base.points; } }

        public Scholar(string name, int year, string dept, string sport) : base(name, year, dept)
        {
            base.points = base.points + 20;

            // We will discuss about this during type casting.
        }
    }


        public class SportsPerson : Student
    {
        // We want this variable to visible to only the classes that are deriving from it.
        protected string sport;

        // We want a new points variable here, because we are going to increase the points as 
        // this person is also playing sports. So we have used the new operator.
        protected new int points;

        public new int Points { get { return this.points; } }


        /// In derived class we need to declare constructors, if we don't intend to create constructor
        /// in the derived class, then at least a default constructor needs to be present in the 
        /// base class, so that it will be used by the derived class.
        public SportsPerson(string name, int year, string dept, string sport) : base(name, year, dept)
        {
            this.sport = sport;
            this.points = base.points + 20;
            // The other three variables will be directly assigned to the base class.
            // 
            // We have called the constructor of the base class here.

            // Only the sport variable is new here and we have promptly assigned it to the 
            // correct member in this class.

            // Rest will be taken care by the base class constructor.

            // This is how we can make use of base class constructor.

            // If we directly just initialise variables in this class and not set any values for the 
            // variables of base class then the base class variables will be set to default values and 
            // that is not something we will be happy about. AVOID THAT BEHAVIOUR, PLEASE!
        }

        public void CompleteInfo()
        {
            base.StudentInfo();
            Console.WriteLine(" Sport played : " + this.sport);
            Console.WriteLine(" Total Points : " + this.points);
        }

        /// If we want to give a new definition to the method described in the base class then we can use
        /// the "new" operator to give a new method definition.
        /// Basically we are hiding the base method and giving a new implementation.
        public new void Feedback()
        {
            Console.WriteLine(this.name + " is an active member of the " + this.sport + "club");
        }

        public override void Responsibility()
        {
            base.Responsibility();
            Console.WriteLine(base.name + " needs to help his team win the inter-college tournament");
        }

        /// This method is created only in this derived class.
        /// So this is like an extra information apart from the base class.
        public void SportsRecord()
        {
            Console.WriteLine("Total games played : 0");
        }
    }

    /// This is a multi-level inheritance.
    /// Reason: The class we are deriving from itself is a derived class.
    /// 
    /// We have made this class as Sealed, so that no further Inheritance is possible.
    public sealed class SportsTrainerStudent : SportsPerson
    {

        public SportsTrainerStudent(string name, int year, string dept, string sport) :
                                                        base(name, year, dept, sport)
        {
            // In this class we are not going to declare any new variable, but when we create
            // an object of this class, then we need to initialise the members of the base class
            // as well. Hence we will collect the values from the user and make use of the base
            // class constructor and assign the values.
            base.points = base.points + 30;

            // Notice the difference between this class points and the previous class points.
            // Here we are modifying the base class points itself.
            // This is similar to the Scholar class example I gave earlier.
        }

        public new void Feedback()
        {
            Console.WriteLine(base.name + " is being a member of the sport " + base.sport + "\n" +
                              " this person is also the trainer of the team");
        }

        public new void CompleteInfo()
        {
            /// Here we are not calling the base.completeinfo() because then it will print the points belonging  
            /// to the sports person as it has already defined the lines  to print the points for that person.
            /// 
            /// S0, we will just print the studentinfo which is the top most parent class.
            /// 
            /// Then we will add the remaining data as we want it..We kind of do some repetition work..
            /// but no other option here....
            /// 
            base.StudentInfo();
            Console.WriteLine(" Sport played : " + base.sport);
            Console.WriteLine(" Total Points : " + this.points);
            Console.WriteLine(" This person is also the trainer of the team");
        }

        public override void Responsibility()
        {
            /// We are adding extra responsibility to the student, we are making use of the work
            /// we did in the earlier class.
            /// 
            /// We kind of over loading the work of the student as he becomes a sportsperson and then even
            /// more work if he/she is a sportstrainer.. just like how you are overloaded with work
            base.Responsibility();
            Console.WriteLine(" This person has to train 10 students belonging to the sport");
        }

        /// Remember the new method we created in the SportsPerson class?
        /// Lets say I don't want that method to be visible if someone created a SportsTrainerStudent object.
        /// 
        /// That is not possible in C#, because if you declare a method as public then you derive the class,
        /// it will be visible in the derived class object as well.
        private new void SportsRecord()
        {
            Console.WriteLine("See if this gets printed using a sports trainer student object");
        }
    }


    /// It is not necessary that we need to override the methods all the time.
    /// 
    /// Some /all of the base class methods can be left as it is.
    /// 
    /// In this example I just wanted to show different examples of overriding and using the base
    /// keyword, so I overrode the methods.

    /// I will explain this in detail during the call.
    /// 
    /// For now, just focus on the base and derived class constructor.
    /// 
    /// What are override methods, why we are using New operator for few classes and variables
    /// why we sometimes use base.method or base.variable?
    /// 
    /// I understand it is a bit confusing, especially when you are seeing it for the first time.
    /// But don't worry, we can just go over the basics, not many people would be using 
    /// every single concept.. so its fine.
    /// 

    public class InheritanceExample
    {
        public static void Methods_1()
        {


            Console.WriteLine("\n\t Hello, Anjana!\n");

            Console.WriteLine("\n **********************************");
            Student std = new Student("Ranj", 4, "IT");
            std.StudentInfo();
            std.Feedback();
            std.Responsibility();
            
            Console.WriteLine("\n **********************************");
            Console.WriteLine("\n Publishing SportsPerson info");
            SportsPerson sp = new SportsPerson("Uppin", 2, "Mech", "Life");
            sp.StudentInfo();
            sp.SportsRecord();
            sp.CompleteInfo();
            sp.Feedback();
            
            Console.WriteLine("\n **********************************");
            Console.WriteLine("\n Publishing SportsPersonTrainer info");
            SportsTrainerStudent sts = new SportsTrainerStudent("Anjana", 3, "CSE", "Running");
            sts.Feedback();
            sts.CompleteInfo();
            sts.Responsibility();
            sts.SportsRecord(); // check which method gets executed for this
            
        }

        public static void Methods_2()
        {
            /// Here we will see how we can move from child to parent class.

            // Parent class - also called as super class
            Student std = new Student("Ranj", 4, "IT");

            // child class - also called sub class - this is derived from the parent class
            SportsPerson sp = new SportsPerson("Uppin", 2, "Mech", "Life");

            /// ********* Important ***************
            /// Child class is also called as derived class/inherited class
            /// Parent class is also called as base class/super class
            /// 
            /// The child class will always have extra information in them, this would be due 
            /// to the extra parameters and methods we added in them.
            /// 
            /// This is analogus to real life, where the children will know lot of new things 
            /// in life than their parents....So the child can teach the latest technologies 
            /// to their parents and NOT vice versa.. your father might not be able to teach 
            /// you about instagram or social media but you can teach him that.
            /// 
            /// Child can teach the additional technologies to parent, but not the other way around,
            /// because parents will lack that knowledge.
            /// 
            /// Similarly in programming, the child class (sub class) can be changed into parent
            /// class ( which means the additional methods and properties we created in the child
            /// class will be lost). But we cannot change Parent class into a child class.. Why? 
            /// Because when you try to convert a parent class into child class it will lack 
            /// the new methods and properties we created in the child class.
            /// 


            // When you run this code, you will get error, even though the compiler thinks this is fine
            // this is called run-time polymorphism.. Because during the execution the program decides which
            // object's method to call.

            SportsPerson newObj = (SportsPerson)std;

            /// Here we are converting the base class(parent) into child class(derived).
            /// It will appear fine to look at while writing the code, the compiler will not alert you abt anything.

            // **** Try executing the below code and understand the errot
            // newObj.SportsRecord();
            // So, basically std (student) object will not have a SportsRecord and 
            // where will the computer get the data from, so this way of trying to access child class
            // methods from parent class should be avoided
        }

        public static void Methods_3()
        {
            
            // child class - also called sub class - this is derived from the parent class
            SportsPerson sp = new SportsPerson("Uppin", 2, "Mech", "Life");

            // Notice that as a sports person we are able to access 5 methods of that class.
            // The sportsperson version of the implementation will be printed.
            sp.StudentInfo();
            sp.Feedback();
            sp.Responsibility();
            sp.CompleteInfo();
            sp.SportsRecord();

            /// Lets convert the child class (sub class) into parent class (super class)
            /// and see if it fails or not, also what are the methods we are able to access.

            Console.WriteLine("\n ***** Converted to Student***********");
            // Student is the base class
            Student std = (Student)sp;

            // Once we convert the sports student to a regular student then we can only access those basic 3 methds.
            // The actual student implementation will be printed.
            std.StudentInfo();
            std.Feedback();
            std.Responsibility();


            SportsTrainerStudent trainerObj = new SportsTrainerStudent("Ranjana", 4, "IT", " Sleeping");

            /// Notice here that the SportsTrainerStudent class is derived from SportsPerson class,
            /// which in itself was derived from student class.
            /// 
            /// So, there is a connection between SportsTrainerStudent and Student class.
            /// Student--->SportsPerson-->SportsTrainerStudent 
            /// From right to left, the class object can be converted without any error.
            /// 
            /// SportsTrainerStudent can be converted into Student as well as SportsPerson class object.
            /// This is shown in the below example. 
            SportsPerson sportsPersonObj = (SportsPerson)trainerObj;
            Student studentObj = (Student)trainerObj;


            /// ********************** TASK ***************************
            /// Guide her to do typecast again and read the values of the points and make her explain
            /// what happens in that variable.


            /// So if there is a method that accepts student object, then either Student, SportsPerson
            /// or SportsTrainerStudent can be supplied to that method.
            /// 
            /// If a method expects SportsPerson object, then either SportsPerson or SportsTrainerStudent
            /// can be supplied to that method.
            /// 
            /// If a method expects SportsTrainerStudent, then only that object can be supplied to it.
            

            /// I will explain this on call, I know this is a bit confusing to read on text.
        }
    }
}
