using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    /// ************ Information ****************
    /// 
    /// Let's look at the What and Why part of the class definition.. 
    /// 
    /// Lets begin with "What".. What is a class?
    /// 
    /// Class is a collection of related varaibles and methods clubbed together.
    /// Class name should be a noun, it should explain what it is supposed to be doing.
    /// If we have a class named Point3D, it means it stores 3D point data and some related operations 
    /// for those point values stored that will be stored in that class object.
    /// So Why would we need to store items as a class (why some related methods and variables need to be
    /// put together)..? Because....
    /// It is easy to check the functionality of a simple class.
    /// It is easy to understand what a class is expected to do.
    /// Enables us to understand the responsibilty of the class.
    /// It becomes easy to remove a class and replace it with another one.
    /// When related methods are put together in class, it helps to update the class as well.

    /// *********************** Most important ********************************
    /// Classes help us to conceal (hide) some variables and methods outside of the class.
    /// Those variables and methods are only needed for the internal functionality of the class.
    /// This is called Encapsulation, one of the important principles of OOPS.
    /// 
    /// Encapsulation is the packing of "data" and "functions operating on that data" into a 
    /// single component and restricting the access to outside code.
    /// 
    /// Encapsulation means that the internal representation of an object is generally 
    /// hidden from view outside of the object's definition.

    /// Encapsulation is achieved by using Access Specifiers (Public, Private, Protected, Internal, Sealed).
    /// More on this later.


    /// ******************** Important ***************************
    /// System.Object is the most basic level class present in C#.
    /// So any class that we develop will be by default contain the contents of system.object class
    /// This is applicable even to the integers, float, string.
    /// 
    /// Exercise, create a int variable named num, and write "num."and see the methods getting listed
    /// You should get .ToString(), .GetType(), .GetHashCode(), .Equals()... something like this.
    /// These methods correspond to the methods of the basic system.object class.
    /// So whenever you create a new class, these basic methods will be part of that new class.
    /// 
    /// All humans by default at birth start crying, drinking milk, smiling..
    /// these are the basic characters of the child and as the child becomes an adult 
    /// while growing up, she/he would develop other characters, but these basic 
    /// characters will be part of everyone... so those basic characteristcs are like the
    /// properties of the system.object class... Did you get it or did I confuse you more?

    /// In the below explanations wherever I use Public, private, I try to explain it
    /// But a complete definition is given separately.. for now don't stress about it much..
    /// Little stress is fine, but not much.

    /// Lets start with a simple class and its contents
    /// Note: Two classes are created as Partial classes
    /// Partial classes mean, you can few parts of the class in one segment and the other part elsewhere.
    /// I don't want to create all the methods in this file itself, then it would become a bit
    /// difficult for you to understand everything, already there is a bit too much stuff in here.
    /// 
    /// Whatever concept I want to explain you, only the stuff related to that is mentioned in the below class.


    partial class Point3D
    {

        //---------------------------  FIELDS ----------------------------------------

        // These are called FIELDs, think of them as data fields,
        // it is used to store values related to the class.
        // It is not advisable to expose the fields directly outside the class.
        // That is the reason why it has been marked as private ( acccessable only
        // to the memebers within the class)
        // Declaring it as private will not let anyone from outside the class to access it.
        // Making it as private is like having a dog at the entrance of the house
        // Dogs won't let any outsiders enter the house... Your dog is useless in that aspect
        // But you get the jist, didn't you?
        private double x, y, z;


        //---------------------------  PROPERTIES ----------------------------------------

        /// We have something called PROPERTIES, this is normally  used to let others
        /// access the fields(variables) outside the class.
        /// 
        /// You can either let the variable be read outside the class,
        /// let the variable's value be assigned from outside the class,
        /// or let both read and write access to that variable from outside.
        /// 
        /// For the x, y and z variables I will show different operations on each of them
        /// 
        /// The local variables are normally declared in lower case.
        /// The corresponding properties for them are declared in upper case.
        /// 'Get' keyword means, the variable can be accessed from outside the class.
        public double X { get { return this.x; } }

        /// For the y variable, we are letting the value be read as well as set value from outside.
        /// 
        /// Get method lets you read the value from outside.
        /// Set method lets you set the value from outside.
        /// 
        /// Similar to the above property, this property could also have been written in a single line.
        /// I included some condition in the Get method, to show that you can also do somethig like that
        /// and it is not mandatory that you should just return the same value in Get method.
        /// 
        /// Same goes for Set property, if the user is trying to set any value that the class should not take,
        /// then you can do some checks before assigning it to the local variable.
        public double Y
        {
            get
            {
                if (this.y < 0)
                {
                    return 0;
                }
                else
                {
                    return this.y;
                }
            }
            set
            {
                if (value > 1000)
                {
                    throw new Exception("Dude, what is this value even?");
                }
                else
                {
                    this.y = value;
                }
            }
        }

        // The reason why properties are public is that, otherwise it will not be accessible outside the class
        public double Z
        {
            set { this.z = value; }
        }

        //--------------------------- CONSTRUCTORS ----------------------------------------
        // 
        // Constructors help us to assign some default values or do some basic operations
        // at the time of creating a class object
        //
        // If no constructor is created for a class, then a default constructor with zero variables
        // is created by the compiler itself
        public Point3D()
        {

            /// We are inside a constructor.
            /// 
            /// Access Specifier(public, private stuff) followed by the Class name itself.
            /// 
            /// Constructors can take arguments similar to methods.
            /// 
            /// If you don't declare a constructor, the compiler will by default create an empty constructor 
            /// So, if you didn't create any constructor, the current constructor with empty
            /// parameters would have been created by the compiler itself during execution.
            /// 
            /// Why would we need an empty constructor?
            /// Maybe you didn't want any input fromt the user, but you wanted to setup some
            /// default values in the code.


            /// We are setting the some default values for the x, y, z.
            /// Using two ways we have set the values for x, y and z.
            /// 
            /// In this case both does the same job, because the compiler knows that x as well as this.x 
            /// means the same thing.
            /// ******* "this" corresponds to this class and "this." brings members of this class
            x = 0;
            y = 0;
            z = 0;
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }

        public Point3D(double x, double y, double z)
        {
            /// In this constructor we are assigning the values the users passed at the time
            /// of creating the class object. 
            /// 
            /// Example: Point3D somePoint = new Point(30,20,0); Did you understand?
            /// Here 30,20 and 0 are the values passed by the user via constructor.
            /// 
            /// 
            /// Unlike the above constructor, here we are only using this.x =x option,
            /// This is because the constructor already has parameters named x,y and z.
            /// So we want to explicity tell the constructor, that take the 'x' value from the
            /// method signature and assign it to the class member (this.x).
            /// 
            /// Always try to use "this." style to avoid confusion about which variable
            /// you are dealing with.

            this.x = x;
            this.y = y;
            this.z = z;
        }

        // --------------- Methods ----------------------
        public bool PointInNegativeZone()
        {
            // this method will True if any of the coordinates value is less than 0
            // otherwise it will return False
            return (this.x < 0 || this.y < 0 || this.z < 0);
        }

        /// **************** Learning **************************
        /// So this class has 3 variables to store X, Y and Z.
        /// 
        /// Through the constructor you can either set the X,Y and Z values at the time of creation
        /// or create with a default constructor which sets the values to 0,0,0.
        /// 
        /// This class has Properties as X, Y and Z.
        /// 
        /// X allows us to 'get' the X coordinate value from the class object.
        /// Y allows us to 'get' as well as 'set' the Y coordinate value from the object.
        /// Z allows us only to 'set' the Z coordinate from the object.
        /// 
        /// This class also allows to check if any of the coordinates are in the negative zone using
        /// the method PointInNegativeZone(), which returns a bool variable.
        /// 
        /// ************** Important concept ***********
        /// This class is an example of an instance class... i.e, you can create multiple
        /// instances(objects) of the class, you cannot directly use Point3D.someMethod().
        /// 
        /// There are two types of classes: Instance classes and Static classes.
        /// Instance classes always need to be created usign the 'new' operator
        /// Example: 
        /// Point3D originPoint = new Point(0,0,0);
        /// Point3D pinLocation = new Point(10,10,0);
        /// 
        /// Multiple objects(instances) can be created using instance class.
        /// 
        /// Static classes are the ones where you can't create objects using the class name.
        /// 
        /// Static class will exist by itself.
        /// I will explain in depth in different example.. for now this info is enough.
        /// 
        /// If you feel confused, don't worry, it is not that compilcated, probably I
        /// am just not explaining it in a simpler manner.
    }

    public class Class_Usage
    {
        /// Lets create some objects

        public static void MakeSomeObjects()
        {
            // I created an object called origin and used the default constructor.
            // I know that default constructor will create point with 0,0,0 values.
            // I wanted to create point at the origin, origin is a point with 0,0,0 values,
            // so I just used the default constructor itself to save some typing effort.
            Point3D origin = new Point3D();

            // Now I created a point on x direction with other values being 0
            Point3D xDirPoint = new Point3D(10, 0, 0);

            // Lets change the coordinates of the xDirPoint object
            xDirPoint.Z = 100;
            // using the property "Z" we changed the coordinate of z of the object


            // xDirPoint.X = 50; if you try to do this, it will show error because,
            // we didn't enable the 'set' property for X, we only enabled the 'get' property.
            // i.e., we can read the value of X but not set value to it.

            // We can also access this method of the class.
            // If we had declared the method to be private then we would not be able to access
            // it outside the class.

            bool isPointInNegativeArea = xDirPoint.PointInNegativeZone();



            string result = xDirPoint.ToString();
            Console.WriteLine(result);
            // We did not create a method called ToString() in our point class, then how did 
            // it appear here? How are we able to access it here?
            // Remember all objects we create by default have the behaviour of system.object property?
            // Remember the example of how all babies by default have some intrinsic behaviour?
            // Since xDirPoint is an object we created using Point3D class, it by default has
            // the property of system.object in it.
            //
            // So, the ToString() method will return whatever the system.object class has made
            // the method to do...in this case it returned "Tutorials.Point3D" (Namespace.ClassName)
            // You don't belive that? then Call this method and see it for yourself.
            // 
            // Does that mean now we have a method on our class that is going to behave in a different way?
            // Is there a way we can modify the implementation of ToString() according to our need?
            // Yes, you can.... This way of modifying the implementation of a method is called....
            //.... METHOD OVERRIDING *******************************



            /// I will create another class below and show how to do METHOD OVERRIDING
            /// I hope you did not forget method overloading yet!
            /// The difference between overloading and overriding is that, in overloading,
            /// we have same method name but it can take different parameters and based on the 
            /// number and type of parameters, it will act differently.
            /// 
            /// Method Overriding on the other hand, changes the behaviour of the method, and once
            /// you override a method, it will start behaving in the new way and the old implementation
            /// will be overriden... Imaging I paint your face with green color, your original color will be
            /// invisible.. it's the same logic....
            /// 
            /// We also have a concept called OPERATOR OVERLOADING... that is with respect to symbols,
            /// I will explain that in the next example that follows.

        }
    }



    partial class Point2D
    {

        /// This class is being created to show method overriding and operator overloading
        /// Notice that one is overriding and the other is overloading....

        // Fields
        double x, y; // this is a 2D point, so only two variables

        static int count; // Note that this is a static variable
        // When you declare a variable as static inside an instance class you cannot access 
        //the variable using "this." operator.
        //
        // Why? Because the variable is not part of class instance i.e., if you create an instance
        // of the class as object, this static variable will not be part of the instance.
        // 
        // This variable will only be part of the actual class, not on any of the instances.

        // Properties
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public static int TotalPointsCreated { get { return count; } }
        // This is a property for the static variable (field).
        // Just like a regular instance varaible, static variables can also have properties.
        // We have created this static variable to keep count of the number of points created.


        // Constructor

        // ************** Very Important *****************
        // If you don't declare any constructor then the compiler will create a default empty constuctor.
        // But if you don't want that empty constructor and you create a constructor by yourself then the 
        // default constructor will not get created, so in this class you are basically forcing the user
        // to enter the values for x and y at the time of creating the object.
        //
        // Question
        // What if you don't want any constructor for the class at all?
        // If you don't create any constructor then the compiler will create a default, how to avoid this?
        // If you don't wany any constructor to be visible, then just create an empty constuctor
        // within the code and make it private... So even the default constructor will not be created
        // by the compiler because you have made a constructor within the code, and since it is private
        // it will not be visible while creating the class as well... voila...


        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
            count += 1; // So every time we create a point, the count variable will increase by 1.
            // count is a static variable.
            // You will not be able to use 'this.' for a static variable.
            // All the variables you try to call using 'this.' are instance variable.
            // Instance vs Static. An important topic.
        }


        public override string ToString()
        {
            // By default ToString() would return the Namesapce.ClassName info.
            // Here we have overridden that basic behaviour with a different implementation
            return "Hey Anjana, \n Point Details are \n X: " + x + " | Y :" + y;
        }

        public Point2D AddPoint(Point2D anotherPoint)
        {
            // This method creates a new Point2D object based on the current object and the 
            // object passed to it..
            // You will understand it better when you see the implementation
            return new Point2D(this.x + anotherPoint.x, Y + anotherPoint.y);
        }

        /// We have created a STATIC METHOD....
        /// So this method will not be accessible via any instance object of this class,
        /// rather we need to use the actual class name to call this method
        /// This method just returns the distance between two points

        public static Double Distance(Point2D pointA, Point2D pointB)
        {
            return Math.Sqrt(Math.Pow(pointA.X - pointB.X, 2) + Math.Pow(pointA.Y - pointB.Y, 2));
        }

        // ***************** OPERATOR OVERLOADING *******************
        // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/operator-overloading
        // You might have added two integers together, two strings together right?
        //  int c = a+b; int d = a-b;
        //  string WelcomeMessage = "Why did you "+ "come?";
        //
        // When you put a + sign or - sign, how does the compiler know that it needs to add two things together.
        // How does the compiler know it needs to add two strings together and give out a new string to you?
        // Well, somewhere in the C# language, they would have written the code for integers and strings about
        // what should happen, if someone uses these symbols (operators) between them.
        // Example : int a = 3, b =4; a+b (two integer variables are used with + symbol)
        // 
        // This kind of behaviour can be extended to the user created objects as well.
        // Say, I create two Point2D objects:
        // Example Point2D x1 = new Point2D(10,10)
        //         Point2D x2 = new Point2D(20,20)
        // What if I want to add these two coordinates and put it in a new point?
        // You are thinking wouldn't it be possible to just do--> (x1+x2 ) and get a new point?
        // Well, you can use Operator overloading and define what should happend when someone writes a '+'
        // operator between two Point2D objects.
        //
        //... Read it all again if you are confused.... We will do examples, so don't worry
        //
        // Notes:
        // Operator overloading can be done for any kind of operator symbol (+, -, *, /, < , >..)
        // But you google what are all the signs that can be used, I know these will work
        // Also, it's not that you need to work with only the objects of the same class.. 
        // I will explain this in the example.


        // Lets create + and - operator overloading 

        // Notice that when you do operator overloading, it has to be static as well as public.
        // Because you don't create an instance of the class and call
        // That is a very important point. **************************
        // Also, this operator should be visible outside of the class, hence it should be public.
        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X + point2.X, point1.Y + point2.Y);
        }


        // ******* Very Imporant ********
        //  In this method are you noticing that we would be using the opertor with Point2D and integer value
        public static Point2D operator +(Point2D point1, int offset)
        {
            return new Point2D(point1.X + offset, point1.Y + offset);
        }


        // This is just an example for - operator overloading
        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D(point1.X - point2.X, point1.Y - point2.Y);
        }



        // Overriding Equals operator
        // Please read about Equals vs == in C# for reference and value objects
        // link: https://www.c-sharpcorner.com/UploadFile/3d39b4/difference-between-operator-and-equals-method-in-C-Sharp/
        // Please go through other links as well.... 
        // This equals opertor is an important interview question as well...
        // I will update the material if I come across some good explanation.
        // For now, just remember that we have modified the Equals method to check if two items are same only  
        // based on their coordinate values. 
        public override bool Equals(object? point2D)
        {
            Point2D point =(Point2D) point2D;

            bool sameXval = (this.X - point.X) < 0.0001;
            bool sameYval = (this.Y - point.Y) < 0.0001;
            
            return (sameXval && sameYval );
        }
    }

    public class OverloadingExamples
    {
        public static void OverloadMethod()
        {
            Point2D x1 = new Point2D(10, 10);
            Point2D x2 = new Point2D(20, 20);

            Point2D x3 = x1 + x2;
            // The above code is not throwing any error, because we have defined '+' operator overloading method
            // Coordinares of x3 will be (30,30). can you say why?

            Point2D x4 = x3 - x2;
            // Same goes for the  - operator as well.
            // Coordinates of x4 will be (10,10), can you calculate?

            bool areSamePoints = x4.Equals(x1);
            // Remember we updated the Equals method?
            // So accroding to our updation, this method should return True as both x1 and x4 values are the same

            Console.WriteLine("Are x1 and x4 the same coordinates? : " + areSamePoints);
            // I ran the code and it said True.
            // I recommend you to check for yourself as well.

            Point2D x5 = x4 + 100;
            // The coordinates of x5 will be (110,110).
            // Can you say how we were able to add a Point2D and just a number 100 but that number got
            // added to both the coordinates?

            // Point2D x5 = x1 * x2;
            // Uncomment the above line and see the error, can you say why we get error here?
            //
            // Ok, good. Correct answer.

            string info = x3.ToString();
            Console.WriteLine("\n" + info);
            // Remember we overrode the ToString() method belonging to the base object class?
            // So here, instead of getting Namesapce.ClassName information, we will get what we
            // asked it to provide us... 

            // I will run it and paste the output here, you need to go to the method and cross-check
            // if the given output and the implementation are making sense..
            // Also, if you want to check it for yourself, then call this method from the main method and check
            // the output for yourself, I would also recommend that...

            // Output:
            // Hey Anjana,
            //  Point Details are
            // X: 30 | Y :30


            int totalPoints = Point2D.TotalPointsCreated;
            // See here, we are trying to get the total number of points we created using Point2D class.
            // Did you notice that we are actually getting the value from the class and not using any
            // of the instances?
            // This is one of the ways in which a static value in a class could help us.
            // Imagine a class which is used to store student information and whenever a new student
            // is created, it automatically created studentID based on the number of students and 
            // assigns the ID to every new student being created.


            double dist = Point2D.Distance(x1, x2);
            // Similar to the static variable, here we called the static method to calculate
            // the distance between the two points.

            // You might wonder, isn't it a bit messy to have static methods as well as instance methods
            // in the same class..  Doesn't it make it difficult to remember if the class has
            // instance methods or static methods without reading about the class or going through 
            // the contents of the class?
            //
            // Good question.. Ideally we should not club static and instance methods in the same class.
            // But in our Point2D class, we only made 2 static items. 1 variable and 1 method.
            // If you want too many helper methods like the distance method we created, or too many
            // variables for that matter, then it is better to create another class just to have the 
            // static items in them.. Maybe create a static class called Point2DHelper
            //
            // The Math class in System.Math is a pure static class.
            // So ideally keep the static and instance methods in seperate classes.
            // But if there are only handful of static methods,then it is okay to keep them in the 
            // same instance class... It's not a crime to do so.. You won't get arrested.. so don't worry


            /// ****************** Learning *****************
            /// An instance class can have static variables as well as static methods.
            /// A static class cannot have instance variables or instance methods.
            /// A static class should only contain static items in it.
            /// Think about it. If a class is static, then it can never be initialised,
            /// if you can never initialise a class (i.e, creating object), then how will you access
            /// those instance variables or methods?
        }

    }
}
