using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    /// Lets look at what abstract classes are
    /// Before that lets try to understand the word "Abstract" itself
    /// 
    /// Definition of Abstract  - existing in thought or as an idea 
    /// but not having a physical or concrete existence.
    /// 
    /// Lets take the example of the concept of religion:
    /// What is a religion? A belief system, a system with a holy book,
    /// a system with god/gods
    /// 
    /// If you ask somebody they will say that they either believe in religion or not.
    /// So it is just an idea... When does this idea materialise? or when
    /// does this become concrete? when does it come into existence?
    /// 
    /// Nobody will just say they just believe in religion, they will also
    /// mention the religion they believe in.. Christianity, Islam, Buddhism etc
    /// 
    /// Now these Islam, Buddhism.. these are the concerete items, actual religions
    /// and not just idea... So the concept of religion is an abstract concpet
    /// the actual thing is the practice people follow according to their own religion
    /// Religion---> Abstract idea
    /// Hinduism, Islam --> Actual religions that implement the religious ideas in their own way
    /// 
    /// Lets discuss an idea from the generator project itself
    /// We have many graphic items like Pin, Pad, Surface.. all of these are 
    /// the things which we can see on the screen.
    /// But all of these come under the concept/idea of graphics.
    /// You cannot just see a graphics, you will always associate some name to
    /// the graphics you see,...such as pin, pad, surface. 
    /// 
    /// So, a graphic item will have location, size and layer 
    /// 
    /// The concept of graphic is the abstract idea here.
    /// The pin, pad and surface are the concrete implementations, i.e. Graphic objects.


    /// Now why so much lecture about the concept of abstract?
    /// C# lets us to inherit one class from another.
    /// In our previous example we inherited from student class and then that class
    /// was further inherited by another class.
    /// 
    /// Lets go back to our pin, pad, and surface example, all these classes have some 
    /// common behaviour, which can be mentioned as a behaviour of a graphic item,
    /// namely: having position info, color info and layer info
    /// 
    /// But can you just create a graphic? a graphic on its own doesn't exist..
    /// beacuse it is just an idea... but its behaviour is represented by actual graphic items
    /// 
    ///             *********************************** 
    /// In such cases we will create an abstract class and call it as "Graphic".
    /// If you declare a class as abstract, it cannot be instanitated, i.e., no objects can be
    /// created...marking a class as abstract means, it is being used as an reference idea, 
    /// so that we can use this class to derive other classes.
    /// 
    /// In an abstract class we cannot have any concrete declaration, that is you can just 
    /// declare method declarations not define the content of it, abstract classes can have
    /// fields, properties and methods.. not sure about constructors though.. need to check
    /// 
    /// It is the onus of the deriving/inheriting class to implement the methods and functionalities
    /// 
    /// Link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract

    public abstract class Graphic
    {
        // whenever you declare a property or method as abstract it 
        // NEEDS to be overriden in the derived class


        // I guess override keyword is not allowed for fields,
        // I tried writing "protected override int" but it showed error
        // So probably that is not allowed
        
        // Fields
        protected int layer;
        protected int iD;

        // Properties
        public abstract int Layer { get; }
        public abstract int ID { get; }

        // Methods
        public abstract void Draw();

        public abstract void Info();
        public abstract void Move(int x, int y);

    }

    public class Pin : Graphic
    {

        ///  Since we are implementing the abstract class
        ///  we need to give a concrete implementation for those
        ///  two properties and three methods
        public override int Layer
        {
            get
            {
                // Notice the lowercase layer, this corresponds to the 
                // field in the base class...remember fields couldn't be marked as
                // abstract, so we could access them directly
                return layer;
            }
        }

        public override int ID
        {
            get
            {
                // Same case as above
                return iD;
            }
        }

        public Pin(int id, int layer)
        {
            // We create constructor and then assign the fields variable in the
            // abstract class
            base.iD = id;
            base.layer = layer;
        }

        public override void Draw()
        {
            /// The way pin is drawn will be different, here we are just giving 
            /// out console message mentioning that the actual operation is happening
            /// 
            /// In Generator tool, we were creating Pen and then drawing items, remember?
            /// Imagine that operation is being carried out here... but we are just printing message
            Console.WriteLine(" We are doing the calculation to do draw Pin");
            Console.WriteLine(" We are drawing the Pin graphic using the appropriate method");
        }

        public override void Info()
        {
            Console.WriteLine(" This is a pin class");
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine(" We are translating the pin");
        }

        public void SomePinRelatedMethod()
        { 
        }
    }

    public class Surface : Graphic
    {

        /// Similar to Pin class, we are generating the Surface class implementing
        /// the Graphic class

        public override int Layer
        { get { return layer; } }

        public override int ID
        { get { return iD; } }

        public Surface(int id, int layer)
        {
            // We create constructor and then assign the fields variable in the
            // abstract class
            base.iD = id;
            base.layer = layer;
        }

        public override void Draw()
        {
            Console.WriteLine(" We are doing the calculation to do draw Surface");
        }

        public override void Info()
        {
            Console.WriteLine(" This is a Surface class");
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine(" We are translating the Surface");
        }

        public void CustomMethodForSurfaceClass()
        { 
        
        }

    }

    public static class AbstractExample
    {

        public static void Method_1()
        {
            Pin pinObj = new Pin(3, 4);

            Surface surfObj = new Surface(4, 30);

            /// Since, both, Pin as well as Surface are derived from Graphic class
            /// both of these class objects can be converted into Graphic class object,
            /// even though graphic itself is an abstract class
            

            Graphic grph = (Graphic)surfObj;
            grph.Draw();
            // there should be only one print message and it should come from this method


            /// Now we are converting the Graphic object back to surface object
            /// this will work, you might wonder why... because the "grph" object itself
            /// was created using a surface object right, check the above conversion
            /// .. so it will work
            Surface surface_2 = (Surface)grph;
            surface_2.Move(2, 2);


            /// This part will not work.. the "grph" object was created using a surface object
            /// now if you try to convert the Graph object into a Pin object, it will cause issue
            
            // Once you have run the above part of the code, uncomment this part and check the error 
            // after that comment it again...

            // Pin pin_2 = (Pin)grph;
            // pin_2.Draw();

            /// ************* Important *****************
            /// Whenever you derive a class from a base class, be it a concrete class (a real instantiatable 
            /// class) or an abstract clas.... the derived class can always be converted into the base class
            /// And the derived class objects (pin object, surface object, etc.) can be passed into the 
            /// methods that are accepting the base classes ( method_1(Graphic grphObj)
            /// 
            /// Whichever method is expecting a Graphic object, both Pin and Surface object 
            /// can be passed instead of that graphic object and it will work just fine.
            /// 

            /// **************** info ***************
            /// Abstract method will just give you idea, like what the variable names need to be
            /// what the method name needs to be and stuff, you cannot have any definition (write the
            /// actual content of the method). Declaration means declaring the method name or property name, 
            /// definition means, giving the implementation part of it..
            /// 
            /// So abstraction lets you give declarations not definitions and it will force the user to
            /// give the implementation part whenever they derive from the abstract class
            /// 
            /// The virtual method will have definition as well, as in, it is a concrete method, it can be
            /// overridden if needed, that's the difference between Abstract and Virtual methods

        }

    }
}
