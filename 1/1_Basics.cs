using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal static class Basics_1
    {
        public static void DataTypeBySizes()
        {
            // ************** Data types to store non decimal / integers **************

            // For just storing numbers, integers the following data types are used
            // Increasing order from left to right

            // -------------------> sbyte < short < int < long

            // If you want to store only positive integers then you can use unsigned data type
            // Unsigned data type mean, no sign, that is no negative sign will be stored in the data
            // this allows you to store one extra BIT value, so the memory capacity increases

            // -------------------> byte < ushort < unit < ulong

            // sbyte can store numbers from (-128 to 127), but byte can store from ( 0 to 255)
            // (Notice the range increase on one side)
            // No need to memorise the range, it is just to highlight how to capacity changes.

            // Similarly all the unsigned data type can store more values on the postivie side,
            // but they can store only positive values, that is the information you need to remember

            // Also remember the order of increasing capacity for storage among the data types

            // ************** Data types to store decimal (floating point) numbers **************  

            // As per my search I could not find any seperate data type similar to integres, where
            // we could store the positive values alone seperately. (like, a data type to just store
            // 3.45, and not -3.45), seems like all floating point datatypes store both + and - values.

            // The increasing order of storage capacity for floating points

            // -------------------> float < double < decimal

            // whenever we declare a float variable we will end it with f ( example float pi = 3.14f )
            // but for double we don't have to declare like that ( double weight = 34.56)

            // Decimal has the highest precision, but the processing time is higher for that..
            // because it stores numbers with the base 10, instead of binary format like other variables

            // *********************** Study link ********************************
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types

        }

        public static void Precision_issues()
        {
            int a = 9*101; // 909
            int b = 9*100; // 900

            bool int_bool = a > b;// this should be true as `a` is greater

            float f1 = 0.09f * 100f; // same as multiplying 0.09*100
            float f2 = 0.09f * 99.999999f; // same as multiplying 0.09*99.99
            // So ideally f1 should be greater than f2, because f1 will be 9 and f2 will be 8.991

            bool float_bool = f1 > f2; // this should also be true as f1 is greater
            
            Console.WriteLine(" Precision_issues \n\n");

            Console.WriteLine(" Is integer a greater? "+int_bool); 

            Console.WriteLine("\n\n Is float f1 greater? " + float_bool);
            Console.WriteLine(" f1 value : "+f1);
            Console.WriteLine(" f2 value : " + f2);
            // Note that when the system prints out these values, both will be the same, but we know from actual calculation that
            // they both should be different



            // ****************** LEARNING ***********************

            // As you would have noticed in the results, float f1 is not considered to be greater because
            // the computer calculation with respect to floating points or double values are less precise

            // After a calculation if you expect two floating point variables ( a and b) to have values as 10.35 and 10.35,
            // don't directly try to use (10.35 == 10.35), because due to the calculation mistake, one variable could be having the 
            // value 10.350001 and the other one would be 10.35000. To avoid this subtract both variables and check if the difference 
            // between them is very less ( this is normally called as epsilon or threshold)

            // Example : if a is expected to be 10 rupees 50 paise ( a = 10.50), and b is also expected to be b= 10.50,
            // but due to floating point issue a is 10.4999999 paise and b is 10.50 paise, then you can just check if the difference is
            // less than one paise ( because you are thinking that I am okay to have a one paisa difference between them)
            // (b-a <0.01), here the 0.01 is the one paisa you wanted to check, this is called as epsilon or tolerance or threshold
            // if that condition is satisfied then you assume that those two values are reasonably close, or the difference does not
            // bother you.

            // When you want numbers that has decimal places and need the calculations to be precise then better use DECIMAL data type,
            // but be aware that if you're doing lot of caluclations using decimal data type, then your application might become slow.
        }
    }
}
