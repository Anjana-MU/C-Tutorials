using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{

    /// Struct is used to encapsulate data and related functionality.
    /// 
    /// *********** Struct is a VALUE type *************
    /// 
    /// *********** Structs do not support inheritance, 
    /// but they can implement interfaces. *************
    /// 
    /// *** Above point is very important, if possible tattoo it on your arm.
    /// 
    /// So far, I have used struct to store only data together and never
    /// created any methods in them.
    /// 
    /// If asked in interview, you can explain it based on the examples I
    /// have provided below. And if you are further interested, then you 
    /// can read online by googling "c# struct".
    /// 
    /// Some definitions from web:
    /// 
    /// struct can include constructors, constants, fields, methods, 
    /// properties, indexers, operators, events & nested types.
    /// 
    /// struct cannot include a parameterless constructor or a destructor.
    /// 
    /// struct can implement interfaces, same as class.


    struct Coordinate
    {
        public double latitude;
        public double longitude;
    }

    struct StudentData
    {
        // By default these datas will have 0 or "" as the default value so after creating 
        // the struct if you access these variables then you  will get the default values.
        public string name;
        public  int ID;
        public string Department;

        /// List will not contain any default value, rather it will be null.
        /// Once the struct is created, if the list is not initialised properly and just 
        /// accessed like.. stdData.marks.add(1); then it will be an error.
        /// 
        /// I will show it in the example, don't scratch your head.
        public List<int> marks;
    }

    struct PinData
    {
        double[] leftCornerPoint;
        double[] rightCornerPoint;

        public int PinID { get ; }

        public PinData(int pinID, double[] leftPt, double[] rightPt)
        {
            PinID = pinID;
            leftCornerPoint = leftPt;
            rightCornerPoint = rightPt;
        }

        public double AreaOfPin()
        {
            return Math.Sqrt(Math.Pow(rightCornerPoint[0] - leftCornerPoint[0], 2) +
                            Math.Pow(rightCornerPoint[1] - leftCornerPoint[1], 2));
        }
    }

    internal class StructClassExamples
    {
        public static void Method_1()
        {
            /// Just a bit tired to put too many examples using the console writeline statement.
            /// Would you mind executing this method and check the values of the variables
            /// line by line as the control flows step by step?
            /// 
            /// That and the comments written here would help you understand the concept.
            /// 
            /// Is that ok ? ....Cool, thanks.. :)

            Coordinate coordStruct = new Coordinate();
            coordStruct.latitude = 32.45;
            coordStruct.longitude = 43.56;
            // So the above struct will contain the values we assigned now.



            StudentData studentStruct = new StudentData();
            studentStruct.name = "Anjana";
            studentStruct.ID = 5;
            // The below line will fail, so understand the error when it fails and during the 
            // next run, comment this line and run...Thanks.
            studentStruct.marks.Add(20);

            studentStruct.marks = new List<int>() { 40,50,60};


            /// The reason for the above method is to drive home the point that some data types 
            /// by default have some value, so you don't have to initalise them.
            /// 
            /// Other types like list, array, dictionary or any class object. i.e., whichever you
            /// would create using the new operator will not have a default value other than null,
            /// so you need to initialise them first.
            /// 
            /// Maybe as an exercise, can you identify the error that gets thrown when you 
            /// try to assign value to a variable without initialising it????


            // PinData struct has a constructor, but we didn't use that constructor.
            // so it would assign default values to the variables.
            PinData pin30 = new PinData();
            int id = pin30.PinID;

            PinData pin40 = new PinData(40, new double[] { -3, -4 }, new double[] { 4, 5 });
            double area = pin40.AreaOfPin(); // we are accessing the area of the pin surface.

            // Since we didn't declare the left and right point as public, we are not able to
            // see the values of those points.
            
        }
    }
}
