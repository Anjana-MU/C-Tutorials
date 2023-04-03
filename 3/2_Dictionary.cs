using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    internal class Dictionary
    {
        /// Dictionary is a collection similar to array and list, but a dictionary differs
        /// from thos two in terms of how you store values in them.
        /// It only stores item in them in the form of Key, Value pairs. 
        /// 
        /// It is similar to a real life dictionary that we use.
        /// For any word that you find in a dictionary, there could be definition for it
        /// but the meaning for the same word would not be repeated anywhere else.
        /// 
        /// If you search the word 'beautiful' in dictionary, you would find your name in the meaning section,
        /// but you will not be able to find another page, where the word 'beautiful' would be explained.
        /// So for one word there will be set of definition and that's it.
        /// 
        /// Also, only in dictionary, divorce comes before marriage.


        /// Dictionary storage style
        /// <key1, value>
        /// <key2, value>
        /// <key3, value>
        /// 
        /// Notice that I have mentioned key1, key2 and key3 and the values are written as just value.
        /// It means, every key needs to be unique, but the values you store against each key
        /// doesn't need to be unique.
        /// 
        /// Think of student registration number and name.
        /// 
        /// We know that the registration number needs to be unique for each student,
        /// so that student's marks can be stored against their reg no.
        /// 
        /// Many students can have same marks, but if you don't have unique reg no, then it
        /// will be difficult to classify them
        /// 
        /// Ok, enough of rough examples, lets see some coding examples.
        


        public static void Dictionary_Intro()
        {
            int std1_regNo = 3001,
                std2_regNo = 3002,
                std3_regNo = 3003,
                std4_regNo = 3004;

            string std1_name = "Yamuna",
                   std2_name = "Godavari",
                   std3_name = "Anjana", // notice that your name is repeated... yaay
                   std4_name = "Anjana"; // This repeated name will be added in value section, so
                                         // the dictionary will not cause any issue.. it will
                                         // be kind to us, just like you.

            // The first item you write is the 'key' data type followed by the 'value' data type.
            // Here the int is the data type of Key, and string is the value data type.
            // We want to store the registration numbers and the names of the students against the
            // registration numbers.
            Dictionary<int, string> stdIdAndNames = new Dictionary<int, string>();

            /// Now we are going to add the items into the dictionary.
            /// The way we add is similar to list, but here we will have to add two items together,
            /// i.e., add the key and the value together.
            

            //the following method is similar to adding items to the list
            stdIdAndNames.Add(std1_regNo, std1_name); 
            stdIdAndNames.Add(std2_regNo, std2_name);

            // This is also a way to add new keys and values to the dictionary
            stdIdAndNames[std3_regNo] = std3_name; 
            stdIdAndNames[std4_regNo] = std4_name;

            /// Lets see if the dictionary has actually stored everything in it

            foreach (var item in stdIdAndNames.Keys)
            {
                /// For now don't worry about how I am retrieving the values,
                /// I have explained that in the below methods.
                Console.WriteLine(" key : "+item +" Value : "+stdIdAndNames[item]);
            }

            /// ****************** Learning ********************
            /// Be sure that dictionary is used to store key, value pairs of data.
            /// You cannot just store key and leave value part empty .
            /// Dictionary always needs unique keys - same key cannot be used twice.
            /// You can add items into dictionary in two ways as shown above.
            /// I only know those two ways and I guess that is enough.
        }

        private static void Dictionary_Key_Usage()
        {
            /// Lets see how to find the elements inside a dictionary
            /// 

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs[1] = "one";
            keyValuePairs[2] = "two";
            keyValuePairs[3] = "three";
            keyValuePairs[4] = "four";

            // We have created a dictionary, where the numbers are keys and their
            // string equivalents are values.

            // If we want to get the value for the key number 1 then we can obtain it by passing the key.
            string key3Value = keyValuePairs[3];

            /// The above method will work perfectly fine and the "Key3Value" variable will have the value "three",
            /// because that is the value we stored inside the dictionary

            /// *********** Important *************
            /// What if we didn't store a key with the number '3' or if we want to retrive value for the key '6'.
            /// When we are not sure if a particular key exists in the dictionary, it is always advisable to
            /// check if the key is present in the dictionary.
            /// 
            /// The below lines explain that method

            bool keyExists = keyValuePairs.ContainsKey(6);

            string key6Value = "";
            if (keyExists)
            {
                key6Value = keyValuePairs[6];
                // The boolean value will be false, so this part wont get executed,
                // but the program would have thrown error if we didn't have the key check.
                // When the key does not exist and if we try to get the value for it, then we will get
                // KeyNotFoundException error... This could be an interview question.
            }


            /// Lets see a scenario where we try to add a key which already exists.
            /// We already have the key '1' within the dictionary,
            /// if we execute the below code..

            keyValuePairs.Add(1, "JustNumber");
            /// The execution will stop with the "key already exists" exception
            /// this happens because the dictionary already has the key '1' and you are adding same key.
            /// Dictionaries should have UNIQUE keys, so this needs to be avoided.
            /// So then how do you avoid this case? well, before adding a key, check if the key already exists.


            /// ********* Updating a value in the dictionary ***********
            /// We know that we have the key '2' already present in the dictionary,
            /// the exising value is "two" and you want to change it to "Tutudooo".
            /// The simplest way to do is shown below..

            keyValuePairs[2] = "Tutudoo";

            /// ***** The line shown above is used to initialise a key-Value in the dictionary if the
            /// corresponding key is not present in the dictionary, or it is also used to update the
            /// dictionary if the same key is already present in the dictionary.
            /// 
            /// The Dictionary.Add() method should be used only when the key is not present in the dictionary already.
            /// Since the second method  Dictionary[key] works well both for addition as well as updation,
            /// always try to use the second method


            /// Now, what if you want to check if a particular value exists in the dictionary or not?
            /// Similar to ContainsKey method, you have ContainsValue method, we can use that.

            bool containsNumberSeven = keyValuePairs.ContainsValue("Seven");
            // this boolean will also be false, but at least we don't have to cycle through all the items
            // in the dictionary to see if the value is present or not.

            /// Imagine we have 10 Dictionaries for different sections of students in a college and you want to
            /// find which section has the name "Anjana", then in each section's dictionary you can use
            /// ContainsValue method to find if that name is present in that dictionary or not.
            /// 

            /// *************** Learning *************
            /// If we are not 100 percent sure about whether a key is present in a dictionary or not
            /// then it is advisable to use COntainsKey check to find out if the key is present or not.
            /// Otherwise if we access a key that is not even present then we will end up with
            /// KeyNotFoundExecption error.
        }

        public static void CyclingThroughDictionary()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs[1] = "one";
            keyValuePairs[2] = "two";
            keyValuePairs[3] = "three";
            keyValuePairs[4] = "four";

            /// An important concept is that, unlike lists or arrays, we cannot 
            /// access the elements in dictionary by index. i.e, you cannot
            /// get the 0th element, 1st element of a dictionary (at least that is
            /// what I think).. and also the items inside the dictionary are not
            /// exactly stored in the order you added elements into it
            /// the First key value pair inside the dictionary might not be <1, One>.


            /// In order to cycle through the dictionary you can collect all the keys as a
            /// list and cycle through the keys, and try to get the corresponding values for
            /// those keys.


            foreach (var key in keyValuePairs.Keys) // this has retuned the keys as a list.
            {
                // Now we know that we are cycling through only the existing keys,
                // so we don't have to check if the keys exist in the dictionary or not.
                // If we do that reduntant check, then people will think we are mad!!!
                Console.WriteLine("Value for key: "+ key+" is :"+keyValuePairs[key]);
            }

        }

        public static void StoringMultipleValueForSingleKey()
        {
            /// So far we saw that we can store a single value with a single key,
            /// but what if we want to store certain keys with multiple values?
            /// This is not a complicated task

            // Old dictionary
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            // this dictionary allows for one key, one value

            //if you want multiple values for a single key, then use list<string> as the value type
            Dictionary<int, List<string>> keyAndMultipleValues = new Dictionary<int, List<string>>();
            keyAndMultipleValues[1] = new List<string> { "one" };
            keyAndMultipleValues[2] = new List<string> { "two", "Eradu" };
            // No, Eradu is not Tamil, I have used the Kannada Eradu itself.

            // Here, for number 1, there is only value in the list,  for number 2, we have two values in the list.
            // Make sure that when you get the values from the dictionary you check how many values are in that list,
            // this could be done by checking the length of the list.

            List<string> valuesForNum2 = keyAndMultipleValues[2];
            int numOfValues = valuesForNum2.Count;

            Console.WriteLine("Values for the key 2 :"+string.Join(", ",valuesForNum2));
        }

        ///********************** Learning *******************
        /// Dictionary is used to store Key, Value pairs.
        /// Keys need to be unique.
        /// If you try to add a key that is already existing you will get
        /// "Key Already Exists" exception.
        /// If you try to access a key that does not exist in the dictionary, 
        /// then you will get "Key Not Found" exception.
        /// 
        /// There is something called as HashTable, I am not sure what it is.
        /// If I come to know about it, I will explain it to you.

    }
}
