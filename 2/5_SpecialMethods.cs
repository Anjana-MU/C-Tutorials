using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class SpecialMethods
    {
        /// We will look at two types of methods, namely
        /// 
        /// 1) Named Parameters method.
        /// 2) Optional parameters method.
        /// 
        /// ***************** Important ******************
        /// A parameter is a variable in a method definition.
        /// 
        /// When a method is called, the arguments are the data you pass into the method's parameters.
        /// Parameter is variable  in the declaration of function. 
        /// Argument is the actual value of this variable that gets passed to function.

        /// ----------------Some info from the web----------------
        /// 
        /// C# 4 introduced named and optional arguments. 
        /// Named arguments enable you to specify an argument for a parameter  by matching the argument
        /// with its name rather than with its position in the parameter list.
        /// 
        /// Optional arguments enable you to omit arguments for some parameters.
        /// Both techniques can be used with methods, indexers, constructors, and delegates.

        private static void NamedParameterMethod_1(int num, string name, string school)
        {
            Console.WriteLine("\n Num: " + num + " | Name: " + name + " | School: " + school);
        }

        public static void CallNamedMethod()
        {
            Console.WriteLine("\n Named parameter passing helps us to pass arguments" +
                                " by specifying the parameter names");
            Console.WriteLine("\n We are calling a method which is mentioned in the order num, name and school");
            Console.WriteLine("\n But we are not passing in the exact order, " +
                                "but we have mentioned the parameter name correctly");

            /// We are not following the order of the method parameters.
            /// But all the arguments are passed with proper parameter names.
            /// This will help the compiler to map the values correctly.
            NamedParameterMethod_1(name: " Winnie", num: 50, school: " Glen's Bakery");

            Console.WriteLine("\n Did you notice how the printing was perfect inspite of the order mismatch");

            /// When is this helpful?
            /// If a method is accepting too many numerical inputs or even string input, then while calling 
            /// the method if you explicitly type in the values along with the name of the parameter, it would
            /// be helpful for someone reading your code or even for yourself in the future, to get an 
            /// understanding what each value actually mean.
            /// 
            /// Example: AnalyseStudent(name:"Anjana",Maths:85,Science:78,DaysAbsent:23);
            /// 
            /// Compare the above method call without the parameter names
            /// 
            /// AnalyseStudent("Anjana",85,78,23); 
            /// 
            /// Here you would think that 23 is also some subject's mark.
            /// 
            /// So Named parameter frees the user from typing the values in exact sequence and also enables
            /// the reader to understand it more clearly.
            /// 
            /// ************************** Important **********************
            /// It is not necessary that all the parameters need to be passed with their names. You can only pass
            /// few with names and the others in regular manner. However, there are certain rules you need to follow
            /// if you plan on combining named and regular way of calling.
            /// 
            /// Ex: AnalyseStudent(name:"Anjana",Maths:87,67,23) // this is what I mean combined way.
            /// 
            /// I am not going to explain the rules you need to follow if you go for mixed way, I will leave the 
            /// link for you to read that.
            /// 
            /// My advice is, either use all the names or just call like regular method, because the rules for combined
            /// calling is a bit messy, also the reader of the code will not understand if things are mixed up.
            /// 
            /// Even in the interview if they ask about this, you can say, I will either use all the named parameters or
            /// directly call using regular way, otherwise it will become a bit confusing for me.
            /// There is nothing wrong in saying that. Many programmers won't use certain features because it is quite confusing.
            /// 
            /// I hope Named parameters is a bit clear for you now.
            /// Link: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        }


        /// *************** Optional Parameters ************************
        /// 
        /// The definition of a method, constructor, indexer, or delegate can specify its parameters are required or optional.
        /// Any call must provide arguments for all required parameters, but can omit arguments for optional parameters.
        ///
        /// Each optional parameter has a default value as part of its definition.
        /// If no argument is sent for that parameter, the default value is used.

        private static void OptionalParameterMethod(int age, string sex = "Neutral", string name = "UnNamed")
        {
            // If the users are not specifying the values for Sex and Name then the values metioned against
            // the parameter list will be used.
            Console.WriteLine("Name : " + name + "\n" + "Sex : " + sex + "\n" + " Age : " + age);
        }

        public static void CallOptionalParametersMethod()
        {

            /// Lets call the optional parameter method without both optional values.
            Console.WriteLine("\n Called the optional parameter method without the optional values");
            OptionalParameterMethod(25);

            /// Now call the method with only age and sex (i.e., leave out the last parameter).
            Console.WriteLine("\n Called the optional parameter method without the last value");
            OptionalParameterMethod(25, "Female");
            /// Notice the difference between this method call and the one in the next line.

            /// Now call the method with only age and name (i.e., leave out the second parameter).
            Console.WriteLine("\n Called the optional parameter method without the sex value");
            // OptionalParameterMethod(25, "Anjana"); <-- this would make the program think we are 
            // passing the value for sex, instead of name.

            OptionalParameterMethod(25, name: "Anjana");
            // We are only passing two parameters, but you want the method to understand that the second parameter
            // you have supplied is name and not sex, so you use the named parameter concept to alert the compiler.

            /// **************** Learning ****************
            /// Optional parameters lets you to set some default values for method calls. It is advisable to keep
            /// the optional parameters at the end, and the essential parameters at the begining.
            /// 
            /// If you are planning on skipping some optional parameter and using only some of them, then use the 
            /// named parameter concept to eliminate the ambiguity.
            /// 
            /// The link I provided for the Named parameter contains the description for optional parameters as well.
        }

    }
}
