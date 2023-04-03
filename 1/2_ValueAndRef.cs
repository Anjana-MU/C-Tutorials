using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal static class ValueAndRef
    {
        // ------------- Definition -------------------------------
        // Both value and ref (reference) types store values in them.

        // Value types send a copy of the values inside methods.
        // Reference types send the reference of the value (i.e., it will just send
        // the address of the location where the value is stored).
        //
        // Value type will send only values.
        // Reference type will send only reference(address) of the value.
        //
        // If a candidate is attending an interview based on somebody's reference, then
        // we will know that he is linked to somebody right? Similarly, when an item is 
        // a reference variable, it will always carry the link of its memory location.

        // Value type: It is like taking a photo of the value type and sending it inside a method.
        // Somebody taking a photo of you and drawing something on your forehead will not affect you in real, right?
        // It is similar to that.

        // In case of reference type, the address of the value is passed into the method,
        // so if the variable is changed inside a method, then the actual value will also get changed.
        // So you need to be very careful while passing reference variables inside methods,
        // whenever a reference variable is passed inside a method, make sure you are not modifying it inside the method.

        // I have included some examples below to explain these points.

        public static void ValueTypes()
        { 
            // Below are value types

            int a_1 = 1;  // and other types of integer, int, sbyte, byte, uint, long
            float a_2 = 2.3f; // and other types of floating points like double, decimal
            bool bool_variable = false;
            char letter = 'a';
            // Along with these Structs and Enumerations are also considered as value types.
            // Structs and Enumerations will be explained in different file.

            //------------- Trick to remember ------------------------------
            // so remember numbers, characters, structures, Enumerations are value types.
            // As mentioned above imagine these are more like photographs, that is when you 
            // photograph something and draw over them, you are modifying the original object.

            // Imagine your CSE photo in instagram, C- for character, S- for Structure, E- for Enumeration
            // and the number of people in the pic corresponds to the numerical value, which is again a value type.


            //*********************  Experiment -A  *****************************
            // part -1 -- We are checking the value before passing the values inside the method.
            Console.WriteLine(" ******* When value types are passed directly the original values will NOT be changed *****");
            Console.WriteLine("\n Value types when passed inside a method ");

            Console.WriteLine("\n\n Original values before passing into method");
            Console.WriteLine(" Value of number : "+a_1);
            Console.WriteLine(" Value of bool :"+bool_variable);

            // part -2 -- Passing the values inside the method and trying to modify the values.
            ModifyValueTypes(a_1, bool_variable);

            // part -3 -- We are checking the value after getting them out of the method.
            Console.WriteLine("\n Checking the values after they come out of the method ");

            Console.WriteLine("\n\n Rechecking the original values");
            Console.WriteLine(" Value of number : " + a_1);
            Console.WriteLine(" Value of bool :" + bool_variable);
            Console.WriteLine("\n Check if the original values are changed or not");

            //*********************  Experiment -B  *****************************
            // part -1 -- We are checking the value before passing the values inside the method.
            Console.WriteLine("\n\n ******* When value types are passed as reference the original values WILL BE CHANGED *****");
            Console.WriteLine("\n Value types when passed inside a method ");

            Console.WriteLine("\n\n Original values before passing into method");
            Console.WriteLine(" Value of number : " + a_1);
            Console.WriteLine(" Value of bool :" + bool_variable);

            // part -2 -- Passing the values inside the method and trying to modify the values.
            ModifyValueTypesByRef(ref a_1, ref bool_variable);

            // part -3 -- We are checking the value after getting them out of the method.
            Console.WriteLine("\n Checking the values after they come out of the method ");

            Console.WriteLine("\n\n Rechecking the original values");
            Console.WriteLine(" Value of number : " + a_1);
            Console.WriteLine(" Value of bool :" + bool_variable);
            Console.WriteLine("\n Check if the original values are changed or not");


            //**************** Learning **********************
            // When value types are passed directly the original variable will remain unaffected.
            // If you need the value type variables to be affected outside the method also,
            // then pass the value as ref.
            // Example method definition : ModifyValueTypesByRef( ref int  num, ref bool someBool)
            // call the method as : ModifyValueTypesByRef(ref a_1, ref bool_variable);

            // Remember "Numerous CSE student" (your college pic) photo to quickly remember, Numbers,
            // Character, Struct and Enumerations. These are the value types.
            //
            // Also, as you can see, the value types don't take too much memory.
            // Value types are usually stored on Stack ( more on this later).

            // Ref link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#value-types
        }

        public static void RefTypes()
        {
            // Below are reference types.
            
            SimpleClass class_obj = new SimpleClass(5); // I created a dummy class, just to create an object here
            
            IEnumerable<int> int_obj; // This is an interface ( i will cover this in a seperate file)
            
            string str = " Original string";

            // Along with these, delegates are also considered as reference type.
            // Any item you create using the "new" keyword is an object, because you are 
            // basically creating an object when you use the new keyword, and so
            // Class objects are reference types.
            //
            // Example: list<int> num_list = new List<int>();
            // Example: float[] num_array = new float[3];
            // Example: Dictionary<string,string> string_dic = new Dictionary<string,string>();
            // All the above items are also considered as collections, it collects and stores items together.
            // So all lists, arrays, dictionaries are considered as reference type.

            // ------------- Focus on the reason ---------------
            // As you can see all the value types were simple items, like numbers and character and struct
            // (struct is used to store related items together and they are usually simple).

            // All the reference types occupy bigger memory, like lits, class objects (a class can contain lot of things),
            // so it makes sense to just pass the address of the these variables instead of making copy every copy every single time.
            // You would realise that making a copy of big item will increase the computation time, so it is easier to pass a 
            // reference ( reference actually means a reference to the address/location of the actual value).

            //------------- Trick to remember ------------------------------
            // Easiest way is, anything apart from the value types ( N-CSE example from above) are reference types.
            // A trick for reference type could be the acronym "C-iOS".
            // You can remember it as C-iOS ( Cellphone runs on iOS).
            // Your apple iphone runs on iOS (Other phone runs on Android), i for interface, O for Object ,
            // S for string, and the C stands for Collections.
            //
            // N-CSE for value types, C-iOS for reference types.


            string my_name = "Anjana M U";
            List<int> num_list = new List<int> { 1, 2, 3, 4, 5 };

            //*********************  Experiment -A  *****************************
            // part -1 -- We are checking the value before passing the values inside the method.
            Console.WriteLine(" ******* When REFEREBCE types are passed directly the original values will BE changed *****");
            Console.WriteLine("\n Value reference when passed inside a method ");

            Console.WriteLine("\n\n Original values before passing into method");
            Console.WriteLine(" Value of string : " + my_name);
            Console.WriteLine(" Value of list :" + string.Join(", ", num_list));

            // part -2 -- Passing the values inside the method and trying to modify the values.
            ModifyReferenceTypes(my_name, num_list);

            // part -3 -- We are checking the value after getting them out of the method.
            Console.WriteLine("\n Checking the values after they come out of the method ");


            Console.WriteLine("\n\n Original values after passing into method");
            Console.WriteLine(" Value of string : " + my_name);
            Console.WriteLine(" Value of list :" + string.Join(", ", num_list));
            Console.WriteLine("\n Check if the original values are changed or not");
            Console.WriteLine("\n Note that we did not use pass by reference ( Ref keyword) in the method signature");
            Console.WriteLine("\n When you pass a reference variable, even if you pass it without ref keyword,they will get altered");



            //**************** Learning **********************
            // When reference types are passed directly the original variable will get changed everywhere.
            // If they are altered within any method they get passed into.
            
            // If you are deliberately changing the value of a reference value inside a method, then write
            // in comments within the method about your intention and the reason why you're changing.
            
            // Trick to remember some reference types quickly is - C-iOS (Cellphone on IOS).
            // Collection, Interface, Object, String.

            // Ref link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
        }

        public static void CopyingValueTypes()
        {
            int a = 10;
            int b = a;

            Console.WriteLine("\n We create two variables a and b");
            Console.WriteLine("\n We assign the value of a to b (i.e a=b)");
            Console.WriteLine("\n Value of a : "+a+" and b: "+b);
            Console.WriteLine("\n We change the value of a and check if it has impacted b");
            a = 5;
            Console.WriteLine("\n Now we modify the value of a to 5 and see if it has changed the value of b");
            Console.WriteLine("\n Value of a : " + a + " and b: " + b);

            // ------ Learning --------
            // As you might have noticed in the execution, merely assigning one variable to another and modifying
            // the second variable is not affecting the original variable. Why does this happen?
            //
            // Because we dealt with Value type, whenever value type is copied/assigned to another variable,
            // a complete copy is made, and reference to the original value is destroyed.

            // This happens only with VALUE type.

            // Lets see what happens with reference type in the next method.
        }

        public static void CopyingRefTypes()
        {
            SimpleClass obj_a = new SimpleClass(5);
            SimpleClass obj_b = obj_a;


            Console.WriteLine("\n We create two objects obj_a and obj_b");
            Console.WriteLine("\n We assign the value of obj_a to obj_b (i.e obj_b=obj_a)");
            Console.WriteLine("\n Val_A in Object A is "+obj_a.Val_A );
            Console.WriteLine("\n Val_A in Object B is " + obj_b.Val_A);
            Console.WriteLine("\n We change the value of Val_A parameter of object A and check if it has impacted object B");
            
            obj_a.Val_A = 20;
            Console.WriteLine("\n Val_A of object A is  : " + obj_a.Val_A);
            Console.WriteLine("\n Val_A of object B is  : " + obj_b.Val_A);

            Console.WriteLine("\n Notice that even though we only changed the Val A parameter of object A, it has modified the object B value as well");

            //------- Learning ------
            // When we deal with reference objects, mere assigning of one object to another will not create two seperate copies.
            // Here, both object A and Object B refer to the same memory internally.
            // So, modifying one will alter the other.
            // Be very careful when you assign a reference variable, if you accidentally modify one then it will affect the original data as well.

            // We will see more about how to create a new copy ( deep copy) when we deal with classes and lists, array.
            // For now realise that assigning a reference object to a new varaible DOES NOT create a new copy.
        }

        private static void ModifyValueTypes(int num, bool someBool)
        {
            num = num + 1;
            someBool = !someBool;
            Console.WriteLine("\n Now we are inside modify value type method");
            Console.WriteLine(" The values types are directly passed (i.e., NOT passed as reference)");
            Console.WriteLine("\n Value of number inside method : "+num);
            Console.WriteLine(" Value of bool inside method : " + someBool);
        }

        private static void ModifyValueTypesByRef( ref int  num, ref bool someBool)
        {
            num = num + 1;
            someBool = !someBool;
            Console.WriteLine("\n Now we are inside modify value type BY REF method");
            Console.WriteLine(" The values types are passed as reference ");
            Console.WriteLine("\n Value of number inside method : " + num);
            Console.WriteLine(" Value of bool inside method : " + someBool);
        }

        private static void ModifyReferenceTypes(string name, List<int> num_list)
        {
            name = name.Replace("U", "Uppin");

            for (int i = 0; i < num_list.Count; i++)
            {
                num_list[i] = num_list[i] + 10;
            }

            Console.WriteLine("\n Now we are inside Modify Reference type method");
            Console.WriteLine("\n Value of variables after modifying inside the mehod");
            Console.WriteLine("\n Name : "+name);
            Console.WriteLine("\n Numbers : "+ string.Join(", ", num_list));
        }
    }

    internal class SimpleClass
    {
        int a;

        public int Val_A { get {return this.a;} set { this.a = value; } }
        public SimpleClass(int a)
        { 
            this.a = a;
        }
    }
}
