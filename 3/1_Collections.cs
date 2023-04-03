using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Collections
    {

        private static void Array_Information()
        {
            // Arrays are used to store to data of similar type together.
            // Arrays are fixed type, that is, you need to inform at the time of 
            // declaration itself about the many elements you are going to store in them.

            // You can resize the array later if you want to store more elements, but
            // if you are going to keep resizing an array then you could just use a list instead.
            // Because list will keep expanding as more and more elements are added to it.

            // Below are the different ways in which you can declare an array.

            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];
            // [0, 0, 0 ]  -- row 1 contains 3 elements.
            // [0, 0, 0 ]  -- row 2 contains 3 elements.
            // This is how the elements are stored.

            // Declare and set array element values.
            int[,] twoDimArray = { { 1, 2, 3 }, { 4, 5, 6 } };
            // [1, 2, 3 ]  -- row 1 contains 3 elements 
            // [4, 5, 6 ]  -- row 2 contains 3 elements
            // If you want to access the number 6 then you would use int val = twoDimArray[1,2]
            // twoDimArray[rowIndex, colIndex],
            // twoDimArray[1- corresponds to the second row,2- corresponds to the third column].

            // In the above 2 dimensional array, you saw that every row has equal number of items.
            // If you want an array where the number of items in each row needs to differ, then use jagged array.

            // Declare a jagged array.
            int[][] jaggedArray = new int[3][]; // Here we have declared 3 row array,
            // each row needs to be initialised seperately to fix their size.

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[2] { 8, 7 };
            jaggedArray[2] = new int[3] { 4, 5, 6 };
            // [1, 2, 3, 4 ]  -- row 1 contains 4 elements 
            // [8, 7 ]         -- row 2 contains 2 elements
            // [4, 5, 6 ]     -- row 3 contains 3 elements

            // If possible, avoid using jagged arrays, as it is more confusing.

        }

        public static void Array_size_methods()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            int len_ofarray = numbers.Length; // Gets the number of items in a one dimensional array

            int rank = numbers.Rank; // This gives the dimension of the array

            Console.WriteLine("\n One dimensional array : " + string.Join(", ", numbers));
            Console.WriteLine("\n length : " + len_ofarray + ", rank : " + rank);


            int[,] twoDimArray = { { 1, 2, 3 }, { 4, 5, 6 } };

            len_ofarray = twoDimArray.Length;
            rank = twoDimArray.Rank; // Here we should get the dimension as 2, since it is a 2D array

            Console.WriteLine("\n Two dimensional array : " + "{ 1, 2, 3 }, { 4, 5, 6 } ");
            Console.WriteLine("\n length : " + len_ofarray + ", rank : " + rank);

            //Once we know the rank, we can cycle through each row and get the data

            Console.WriteLine(" We will go through the number of items in each dimension");
            Console.WriteLine(" since the number of items will be the same in each row, " +
                                "as it is a proper 2D array, the values will be the same");

            for (int i = 0; i < rank; i++)
            {
                Console.WriteLine("Number of items in dimension " + (i + 1) 
                                        + " = " + twoDimArray.GetLength(i));
            }

            // Another way of getting the dimension of array
            int[,] array2D = new int[5, 10];
            Console.WriteLine("\n\n Dimension of a 2D array : " + " int[,] array2D = new int[5, 10] ");
            Console.WriteLine(" Row Dimension : " + array2D.GetLength(0));
            Console.WriteLine(" Column Dimension : " + array2D.GetLength(1));


            // Using the methods like GetUpperBound and GetLowerBound also gives similar results,
            // but stick with these methods instead.
        }

        public static void Array_methods()
        {
            int[] num = new int[] { 180, 21, 34, 4, 50 };

            Console.WriteLine("\n Reversing an array without modifying the original list");
            Console.WriteLine("\n The actual num array : " + string.Join(", ", num));

            // Here we are reversing the list and printing
            var sorted_list = num.Reverse();

            Console.WriteLine("\n The actual num array after reversing : " + string.Join(", ", num));

            Console.WriteLine("\n The reversed list : " + string.Join(", ", sorted_list));

            Console.WriteLine("\n Did you notice that the original array remains unaltered?");


            // -- Learning--
            // If you move your mouse over the num.Reverse() method it would say that it is returning a new list,
            // which means the original list is not being modified.

            Console.WriteLine(" ***********************************************");
            Console.WriteLine("\n Reversing an array WHILE MODIFYING the original list");
            Console.WriteLine("\n The actual num array : " + string.Join(", ", num));
            Array.Reverse(num); // notice that you are using Array class here, previous example had num.Reverse, 
            // we were using a method on the array we created in the previous example.
            // In this example, we are using the c# array class to work on our array.

            Console.WriteLine("\n The actual num array after reversing using Array.Reverse method: " + string.Join(", ", num));
            Console.WriteLine("\n The Array.Reverse method does not return anything, rather it modifies the orginal list");
            Console.WriteLine(" This is why the return value is null for Array.Reverse() method");

            //--- Learning ---
            // Whenever you use a method from an object, make sure if the method is creating anything new or 
            // trying to modify your actual object.

            // Many methods on String class will actually work on the actual object insted of creating a new string object.
            // The same goes for arrays, lists, dictionaries as well. 
            // Focus on the return method of a method, if the method is not returning anything, then probably it is
            // modifying the objects we supply into the method.
            // If you are confused, google the method and see what it does.
            // Example: read about Array.Sort() method.

        }

        internal static void List_Information()
        {
            // lists are basically array that does not have a size limit.
            // Similar to arrays, Lists are also used to store only similar type of items.

            // Lists can also be initialised with a size, say create a list with size 10,
            // but mostly people just create an empty list and keep adding items to it.

            // By default list will get created with a fixed size, and as more and more items get added to it,
            // it doubles in size to accomodate more items... go through the below example.

            // Lets start with array example and expand it to the lists.
            // Say you create an array of size 4 - > [ 0 | 0 | 0 | 0 ]
            // By default four spaces are created, now after 4 elements you can't store any more items in it.

            // Now you are creating an empty list. 
            // By default it would create a fixed size ( assume a size of 4 for now)
            // list<int> num_list = new list<int>() -- > [0 | 0 | 0 | 0] ( lists use array in the background to store items)
            // let's say you keep adding items to the list
            // num_list.add(1),
            // num_list.add(3),
            // num_list.add(6),
            // num_list.add(13) ( I have added four items now)
            //
            // When I try to add a new element, the background array size will not be enough
            // so the program will resize the array and double its size
            // the array will become [ 1 | 3 | 6 | 13 | 0 | 0 | 0 | 0 ] <--- now the size has become 8
            // once you fill all these 8 places, then the size will become 16 and so on

            List<int> nums = new List<int>();
            Console.WriteLine("\n We are creating a list and setting the capacity to 4");
            nums.Capacity = 4; // Here we can set the size of the list

            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);

            Console.WriteLine("\n Capacity of the list after adding 4 items : " + nums.Capacity);

            // Now we have reached the maximum capacity
            nums.Add(5);
            Console.WriteLine("\n Capacity of the list after adding 5 items : " + nums.Capacity);
            Console.WriteLine("\n Did you notice the doubling of the capactity");



            // ------ Learning -------------
            // So essentially lists are nothing but automatically expandable arrays.
            // If you use arrays then you should know the total size at the initialization stage itself.
            // In list you don't have to know the complete size information.
            // But since the list keeps resizing as the size grows larger, the resizing operation will cost time.
            // So, it is advisable to use array when you know the size, otherwise use list.
        }

        internal static void List_methods()
        {

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("\n Lets print a simple list : " + string.Join(", ", nums));

            // Lets reverse the list
            nums.Reverse(); // Notice that I am not assigning it to any other variable.
            // Also, if you check the method, it will return void, which means, it is
            // modifying the actual list itself and not creating a new list.

            Console.WriteLine("\n list after reversing : " + string.Join(", ", nums));
            Console.WriteLine("\n Here the actual list itself is modified, no new list is created");
            // Similar to the method we saw for array, we should also check if we are creating a new list or
            // modifying the original list itself.

            List<int> list = new List<int>() { 1, 2, 3 };

            nums.Add(5); // this method will add an item to the list

            nums.AddRange(list); // this method will add a list itself to the end of the original list

            // We have Array class in C#, which contains methods related to arrays, but there isn't a class specific to List.
            // The methods associated with the lists can be accessed by creating a list object and calling the methods on them.
            // Example: nums.Reverse()
        }

        internal static void List_Array_Conversion()
        {
            //  Since Lists and Arrays are closely related to each other,
            //  One can be converted into another with much ease.

            // I have listed few methods with which you can convert lists into array and vice-versa
            int[] array_nums = new int[] { 1, 2, 3, 4 };

            List<int> nums = new List<int>(array_nums);

            List<int> nums_new = array_nums.ToList();

            int[] new_array = nums.ToArray();

            //---- Learning -------
            // Lists and Arrays are collections.
            // Dictionary is also a collection.
            // So whenever you have a collection, C# will most probably will have methods to convert from one type to another.
            // If in doubt google your question, you will be able to find the answer

            // In a seperate file we will dictionary, where I will explain about how you can create list using dictionary.
        }

        internal static void Array_Copy_for_value_types()
        {
            // Arrays and Lists can be copied in two ways, shallow and deep copy.
            // All reference items (remember arrays and lists are reference types) needs to be deep copied if you
            // don't want to alter the original item.

            // Shallow copy - imagine you and your friend sharing a book on the desk and studying,
            // if one of them writes something on the book then it affects both of your reading as both of 
            // you are sharing the same book.. this is shallow copy (ā very crude example)

            // Deep Copy - Imagine you and your friend take a photocopy (xerox) of the book,
            // then even if your friend modifies her book, your book would be intact.
            // This is the example for deep copy, where you are making seperate copies.
            // So the original content will not get altered.

            // For now, lets just see how to copy lists and arrays, other reference objects we will see later.


            // ------------------Let us first see about shallow copy
            int[] nums = new int[] { 1, 2, 3, 4, 5 };
            int[] nums_copy = nums;
            var nums_clone = nums.Clone(); // this is method to clone the array provided by C#

            Console.WriteLine(" ******** Shallow copy ****************");
            Console.WriteLine("\n We created an array called nums : " + string.Join(", ", nums));
            Console.WriteLine("\n Assign it to a new variable called nums_copy");
            Console.WriteLine("\n Values in the copied array : " + string.Join(", ", nums_copy));
            Console.WriteLine("\n Lets change the original array first item value to 10  ");
            nums[0] = 10;

            Console.WriteLine("\n value of nums array :" + string.Join(", ", nums));
            Console.WriteLine("\n value of nums_copy array :" + string.Join(", ", nums_copy));
            Console.WriteLine("\n value of nums_clone array :" + string.Join(", ", nums_clone));
            Console.WriteLine("\n Due to shallow copy all the three arrays are getting changed, even if one is altered");
            // You might have noticed that both the arrays are modified, this is shallow copy.
            // Both the arrays are pointing to the same array in the background.
            // Array.Clone() only creates a shallow copy (could be an interview question).

            Console.WriteLine(" ******** Deep copy ****************");
            int[] original_array = new int[] { 1, 2, 3, 4, 5 };

            // first method of creating a deep copy
            int[] new_array_1 = new int[original_array.Length];//  Create another array of same size

            for (int i = 0; i < new_array_1.Length; i++)
            {
                new_array_1[i] = original_array[i]; // Assign the values individualy, you can see that the individual.
                // Items are value types, whenever you assign value types new objects are created,
                // reference to the object is not copied.
            }

            // second method of creating a deep copy
            int[] new_array_2 = new int[original_array.Length];
            Array.Copy(original_array, new_array_2, original_array.Length);

            Console.WriteLine("\n We created an array called original_array : " + string.Join(", ", original_array));
            Console.WriteLine("\n Created another array of same size of the first array and named it as new_array_1");
            Console.WriteLine("\n Similarly new_array_2 is created using a different technique");
            Console.WriteLine("\n Values in the new array_1 : " + string.Join(", ", new_array_1));
            Console.WriteLine("\n Values in the new array_2 : " + string.Join(", ", new_array_2));
            Console.WriteLine("\n Lets change the original array first item value to 10  ");
            original_array[0] = 10;

            Console.WriteLine("\n value of original_array array :" + string.Join(", ", original_array));
            Console.WriteLine("\n value of new array_1 :" + string.Join(", ", new_array_1));
            Console.WriteLine("\n value of new array_2 :" + string.Join(", ", new_array_2));
            Console.WriteLine("\n Due to shallow copy all the three arrays are getting changed, even if one is altered");


            // **************** Learning *************************

            // Here you might have noticed that whenever you create a new copy and copy items one by one then.
            // Modifying the copied list does not alter the original list.. this is the advantage of deep copy.

            // *************** VERY IMPORTANT NOTE *******************
            // In the example above, we were dealing with numeric array, that is, the array is a reference type,
            // but the values stored in them were value type ( do you remember numbers being value type?).

            // So when we created a new array and copied the numbers one by one, a new number was created every time.
            // old_array = [1,2,3] . If I copied this one by one to a new array with size 3, then the new array will be
            // new_array = [1,2,3]. The numbers in this new array will not have relation with the old_array.

            // Observe the next method carefully to see how to create a new array if
            // the values stored in them are of reference type.

        }

        internal static void Array_Copy_for_ref_types()
        {
            // *************** Quick Heads up **********************
            // Lets say we created a class objects array (i.e, an array to store objects of a particular class).
            // In this case the array is also a reference type, and the values stored in them are also reference type (class object)
            //
            // Example obj_array_1 = [obj1, obj2, obj3] , if we follow the above procedure and create a new array of same size
            // and copy the objects one by one to a new array then there won't be a new copy of the items.
            // obj_array_new = [obj1, obj2, obj3]
            // The arrays might be different, but the objects stored in them will be the same.

            // We will create few SimpleStudent object and store them in array and try to copy that array like in the previous
            // method and see how it behaves, after that we will see the modification we need to do to get the desired effect.


            SimpleStudent anjana = new SimpleStudent("Anjana", "Uppin");
            SimpleStudent divya = new SimpleStudent("Divya", "Sonu");
            // Lets just put these two student objects into an array

            SimpleStudent[] students = new SimpleStudent[] { anjana, divya };
            // we will create a new copy of the array
           
            SimpleStudent[] students_copy = new SimpleStudent[students.Length]; // a new array of same size is created
          
            // Lets copy all the elements from students array into students_copy
            for (int i = 0; i < students.Length; i++)
            {
                students_copy[i] = students[i];
            }

            // Focus here: In the above method, when we did like this for numbers array, it worked correctly,
            // i.e., if we modified the items in one array the items on another remained untouched.
            // Here also we created the new array in the same fashion and lets modify the first object in the new array
            // and see if the first object in the old array remains untouched.

            Console.WriteLine("\n*************** New array but we directly copied the objects");
            Console.WriteLine( "\n Class objects value in the students array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : "+students[0].FirstName+"| Last Name : "+students[0].LastName);
            Console.WriteLine("\n Object 2 : Divya : First Name : " + students[1].FirstName + "| Last Name : " + students[1].LastName);
            Console.WriteLine("\n Class objects value in the Students_Copy array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students_copy[0].FirstName + "| Last Name : " + students_copy[0].LastName);
            Console.WriteLine("\n Object 2 : Divya : First Name : " + students_copy[1].FirstName + "| Last Name : " + students_copy[1].LastName);

            //Lets modify the Anjana object's last name in the new list
            //The index 0 corresponds to the object Anjana in the new list
            students_copy[0].LastName= "MU"; // We know that the '0' index of the new array corresponds to Anjana

            Console.WriteLine("\n We modified the last name of Anjana (in new array) and lets re-check the Anjana object in the old and new list");
            Console.WriteLine("\n Class objects value in the students array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students[0].FirstName + "| Last Name : " + students[0].LastName);
            Console.WriteLine("\n Class objects value in the Students_Copy array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students_copy[0].FirstName + "| Last Name : " + students_copy[0].LastName);
            Console.WriteLine("\n The last name has been modified in the object present in both the arrays");
            // Notice in the console output that both the new list and the old list has the updated last name
            // even though we modified the last name of the object in the new list


            //********** Very Important **********
            // Why do you think this has happened?
            // There are two things we need to focus when we create a DEEP copy.
            // Creating a new array/list and creating new items to put into that array/list.
            // We created a students_copy array, which is a completely new array- so the first step is correct.
            // The second step is we need to create a new copy of the object as well- which we will be storing inside the array.
            // In the previous numbers array, after creating the array, we directly copied the numbers and it worked, WHY?
            // Because numbers are value types, and when you copy a value type to new variable, a new copy will be created.
            // In this method, we tried to copy the student object ( this is a class object, which is a reference type),
            // so when you just copy a class object (or any other reference type) from one array into another or from
            // one variable to another, a new object is not created, instead only the address of the original object
            // is copied to the new location.

            // So always create a new container (array/list) and create new objects to put into
            // (unless you are just copying a value type).

            // ************ Lets redo the same example but this time we will create new objects ******

            // Lets reset Anjana's last name to what it was
            anjana.LastName = "Uppin";

            // Lets create a new array to store the two class objects - this is step one
            SimpleStudent[] students_deep_copy = new SimpleStudent[students.Length];

            // Lets make a deep copy of the Anjana and Divya object which is present in the students array.
            // We can directly call the Anjana and Divya object or call the items in the students array and create the copy.
            // Both are same

            for (int i = 0; i < students.Length; i++)
            {
                students_deep_copy[i] = students[i].CreateDeepClone(); 
                // Here we made a custom method to give us a new object with the same content
            }


            Console.WriteLine("\n*************** New array but we will create a DEEP copy of the object");
            Console.WriteLine("\n Class objects value in the students array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students[0].FirstName + "| Last Name : " + students[0].LastName);
            Console.WriteLine("\n Object 2 : Divya : First Name : " + students[1].FirstName + "| Last Name : " + students[1].LastName);
            Console.WriteLine("\n Class objects value in the Students_Copy array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students_deep_copy[0].FirstName + "| Last Name : " + students_deep_copy[0].LastName);
            Console.WriteLine("\n Object 2 : Divya : First Name : " + students_deep_copy[1].FirstName + "| Last Name : " + students_deep_copy[1].LastName);

            //Lets modify the Anjana object's last name in the new list
            //The index 0 corresponds to the object Anjana in the new list
            students_deep_copy[0].LastName = "MU"; // We know that the '0' index of the new array corresponds to Anjana

            Console.WriteLine("\n We modified the last name of Anjana (in new array) and lets re-check the Anjana object in the old and new list");
            Console.WriteLine("\n Class objects value in the students array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students[0].FirstName + "| Last Name : " + students[0].LastName);
            Console.WriteLine("\n Class objects value in the students_deep_copy array");
            Console.WriteLine("\n Object 1 : Anjana : First Name : " + students_deep_copy[0].FirstName + "| Last Name : " + students_deep_copy[0].LastName);
            Console.WriteLine("\n The last name has been modified in the object present in both the arrays");
            Console.WriteLine("\n Did you notice that the deep copy array's last name is changed, whereas the last name in students array is intact");

            // ------ Learning
            // When we try to make a new array of reference objects, even the reference objects need to deep copied.
            // Googling about how to make deep copies of object gave lot of results, which was a bit difficult to comprehend.
            // If you know somebody who knows C# or .NET well, then ask them to teach you.

        }

        internal static void List_Copy()
        {
            // I just spend way too much time on creating shallow and deep copy of array.
            // I believe it would be something similar for the List as well.
            // When you get time, please google about how to do shallow and deep copy of list.

            // But when asked in interviews, the thing you learnt in the array section is more than enough.
            // Remember about value and ref types and what happens when you just assign one variable to another (for value and ref types)
            //
            // During interviews it is enough if you mention how you will create a deep copy array.
            // Explain them how you will create a new array first, then if it is value type, then direct
            // assignment from old to new array, otherwise you will create a deep copy for the reference types
            // items present in the array.. did you get this?
        }
    }

    internal class SimpleStudent
    {

        string fName, lName;

        public string FirstName { get { return fName; } set { this.fName = value; } }

        public string LastName { get { return lName; } set { this.lName = value; } }
        public SimpleStudent(string firstName, string lastName)
        {
            this.fName = firstName;
            this.lName = lastName;
        }

        public SimpleStudent CreateDeepClone()
        {
            // here we have created a method which would create a completely new object based on the 
            // contents of the current object

            return new SimpleStudent(fName, lName);
        }
    }

}

