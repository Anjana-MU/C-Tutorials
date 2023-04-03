using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal static class Loops
    {

        public static void Continue_explanation()
        {
            int[] num_array = new int[] {  1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> non_skipped_list = new List<int>();

            foreach (var item in num_array)
            {
                if (item > 3 && item < 7)
                {
                    continue;
                }
                else
                {
                    non_skipped_list.Add(item);
                }
            }

            // Items not skipped in the previous loop.
            foreach (var item in non_skipped_list)
            {
                Console.WriteLine(item.ToString()+'\n');
            }
        
            // Continue will just ignore the below steps and continue the loop again from the start.

            // If there are nested for/ for each loops, then if you have any continue statement present,
            // then only the loop within which the continue statement is present will be looped.
            // That is, it affects only the loop in which it is present.

        }

        public static void Break_explanation_1()
        {
            int[] num_array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> non_skipped_list = new List<int>();

            foreach (var item in num_array)
            {
                if (item > 3 && item < 7)
                {
                    break;
                }
                else
                {
                    non_skipped_list.Add(item);
                }
            }

            // Items not skipped in the previous loop.
            foreach (var item in non_skipped_list)
            {
                Console.WriteLine(item.ToString() + '\n');
            }
            
            // Break statement will make the execution exit the loop, whereas continue will make the execution.
            // continue within the loop while ignoring the statements below the continue line.

        }

        public static void Break_explanantion_2()
        {

            int[] num_array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] string_nums = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            List<string> non_skipped_list = new List<string>();

            // Try to identify what break 1 and break 2 are doing.
            foreach (var item in num_array)
            {
                if (item > 3 && item < 7)
                {
                    break; // break 1
                }
                else
                {
                    foreach (var item2 in string_nums)
                    {
                        if (item2 == "four")
                        {
                            break; // break 2
                        }

                        non_skipped_list.Add(item.ToString() + " " + item2.ToString());
                    }
                }

            }

            // Items not skipped in the previous loop.
            foreach (var item in non_skipped_list)
            {
                Console.WriteLine(item.ToString() + '\n');
            }

            // **************************** Learning  *************************
            // Break statement will always transfer the execution flow out of the loop in which they are present,
            // but they will only transfer the execution out of the current loop .

            // If you want the execution to stop from every single loop then every for or foreach loop needs to
            // have a break statement based on the condition.

            // Here break 1 is for the first for loop and break 2 for the second one.
        }


    }
}
