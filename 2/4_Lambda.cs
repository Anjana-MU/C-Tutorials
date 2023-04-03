using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Lambda
    {
        /// This is a very short information about Lambda operators.
        /// Just to give you an idea of what it is when asked in interviews.
        /// 
        /// You use a lambda expression to create an anonymous function. 
        /// Use the lambda declaration operator => to separate the lambda's 
        /// parameter list from its body. 
        /// A lambda expression can be of any of the following two forms:
        ///
        /// Instead of creating a method, if you feel that the functionality
        /// can be done in a single line, then lambda expressions can be used.
        /// 
        /// It has no clear advantage over methods, you can use methods also.
        /// Instead of writing methods explicitly with all those syntaxes, you
        /// can just lambda expression if it is a simple task.. Ashte.
        /// 
        /// Example: 
        /// Func<int, int> square = x => x * x;
        /// Console.WriteLine(square(5));
        /// 
        /// Link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions
        /// Read this contents of the link when you have time.
        ///


        /// Another important concept is TERNARY operator
        /// ?: operator ( it is mentioned in this format)
        /// 
        /// It just mimics a simple If--Else statement
        /// 
        /// Syntax:
        /// var somevar = (condition) ? (if condition is true, store this value) : (else, store this value)
        /// 
        /// Example:
        /// int bool = (5>4) ? true: false;
        /// 
        /// Here 5 is > than 4, so the value in the bool variable will be true.
        /// 
        /// Example:
        /// 
        /// List<int> nums = (some condition) ? new List<int>(){1,2,3} : new List<int>() {10,20,30}
        /// 
        /// Gave this example so that you understand the different scenarios in which you can use this.
        /// 
        /// The information you need to remember is that, ternary operator is a simple if..else loop.
        /// You are free to use the regular If..Else loop itself, but if you can do it elegantly in
        /// one line iteslf then go with ternanry operator.

    }
}
