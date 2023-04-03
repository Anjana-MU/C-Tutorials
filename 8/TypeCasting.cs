using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    /// ******************** Type casting ***************
    /// What is Type casting? What is even a Type?
    /// Have you used the method object.GetType() method?
    /// 
    /// Basically type tells the data or object type.
    /// If you declare an integer as a and do a.GetType(), you will get the type as int.
    /// If you declare a Point3D class obj as x1 and do x1.GetType(), you will get the type as Point3D.
    /// Are you clear???
    /// 
    /// Let us think about this example
    /// Example 1:
    /// double pi =3.14;
    /// int a = (int)pi;
    /// 'a' is an integer, it cannot store the ".14" value of "3.14", so what does it do?
    /// It will trim the ".14" part and only the value 3 will be stored in 'a'.
    /// This is called explicit conversion, because we are explicitly saying change double into int.
    /// Notice the use of int within the bracket.
    /// 
    /// Example 2:
    /// Implicit conversion. A 'long' can hold any value an int can hold, and more!
    /// int num = 2147483647;
    /// long bigNum = num; // Here we are not using any type names within the bracket, so this is implicit.
    /// 
    /// Whatever you witnessed is called Typecasting, basically you are changing the data type from one
    /// to another. Well, you weren't converting, it was converting internally, but you know it is possible
    /// to convert like that. Why? Beacuse there are methods written internally to do this conversion.
    /// 
    /// So if you create a new type (class type) and you think there are two classes that are quite similar and
    /// you want to convert one class object into another, then you can write your own type casting methods in them.
    /// 
    /// 
    /// We are already familiar with Point2D and Point3D, Point2D has 2 values and Point3D has 3 values.
    /// Say we want to change Point3D with 3 coordinates into Point2D by removing the z coordinate and we
    /// want to have the capability to change point2D into point3D, there won't be a Z coordinate value for
    /// point2D, so we will set the z coordiante value to 0 when we convert from 2D to 3D.
    /// 
    /// Lets implement this.


    /// We already created 3D and 2D class, we made that as partial class, so that we could add some extra stuff later.
    /// Also, if I had explained everything in a single class then it would have been a bit too much.

    partial class Point3D
    {

        /// Implicit conversion means, you don't have to type the name of the type you want your current
        /// object is being converted into.
        /// 
        /// I have made the conversion from 3D to 2D implicit because we are not adding any new value,
        /// we are only removing the Z coordinate value.
        
        public static implicit operator Point2D(Point3D point3D)
        {
            return new Point2D(point3D.X, point3D.Y);
        }

        /// <summary>
        /// Produces a list based on the coordinated of the point3D
        /// </summary>
        /// <param name="point3D"></param>
        public static explicit operator List<int>(Point3D point3D)
        {
            return new List<int>() { (int)point3D.X, (int)point3D.Y, (int)point3D.z };
            // We have created an explicit method to return the coordinates of the point3D into a list.
            // We made this explicit, just to make the users write it explicitly.

            // Did you notice the point3D.z is a small case z, do you know why?
            // Note this and ask me about this, if i type it here, definitely I will confuse you.
            // I am 100 percent sure that I would confuse you with words.
        }
    }

    partial class Point2D
    {
        /// Explicit conversion means, you HAVE TO type the name of the type you want your
        /// current object is being converted into.
        /// 
        /// I have made the conversion from 2D to 3D explicit because we are adding a dummy 0
        /// value for the z coordinate, so the user would have a moment to think that 
        /// "Ok I am explicitily changing stuff here, there could be some loss of data or something
        /// else happening, because the programmer has made  me to do this with extra effort".

        public static explicit operator Point3D(Point2D point2D)
        {
            return new Point3D(point2D.X, point2D.Y,0);
        }

        // Also, I purposely made you one explicit and the other implicit just to show that it is
        // possible to do it in both ways and the syntax for them is almost similar.
    }


    public static class ClassForMethods
    {
        public static void Methodforexample()
        {
            Point3D real3DPoint = new Point3D(10, 10, 10);

            Console.WriteLine(" Value of real3DPoint is : "+real3DPoint.ToString());// ref line 1
            Console.WriteLine(" Well the above to string will only return the class name");
            Console.WriteLine(" So we will write the values manually");
            Console.WriteLine(" X: "+ real3DPoint.X+" | Y: "+real3DPoint.Y+" | Z: we didnt create access for this value");


            Point2D a2DPoint = real3DPoint; // See, here a 3D point got assigned to a 2D point.

            Console.WriteLine("\n\n Value of real3DPoint is : " + a2DPoint.ToString()); // ref line 2.
            // See how easy it is to use the ToString() here, because it will give the information clearly.

           
            // As an exercise place the cursor on the ToString() part  on the ref line 1 in this method and press f12.
            // Now do the same on the ToString() part on ref line 2.
            // Do you understand why it goes to different location?
            //
            // Yes, you are correct.. 10 points.


            // real3DPoint = pointOnPaper; Uncomment this line and read the error.

            real3DPoint = (Point3D)a2DPoint; // Here we had to explicit conversion.

            List<int> coords = (List<int>)real3DPoint; // How cool is this???
            Console.WriteLine(" Value of list  is : " + string.Join(", ",coords));
        }
    }

    /// ******************* Learning ******************
    /// We can create custom conversion between types .
    /// This can be done using explicit or implicit conversion.
    /// If the understanding of the conversion is straight forward then go with implicit
    /// otherwise use explicit conversion.
    /// 
    /// Link: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions
}
