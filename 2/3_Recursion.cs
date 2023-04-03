
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Recursion
    {
        /// Recursion is a particular type of method which calls itself.
        /// Recursion is synonymous with the word Recurring.. i.e. happening again and again.

        /// There are certain cases in which the given task can be accomplished by calling the
        /// same method over and over again.


        /// Lets take the example of finding the factorial of a number.
        /// 
        /// Factorial means a number will be followed by exclamation mark
        /// Ex: 5! is 5 factorial
        /// ex: 3! is 3 factorial
        /// What it means is 5! = 5 * 4 * 3 * 2 * 1
        /// 3! = 3 * 2 * 1
        /// 
        /// Lets create a method to calculate the factorial of any given number.


        private static int Factorial(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("\n ********* Reached the termination conditon !!! *********");
                return 1; 
            }
            else
            {
                Console.WriteLine("We will now do Factorial("+n+")");
                return n * Factorial(n - 1); 
            }
            // Here we are internally called the same method, 
            // but we are calling the method with a reduced value
            // If we call the same method within that method, it is called Recursive call

        }

        /// Lets see what will happen when we do Factorial(3).
        /// Step 1: (n==1) check will fail, so return 3 * factorial(2) will be called.
        /// step 2: (n==1) check will fail, so return 1 * factorial(1) will be called.
        /// step 3: n==1 check will pass, so 1 will be returned.
        /// so in total-> 3* factorial(2)-> 3* 2* factorial(1)-> 3* 2* 1
        /// will be done in the background.

        /// As you might have noticed if the numbers are large and the loop has too many operations,
        /// then keeping track of the flow of execution will be difficult to follow.
        /// 
        /// Also, the conditon if(n==1) return 1 is called the termination condition.
        /// This TERMINATION CONDITION is an important concept in recursion.
        /// If there is no termination condition the looping will keep happening.
        /// 
        /// All recursion MUST have Termination condition, otherwise it will result
        /// in Stack Overflow error (Don't tell me that you dont know what is stack overflow error please!!).

        ///----------------- Learning ____________________
        /// Avoid doing recursion if possible as it is a bit complicated to understand and keep track of the 
        /// flow of loops and variables.
        /// 
        /// If you go forward with recursion, make sure there is a termination condition.
        /// If there is no termination condition, then we will end up with stack overflow error.
        ///
        /// All the current execution variables will be kept in the memory of stack and  calling the 
        /// same method too many times will create lot of variables and we will run out of memory, 
        /// this is called stack overflow error.


        /// Run the below method to get a understanding of how many times the recursion method is called.
        public static void LetsRunRecursion()
        {
            Factorial(100);
        }

    }
}
