using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Methods
    {

        // Methods just contain sequence of statement to accomplish a task.

        // Methods can be without parameters.
        private static void PrintSomeInformation()
        {
            Console.WriteLine("I don't take any information, but I will say bleh when called");
            Console.WriteLine("\n Also I don't return any value, my return type is void, just like my life");
        }


        // Methods can take parameters but not return anything.
        private static void CreateLogFileInTempFolder(string fileLocation)
        {
            Console.WriteLine("\n I can just create a log file based on the file location");

            // ****** It is always a good practice to return value from the method, at least a success or failure state.
            // This can be done using True or False, or 0 or 1.
            // Most programs when executed successfully, they will return the code 0.
            // Run any of the methods in this project and check for this "(process 40708) exited with code 0." in the console.
        }

        // Method with a success or failure response.
        private static bool ValidateInput(List<string> inputList)
        {

            /// Say we are processing a text file as input and if all the data is present then we 
            /// will return True, otherwise False.

            // Here if we know that the input needs to be 100lines and we can use the return statement
            // to say whether there was enough input or not.
            return inputList.Count == 100;

            /// The above statement is a simplified version of
            /// if(inputlist.count==100)
            /// {return True;}
            /// else
            /// {return False;}
        }

        // Method can take value types as direct values or by reference.
        // By now you would be knowing the difference between value type and reference type.

        /// <summary>
        /// This method changes the value of B, changes the value of studentObj based on some condition
        /// Returns the sum of a and b
        /// </summary>
        /// <param name="a">Number, we dont change its value</param>
        /// <param name="b">Number, we will change its value</param>
        /// <param name="studentObj">Based on some condition, its value will be altered</param>
        /// <returns></returns>
        private static int AddAsWellAsModify(int a, ref int b, SimpleStudent studentObj)
        {

            b = 20; 
            // B is passed as a reference variable, so modifying it here will change it
            // outside of the method as well.
            // Probably you're tired of me telling about this again and again !!!!!

            int c = a + b;

            if (studentObj.FirstName == "Anjana")
            {
                studentObj.LastName = "Good girl";
                // Here we are modifying the last name based on some condition.
                // We know that class objects are reference variables.
                // So if the control come inside this loop, then the original object will get changed as well
                // i.e., the actual object value will get changed outside of the method too.
            }


            return c;

            // A method shouldn't modify too many things, also there is no relation between the addition
            // operation we did and the name changing operation, but I just clubbed everything together
            // just to explain stuff.

            // You attended the good coding practice session, so you would be knowing all that.
        }

        private static string UseOfReturnInMethod(List<int> integerList)
        {
            // If a method has a return type (int in this case), then the method also needs to have a return statement.
            // 
            // The return statement essentially terminates the execution of the code and returns the value 
            // to the calling method (i.e from where the current method is being called).
            //
            // A method can any number of return statements, whichever is hit first, the method will stop there and 
            // the value which is written next to the return statement will be returned.

            // ************* Example A *************

            foreach (var item in integerList)
            {
                if (item == 32)
                { return "Success"; } // if this is true, execution will not go below this.

                if (item == 45)
                { return "Failure"; } // if this is true, execution will not go below this.
            }

            return "Nothing Happened";
            // Here based on condition 32 and 45 different value will be returned,  if both of
            // them are not met then "Nothing happened" will be returned.

            // ************* Example B *************
            string status = "";
            // If you move the mouse over "string", it will say unreachable code detected, this is because there is
            // a return statement above this line, and that return statement is not within any condition. So it is pretty 
            // sure the return statment will get executed and the method will end, so Visual studio is alerting us that 
            // this part of the code will never get executed, then why are are you writing it like an idiot antha.
            // 
            // But we are just doing an example scenario, so it is fine.


            // Break statements are used to move the control out of the current loop the execution is in.
            foreach (var item in integerList)
            {
                if (item == 32)
                {
                    status = "Success";
                    break;
                }

                if (item == 45)
                {
                    status = "Failure";
                    break;
                }
            }


            if (status == "")
            { return "Nothing Happened"; }
            else
            { return status; }

            // The above four lines can be shortened into return status==""? "Nothing Happened": status;
            // This is called a ternary operator, if the condition is true,then the first position variable is returned,
            // otherwise the second position variable is returned.


            // ******************** Learning ***********************
            // Return statement directly exists the method.
            // It is not advisable to have too many return statements within a method.
            // Instead you can use break statements to control the execution and use one return statement.

            // An interview question could be, what's the difference between break and return statement.
            // Could you put it in your own words about the difference betweent them?

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="studentObj"></param>
        /// <param name="anotherStudentObj">This method modifies the value of this variable internally</param>
        private static void WaysOfReturnigValuesFromMethod(int a, ref int b, SimpleStudent studentObj, ref SimpleStudent anotherStudentObj)
        {
            /// This method in itself does not have any return value  but this method can modify the 
            /// value of b (second parameter), since it is a value parameter but passed as a reference

            /// This method has the power to modify the actual varaibles studentObj as well as anotherStudentObj
            /// because both of them are of the reference type.
            /// 
            /// But if you are going to modify a referece object within a method, then you can use the ref keyword explicitly so that
            /// anyone reading the method will understand that the variable is going to be modified within the code.
            /// 
            /// You can also write it in method description about your intention to change the value of that reference variable.
            /// To write in method description, place the cursor on a line above the method description and press '/' thrice.
            

            a = a + 5; // actual value outside the method does not get changed.

            b = b + 20; // actual value outside the method WILL get changed.

            studentObj.FirstName = "GoodBoy";
            // Here the actual value is changed, but someone just looking at the method signature might not know if the studentObj is
            // just being used inside the method to read the values inside the object or the object itself is being modified.

            anotherStudentObj.FirstName = "Muffin";
            // Here also the actual object is being changed, but in the method signature itself we have written that it is being
            // passed as a reference.
            //
            // This could help the user to understand that, ok, this is being passed as ref, so probably the value is being 
            // changed within the method.

            /// Here we just used the method arguments itself to return the modified values within the method.
            /// Lets see other ways in the methods below.
        }


        private static int SumOnlyNumbersAboveTen(List<int> intList)
        {
            int sum = 0;
            foreach (var item in intList)
            {
                if (item > 10)
                { sum += item; }
            }

            return sum;

            // This is a very simple case where we are not modifying any of the input parameters.
            // The value is calculated and returned via the return statement.
        }

        private static List<int> GetEverySecondItem(List<int> intList)
        {
            List<int> list = new List<int>();

            bool condition = true;
            foreach (var item in intList)
            {
                // Lets see if you are able to understand this logic.
                //
                // I want only the second items from the input list to be returned
                // [0,1,2,3,4,5,6] -- from this I want only 1,3,5.
                // can you check if the below logic is correct ?
                // This is not what I wanted to teach, but just trying to get you to understand the logic.
                if (!condition)
                {
                    list.Add(item);
                }
                condition = !condition;
            }

            return list;
            // Not only simple values like int and string, you can also return lists via the method return types.
            // You might know this already, but I am building things one by one.
        }

        private static void GetMaximumAndMinimumValueOfList(List<int> intList, out int minVal, out int maxVal)
        {
            // I know you don't have to write a method to do this simple thing, because they are simple one line calls,
            // but this method is to illustrate the use of 'out' parameters.

            // Important Note: Whenever you use out paraemter, they need to be initialised within the method.
            // It is similar to whenever a method has a return value, then the method will expect you to type
            // a return statemetn with the appropriate data type.
            minVal = 0;
            maxVal = 0;

            // Unlike return statements where you need to type "return 2", out parameters does not need you to 
            // type anythine explicitly. This is one of the reasons why the compiler will expect you to declare
            // the output parameters values as soon as you write a method with out parameters in them.

            // Up until now in this method, the minVal and maxVal will be zero, and if we don't do anything 
            // i.e., if we don't update those variables with any other value then 0/whichever we set them with
            // will be returned to the method that is calling them.

            minVal = intList.Min();
            maxVal = intList.Max();

            // Now whatever the Min and Max values are present in the list, that will be assigned to those out parameters.


            // Lets see how this method would actually be called, when a method has out parameters, and you
            // want to call that method, you need to have the out parameters declared even before calling them.
            // Let me describe that in the next method.
        }

        public static void MethodToCallAMethodWithOutParameters()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            int minVal, maxVal;

            GetMaximumAndMinimumValueOfList(nums, out minVal, out maxVal);

            // So we need the minVal and maxVal parameters to be declared even before they need to be passed into the method.
            // Remember, its enough if you declare them, no need to initialise it, because anyway inside the 
            // method we will assign a value to those variables.

            // Normally, "out" parameters are used when you want to output more than one variable.
            // If the out parameters are of the same type, then you could think that why don't I put them together on a list 
            // and return it via the "Return keyword" and have that as my method's return type...... Good question..
            // .. but having out parameters will help you have meaningful names for those parameters, and anybody 
            // reading that will be able to understand what you are trying to return.
        }


        public static int ReturnSumOfItems(List<int> nums)
        {
            // This method sums up all the elements of the list.
            return nums.Sum();
        }

        public static int ReturnSumOfItems(List<int> nums, int numOfItemsToSum)
        {
            // This method sums up only until the specified number of items of the list.
            // The number of items to sum up is mentioned in the numOfItemsToSum.
            return nums.GetRange(0, numOfItemsToSum).Sum();
        }

        private static void MethodOverloading()
        {
            /// The above two methods have the same method names, but depending on the number
            /// of arguments you pass to the method, different method will be called.
            /// 
            /// This is called method overloading.

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            int sumOfAllElements = ReturnSumOfItems(nums); // Sums up all the elements in the list.

            int sumOfFirstThreeElements = ReturnSumOfItems(nums, 3); // Sums up only the first three elements.

            /// If you are given too much work what would you call it as?
            /// You would say you are being overloded, correct?
            /// Here, we are expecting a single method name to do too many things, basically we
            ///  are overloading it with too much responsibilty.


            /// *********************** Important *************************
            /// Compiler will understand which method to call based on the number of arguments you pass.
            /// In method overloading, you cannot have exactly two methods taking in the same type of parameters.
            /// i.e, same method name, same number of arguments, same type of arguments in the same order.
            /// All these four (name, type, number of args, order) cannot exist together between 2 methods.
            /// 
            /// You can same number of arguments, but the type(int, float, obj) can differ.
            /// Basically you need to let the compiler understand that the methods are different from one another,
            ///  and not to leave it confused with methods all looking the same.

            /// *********************** Very Important *************************
            /// Method overloading is also called compile-time polymorphism.
            /// 
            /// As you know polymorphism means same thing existing in different forms, like your dad being your dad, 
            /// HoD, Anu's husband. The method exists in two forms in our example.
            /// If you have created ten different versions of the method, then it is 10 differnt forms.
            /// So we understood the polymorphism part of compile-time polymorphism.
            /// 
            /// Lets look at the "compile-time" part.
            /// The compiler at the time of compilaton (when you press shift+ctrl+B) or click Build->build soulution,
            /// tries to decide which method to call out of the different versions that exist for the same method name.
            /// For our ReturnSumOfItems method we have two forms, so the compiler will decide based on the number of 
            /// arguments we passed, which would be the appropriate method to call.
            /// 
            /// If we have passed both the list and the number of items to sum, then it will call the second 
            /// version of the method. i.e., ReturnSumOfItems(nums, 3) <--- if this is what is supplied.
            /// 
            /// The compiler at the time of compilation (i.e., while creating exe or dll) will make the executable
            /// such that the correct method is called while executing the exe file.
            /// This is called compile-time polymorphism.
            /// 
            /// This is a commonly asked interview question--- as most interviewrs would have been asked this question
            /// they would want to pass on this legacy to the people whom they want to interview as well.
            /// 
            /// **************** very Important *********************
            /// Another most asked question is what is run time polymorphism,
            /// or you will be asked the difference between run time and compile time polymorphism.
            /// I will explain run time polymorphism under classes section.
            /// 
            /// method OVERRIDING is also called as RUN TIME POLYMORPHISM.
            /// Are you reading correctly that I am saying method overriding and not overloaing?
            /// 
            /// method overLOADING -> Compile time polymorphism.
            /// method OVERRIDING -> Run time polymorphism.
            /// 
            /// There is something called operator Overloading.
            /// I will explaing it in some other part, but just know it also exists, don't be scared, it is a simple concept,
            /// but this is not the right place to explain that.
            /// 
            /// Overloading means compile time polymorphism.
            /// 
            /// if my explanation for compile time polymorphism is not easy to understand, try googling it, 
            /// it is a very important concept.
        }

    }
}
