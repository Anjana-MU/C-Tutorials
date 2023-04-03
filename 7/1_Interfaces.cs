using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    /// ************ Interface ***********************
    /// 
    /// Too much of theory here... just trying to make you understand by going over it in detail.
    /// 
    /// You have examples at the bottom, so don't worry.
    /// 
    /// Read the theory, look at the examples and read the theory again.
    /// 
    /// -------------------------------------------------------------------------
    /// 
    /// As far as I know, or I understand, C# does not allow multiple inheritance, i.e.,we cannot inherit
    /// from multiple class and create a new class. A class can inherit from only one class at a time.
    ///  
    /// You can have multi-level inheritance, but cannot have multiple inheritance.
    /// 
    /// Class C cannot inherit from both class A and Class B (Multiple inheritance).
    /// Class C : A, B ( This is not allowed, possible in c++, not in C#) check in python.
    /// 
    /// But this is possible, Class B: A, Class C: B (Multi-level inheritance this is).
    /// 
    /// The reason why multiple inheritance is not allowed in C# is that, it becomes complicated to maintain 
    /// classes that way, because once you derive from many classes, the new class need to implement  or it will
    /// contain the behaviours of all the base classes.
    /// 
    /// The derived class becomes tightly coupled with the classes it is deriving from.
    /// 
    /// ---------------------- Take a deep breath -----------------
    /// 
    /// We saw about Abstract class, which is nothing but a principle/guideline/concept type of class. That class in 
    /// itself cannot be instantiated, but classes can inherit from it and the classes are supposed to implement 
    /// all the methods and properties from that class.
    /// 
    /// But at a time C# allows us to inherit from only one class, be it a regular class or abstract class.
    /// 
    /// To solve this issue, we have interfaces.
    /// 
    /// A sample interface definition is given here
    /// 
    /// interface IColor
    /// {
    ///   bool ApplyColor(int colorID);
    /// }
    ///
    /// Interfaces are not classes, they are similar to abstract classes, as in, they also contain methods and
    /// property definitions in them, until C# 8.0 interfaces cannot contain definitions in them, just the name 
    /// of the methods and properties.
    /// 
    /// So, whichever class that implements interface, needs to give its own implementation for those 
    /// methods and properties ( this was until c# 8.0, check which version of C# you are using).
    /// 
    /// A class can implement multiple interfaces, interfaces are usually named starting with I (just a convention).
    /// 
    /// Example: Class Pin : IGraphic, IColor, ISize
    /// 
    /// The advantage of having interfaces is that, we can define multiple interfaces and the classes can implement 
    /// the interfaces that are needed for them...Lets say we have the following interfaces
    /// 
    /// IColor (contains the coloring properties and methods)
    /// ILayer (contains the layer related info)
    /// ILocation (Contains the info about location of the object and method to move it around)
    /// 
    /// Now, we are creating two classes, one for Piin and another for the Node (the name that appears on the 
    /// left pane of the Generator tool).
    /// 
    /// Class Piin: IColor, ILayer, ILocation
    /// {
    ///     // Implements IColor Interface properties and methods
    ///     // Implements ILayer ................................
    ///     // Implements ILocation .............................
    /// }
    /// 
    /// Class Node: IColor
    /// {
    ///     // Only IColor interface is used, because we will just color the node
    ///     // We will not have any layer related methods for this class or even location related stuff
    /// }
    /// 
    /// Here we implemented only the interfaces we thought that is necessary for the class.
    /// 
    /// If you use an interface in a class, it will force you to implement the properties and methods of the class.
    /// But from c# 8.0, if you have concrete implementation(i.e. methods with details in it) in the interface itself, 
    /// then you don't have to define the implementation in the class.
    /// 
    /// ****** Important ****************
    /// 
    /// Interfaces are more like contract. 
    /// Interface define a "has a" relationship.
    /// Pin class has a color property, pin class has a layer property.
    /// 
    /// A regular class to class inheritance signifies "is a" relationship.
    /// Remeber that student, sportsStudent classes?
    /// 
    /// SportsStudent "is a" student. This is the most natural way of understanding it right?
    /// We will not say SportStudent has a student.
    /// 
    /// Class level inheritance -- Has a 
    /// Interface type of inheritance -- is a 
    /// ------------------------------------------------------------------------------------------------

    public interface IColor
    {
        public int ColorId { get; set; }

        public void ApplyColor(int colorID);
    }

    public interface ILayer
    {
        public int LayerId { get; set; }

        public void SetLayer(int layerID);

        public bool HideFromLayer();
    }

    public interface ILocation
    {
        public string LocationInfo { get; }

        public void SetLocation(double x, double y);
    }

    public class Piin : IColor, ILayer, ILocation
    {
        int IColor.ColorId
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        int ILayer.LayerId
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        string ILocation.LocationInfo => throw new NotImplementedException();

        void IColor.ApplyColor(int colorID)
        {
            throw new NotImplementedException();
        }

        // Explain the use of public and private access modifier here.
        // This method will not be visible outside.
        bool ILayer.HideFromLayer() // Explicit implementation
        {
            throw new NotImplementedException();
        }

        // This method will be visible, because it is public
        public void SetLayer(int layerID) //Implicit implementation
        {
            throw new NotImplementedException();
        }

        void ILocation.SetLocation(double x, double y)
        {
            throw new NotImplementedException();
        }
    }


    public class Node : IColor
    {
        int IColor.ColorId
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        void IColor.ApplyColor(int colorID)
        {
            throw new NotImplementedException();
        }
    }

    public class ExampleInterface
    {

        public static void Method_1()
        {
            // Similar to how a derived class can be converted into base class,
            // a class which implements interfaces, can be converted into those interfaces.

            // You can define a method to take interfaces as parameters and that method
            // should be able to accept all the class objects that implement that interface.
            // Is it a bit confusing?

            // This is similar to how a derived class object can be passed wherever a base class obj 
            // can be passed.
            //
            // If it is still confusing, don't worry. I will explain during the discussion.


            Piin piinObj = new Piin();
            piinObj.SetLayer(40); // Only set layer is visible

            Node nodeObj = new Node();

            ChangeColorOfTheItem(nodeObj);
            ChangeColorOfTheItem(piinObj);

            // Uncomment next line and understand why this error appears.
            // MethodTakesOnlyILayer(nodeObj); 
            MethodTakesOnlyILayer(piinObj);
        }

        public static void ChangeColorOfTheItem(IColor colorObj)
        {
            colorObj.ColorId = 50;
        }

        public static void MethodTakesOnlyILayer(ILayer layerObj)
        {
            // not doing anything here
        }
    }


    /// In C# versions earlier than 8.0, an interface is like an abstract base class 
    /// with only abstract members. A class or struct that implements the interface 
    /// must implement all its members.
    /// 
    /// Beginning with C# 8.0, an interface may define default implementations for some 
    /// or all of its members. A class or struct that implements the interface doesn't 
    /// have to implement members that have default implementations.
    /// 
    /// An interface can't be instantiated directly. Its members are implemented by any 
    /// class or struct that implements the interface.
    ///
    /// Link: https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/types/interfaces
    /// Link: https://stackoverflow.com/questions/747517/interfaces-vs-abstract-classes
    /// 
    ///
    /// *************** Abstract classes can have interfaces implemented on them *********
    ///  Example: 
    ///   
    ///  public interface ISendEmail
    ///  {
    ///  
    ///     public bool SendEmailToAdmin(string email){};
    /// 
    ///  }
    ///     
    ///  public abstract class ExecutionReport: ISendEmail
    ///  {
    ///     public abstract void CompileExeRunReport(){};
    ///     
    ///     public abstract bool SendEmailToAdmin(string email){};
    ///  }
    ///  
    /// We created an Email interface and that is included in the abstract class, so when someone
    /// inherits the abstract class, they need to override all the methods from the abstract class,
    /// which includes the method from interface as well.
    /// 
    /// Now based on need, some other classes can also implement the Email interface and decide their
    /// own way of implementing it.
    /// 
    ///
    /// Can you try to find out if interface and abstract can contain constructors?
    /// I am not sure.. Probably they don't. Or one of them might allow and the other wont.
    /// 
    /// In interviews if somebody asks difficult question, you can say that you haven't tried that, 
    /// so you are not able to answer that question. Nothing wrong in that.
    /// 
    /// This is why you need to be sure of certain things, so that when questions are asked from your comfort
    /// area, and if you give clear cut answers, then they would not bother much about the areas you are not 
    /// aware of. They would know that you would pick up other things well based on your confidence.
}
