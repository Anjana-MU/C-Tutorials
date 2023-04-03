using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class TryCatchThrow
    {

        /// **************** Learning *****************
        /// This is a potential interview topic, also an important programming concept.
        /// You could get questions like when do you use Try Catch?
        /// When do you use Throw?
        /// 
        /// TryCatchThrow is a 3 part system - Try, Catch and Throw
        /// Try and Catch will always appear in pair, and Throw is optional/
        /// You will understand it in the examples below.
        /// 
        /// Try Catch is normally used when you expect some error to happen during the
        /// execution of the code.
        /// 
        /// Based on whether you want to stop the execution of the code or keep continuing
        /// you can use the Throw option.
        /// 
        /// Enough of abstract discussion, lets jump into the examples.


        public static void TryCatchMethod()
        {

            int a = 10;
            int b = 0;


            /// Here we are trying to divide a by b, but we are not sure if the operation will be
            /// successful..in that case you can put the entire operation within the try-catch block.
            /// 
            /// The try block should normally contain the block of code you want to execute.
            /// The catch block would capture if something goes wrong.
            /// 
            /// Imagine the try block synonymous with a vessel in which you are trying to mix two chemicals.
            /// If something goes wrong then the chemical will contain within the vessel itself right?
            /// You would ideally choose a vessel which would withstand the effect of the chemical.
            /// The Try block does exactly that, if it feels that the code execution stopped or explodes with 
            /// error then it would simply pass the control to the catch block.
           

            /// In the below code we have used only one exception, ideally for one try block you can use as
            /// many catch blocks as possible. 
            /// 
            /// But the error will be captured by only one of the exception blocks, within the braces against
            /// the catch statement we need to write which exception we are expecting to catch.
            /// 
            /// More on this in the next example, for now remember that catch block should be present in 
            /// conjuction with try block.

            // Math : we can zero by any number and the answer will be 0 (0/2 = 0, 0/100 =0).
            // But we cannot divide a number by 0, that is an error ( 9/0 = error, 100/0 = error).

            // 1 - No error in the execution
            try
            {
                Console.WriteLine("*********** Method 1 ***********");
                Console.WriteLine("\n Lets try to divide 0 by 10 ");
                int c = b/a;

                Console.WriteLine("\n Successful operation : Answer is C: " + c);

                // If all the code within try block executes fine, then the control will  directly go
                // outside of the catch block.Catch block will only be called if the execution
                // faces error in try block.
                //
                // This is more like if else loop, if the if condition is satisified, then the control
                // will not go to the else part.. try catch is also like that.
                //
                // You would know about if ().. else if()...else if()...else()
                // try..catch(exception1 a).. catch(exception2 b).. catch(exception3 c)..
                // Just like if..elseif..elseif and a default else block, we can have multiple try catch blocks
                // It is always advisable to use the catch(Exception ex) at the end if you are using multiple
                // catch statements.
            }
            catch (Exception ex)
            {
                // If the try block fails, then we will be in this section and the ex variable will
                // contain the details of the error.
                Console.WriteLine("\n The operation to divide a by b failed  :( " + "\n" + ex.Message + "\n" + ex.InnerException);
            }


            // 2 - Error while dividing but not catching the error information.
            try
            {
                Console.WriteLine("\n ********** Method 2 ********* \n");
                Console.WriteLine(" Lets try to divide 10 by 0 ");
                int c = a / b;

                // Here we are trying 0 by 10.
                // We cannot divide 0 by anything, so definitely this will fail.
            }
            catch (Exception)
            {
                // We can just write exception within the catch block and not declare a variable.
                // If we declare a variable, then it can be used to store the error we encountered.

                Console.WriteLine("\n Error when tried to divide 0 by 10");
                Console.WriteLine(" We just used a simple catch block");
            }

            // 3 - Error while dividing but Catching the error information.
            try
            {
                Console.WriteLine("\n ********* Method 3 *********** \n");
                Console.WriteLine(" Lets try to divide 10 by 0");
                int c = a / b;

                // Here we are trying 0 by 10.
                // We cannot divide 0 by anything, so definitely this will fail.
            }
            catch (Exception ex)
            {
                // The variable ex is used to capture the error being reported.

                Console.WriteLine("\n Error when tried to divide 0 by 10");
                Console.WriteLine(" Error :" + ex.Message);
            }

            // 4 - Using two catch block to capture error.
            // When two catch block is used the catch blocks will be checked from top to bottom.
            // Whichever is the appropriate block that catch block will be used, we know that
            // we will get DivideByZero exception, so that block will be used here.
            try
            {
                Console.WriteLine("\n ********** Method 4 ************ \n");
                Console.WriteLine(" Lets try to divide 10 by 0 ");
                int c = a / b;

                // Here we are trying 0 by 10.
                // We cannot divide 0 by anything, so definitely this will fail.
            }
            catch (DivideByZeroException mathExp)
            {
                // Since DivideByZeroException is the proper exception, the control will come here
                // and only this block will get executed.
                Console.WriteLine("\n Inside the DivideByZeroException Block");
                Console.WriteLine(" Error :" + mathExp.Message);
            }
            catch (Exception ex)
            {
                // The control will not come to this block.
                Console.WriteLine("\n Error when tried to divide 0 by 10");
                Console.WriteLine(" Error :" + ex.Message);
            }

            // 5 - Using two catch block to capture error.
            // Focus on the catch blocks, we are deliberately making an out of index exception.
            // But we are using "DivideByZeroException" and "Exception" catch blocks.
            try
            {
                Console.WriteLine("\n ************ Method 5 ************* \n");
                Console.WriteLine(" Trying to access an element outside of the array size ");
                int[] nums = new int[1];

                int c = nums[2];

                // This should fail.
            }
            catch (DivideByZeroException mathExp)
            {
                // This block should not get executed as this is not the correct exception type.
                Console.WriteLine("\n Inside the DivideByZeroException Block");
                Console.WriteLine(" Error :" + mathExp.Message);
            }
            catch (Exception ex)
            {
                // ************* Very Important ***************
                // The control will  come to this block.
                // Why does it come here though?
                // Because Exception is the most basic form of exception.
                // Do you remember system.object being the most basic object?
                // Exception is the equivalent of system.object amongst all exceptions
                // So if you don't know what kind of exception to expect, you can blindly use Exception.
                // 
                // It is wise to use know exceptions first and put the default Exception at the end,
                // so that you know if the other catch blocks fail, then the default exception block
                // would get called at least.
                Console.WriteLine("\n I am not sure what exception to capture");
                Console.WriteLine("   So I used a simple Exception at the end to save my code");
                Console.WriteLine(" Error :" + ex.Message);
            }


            /// 6 - What if we keep the simple Exception block at the start and the specialised
            /// exceptions after that.. What do you think?
            try
            {
                Console.WriteLine("\n ************ Method 6 ************* \n");
                Console.WriteLine(" Trying to access an element outside of the array size ");
                int[] nums = new int[1];

                int c = nums[2];

                // This should fail.
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n The general exception has gotten executed instead of the special case");
                // Try uncommenting the below catch block and read the error
                // Does it help you to understand?

                // Ok let me explain..
                // You see, Exception is the very basic exception.. the mother of all exceptions,
                // all other special cases of exceptions are built using this.
                // So if you use this simple Exception at the begining and other types of exceptions
                // below this, then those blocks will never get executed.
                //
                // The simplest Exception (the basic one) will get executed and it will be over..
                // That's why you use the special exceptions to capture the errors you think that could
                // happen, if none of your guessed errors are captured and you still think that ther could
                // be some unexpected error that could happen then use that simple exception case at the end.
            }
            //catch (IndexOutOfRangeException mathExp)
            //{
                // This block should not get executed as this is not the correct exception type.
               // Console.WriteLine("\n Inside the DivideByZeroException Block");
                //Console.WriteLine(" Error :" + mathExp.Message);
            //}
            
           
            // 7 - What happens if no default exception is used.
            // For this example we are using a 'Key Doesn't Exist' type of error.
            // But we will use only the following two exception blocks.
            // "DivideByZeroException" and "IndexOutOfRangeException"
            try
            {
                Console.WriteLine("\n ************* Method 7 ************ \n");
                Console.WriteLine(" Trying to access a key that doesn't exist in dictionary ");
                Dictionary<int, string> numberAndName = new Dictionary<int, string>();

                string name = numberAndName[2];
                // We didn't even store any value in the dictionary, so definitely this should fail.

                // If this try block does not fail then your computer is definitely broken throw it
                // out of the window and eat Oreos.

                // So basically none of the exception we use are going to capture the error, so the 
                // entire application will fail.
                // When you run this method ( the method inside which we are explaining the try catch exercise)
                // the console will throw error and tell you what happened.

                // This is the reason why we keep a default Exception block at the end, to capture the
                // uncaptured exception.
            }
            catch (DivideByZeroException mathExp)
            {
                // This block will not be reached.
            }
            catch (IndexOutOfRangeException indexExp)
            {
                // This block will alo not be reached.
            }


            // ******** Learning *******
            // If we don't know which Exception block to use then better use Exception to capture error.
            //
            // If you want to use few Exceptions then, use them at the begining and use the
            // general Exception at the end.
            //
            // If you use the simple Exception at the beginning and the special cases of exceptions
            // like OutOfIndexException and all, then the simplest Exception block would get executed
            // as that is the mother of all exceptions and you have used it at the begining itself
            // so none of the special exception blocks would be considered after that.
        }


        public static void ThingsToDoInCatchMethod()
        {

            /// There is another important function of catch block than to just capture exceptions.
            /// We are using catch blocks because we are expecting some error to happen.
            /// There are certain cases where we would have done some operations but when some 
            /// error happens, we need to undo something we were doing, or we need to make sure
            /// that we end the program safely.
            /// 
            /// Real life example: Imagine you are cooking in kitchen, suddenly you hear a loud sound
            /// coming from the streets, do you panic and run or you turn off the stove and run?
            /// You would want to turn off the stove right? 
            /// Similar to that we need to do some cleaning process in our code.
            /// Lets see examples

            StreamReader sr = null;
            
            try
            {
                // We are trying to open a file and read the contents from it.
                // using stream reader we can read the files line by line.
                
                // This would be an error because I actually don't have a file at the location
                // but assume that we have a file in the location and we are reading contents from it.
                
                sr = new StreamReader("TestFile.txt");

                string content = sr.ReadLine();

                // Lets say I am trying to access the character at the 58th location but there is no data there
                // so this could throw IndexOutOfRange exception.

                // Now the control would go to the exception block, but notice that the program is linked
                // to the file we opened, the program will crash and the file will be open in memory.
                // Due to this the computer won't let you access the file until you clear the memory
                // (this is why sometimes you would restart the computer, because some applications would be
                // holding the file in memory, so we need to restart the computer to clear all that memory leakage).

                char c = content[57];


                // So, the use of catch block is to clean up any mess that may lie around due to the execution 
                // of block of code before the error occured.

                // If everything goes according to plan ( sadly, life and programs are not that simple), then we
                // will reach this part and the stream reader would be closed here and we won't even enter the 
                // catch block.. but what if we don't reach this part????? say.. sayyyy

                // That's why we will put the sr.close() in catch block too.

                sr.Close();
            }
            catch (Exception)
            {
                // if any error occurs before we close the stream reader in the try block, then we can use the 
                // catch block to close the file.
                
                sr.Close(); 
                
            }
        
            // So catch block not only to catch the exceptions but also to clean up the stuff due to the program failure.
            // Some common cleanups would be - Disconnecting the database connection.
            // Closing any opened files.
            // pushing information about the error to the log file and closing the file.
            // This could be a very important interview question.
        
        }


        public static void TryCatchThrowExample()
        {

            /// Lets see when will use the throw option


            /// A regular Try Catch block will contain the throw option as well when you use the 
            /// double tab option of creating the try catch block.
            /// Type just "try" and press tab twice (quickly).

            try
            {

            }
            catch (Exception ex)
            {

                // Throw statement here(after comments) is used to throw errors. 
                // It is a bit confusing isn't it.. especially what does it mean throwing error.
                // Normally catch block is used to capture the exception and used to do the cleanup activities.

                // Scenario 1 -  Lets say we are reading a file and we face some error while reading the file and we 
                // want to stop reading the file and inform the user that file reading failed and want to ask the
                // user to supply a new file...so we just catch the error and discard the error and inform the
                // user and just wait for him/her to give a new file.

                // Scenario 2 -  Lets say you are processing a graphic item and suddenly you are faced with an 
                // error in the application and it has reached your basic Exception block at the end, do you
                // remember you always use the basic Exception at the end when the common expected exceptions
                // are not met and you just wanted to capture the error.
                //
                // In this case you don't know why the error occured and how to undo things or even communicate
                // to the user of your application what they should do.
                // So you just publish the error using ex.innerexception and stop the execution of the application itself.

                // So how do we stop the execution? Thats why we use throw.
                // You see the below throw (throw;) it would just break the execution and end the process and the 
                // application would stop working.

                throw;

                // Lets see a better throw.
                // This would throw a message as well to the method which called the current method in which we are.
                throw new Exception("Lets end the application here, I don't know what happened");

                // Do you recognise that all the exceptions we get are actually being throw by some other method internally.
                // That is the usefulness of throwing exceptions, so that the method which gets the exception can decide if the
                // error is important enough to stop the execution or we can manage the error and keep the execution going.
                //
                // If we get a file read error then we can process the error and ask the user to reload a different file,
                // but if we face error during graphic generation, then we would want to stop the program itself.
                //
                // So it is the not the error itself that tells us to stop the execution, based on the error the programmers
                // can decide whether to stop the execution or alter the program's execution.

                // Throw also enables us to throw some exceptions as well.

                throw new Exception("Error due to Pin Generation", new OutOfMemoryException());


                // Similar to IndexOutOfRangeException, OutOfMemoryException we can create (Derive) custom exceptions
                // and use them as well, these exceptions could be specific to our project, similar to the different
                // classes we created for our application.


                // We are inside the TryCatchThrowExample method, if this method is being called from another method
                // and we are throwing the exception from this method, if these exceptions are not being captured
                // using the Catch blocks, then the application would terminate... is that clear?
                // Any exception that is not being captured will terminate the program.

                // Whenever you link the application and Visual studio, if there is an exception, do you notice
                // that the control would come back to the visual studio and it would point you to the location
                // where the exception occured, also at the botttom of the screen in VS it will show the exception.

                // This is why exceptions are helpful and why you need to create try catch blocks as well as return
                // meaningful exceptions if any error happens in your code.


                // I know it is too much bla bla dry theory.
                // And I am also a bit tired of including any examples for the Throw part, because it can only be
                // done by stopping the execution of the application.
            }


            // Now we are outside the try catch block.
            // Throw can also be kept outside of the try catch block, i.e., it could exist on its own.


            int a = 10;
            int b = 40;

            // Lets say after lot of processing you find the age of father to be 10 and the age of son to be 40.
            // Obviously the father's age cannot be more than that of the son's!
            // Now you're thinking that your application is perfectly fine, because you have tested it thoroughly,
            // so you are one hundered percent sure that it is due to the error in the input supplied by the user

            // Also, technically it is not an error, like an array error or memory error or even dictionary error.
            // It is an error due to a real life thing, program-wise it is fine, but not logic-wise.
            // And also you want throw error and stop the execution or just want to throw error to the method
            // that is calling this method.
            //
            // Lets just do that

            if (b >= a)
            {
                // We can throw exception from any part of the code.
                // Throw does not have to be in the catch block all the time.
                //
                // Normally it is put inside catch block so that we do some clean-up activity
                // and then throw error to the calling method.

                throw new Exception("Age related error, probably due to input error");
            }

            // The above error will be returned to the calliing method and that method can decide to exit the application.


        }
    }
}

