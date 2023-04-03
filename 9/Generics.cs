using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    public class Latest5<Tvar>
    {
        List<Tvar> fiveItems = new List<Tvar>();

        int index = 0;

        public int TotalItemsAdded { get { return index; } }
        public Latest5()
        { }

        public void Add(Tvar input)
        {
            if (fiveItems.Count == 5)
            {
                fiveItems.RemoveAt(0);
            }
            fiveItems.Add(input);
            index++;
        }

        public Tvar GetFirstItem()
        {
            if (index > 0)
                return fiveItems[0];
            else
                throw new Exception("No item added to Latest5 class");
        }

        public Tvar GetLastItem()
        {
            if (index > 5)
                return fiveItems[4];
            else
                throw new Exception("Latest5 class does not have 5 items yet");
        }
    }

    public static class Generic_Example
    {

        public static void Example()
        {

            Latest5<Student> fiveItems = new Latest5<Student>();

            fiveItems.Add(new Student());

            Console.WriteLine("\n" + fiveItems.TotalItemsAdded);

            Console.WriteLine("\n" + fiveItems.GetFirstItem());

            Console.WriteLine("\n" + fiveItems.GetLastItem());

            Latest5<int> fiveNums = new Latest5<int>();
            fiveNums.Add(1);
            fiveNums.Add(3);
            fiveNums.Add(5);
            fiveNums.Add(7);
            fiveNums.Add(8);
            fiveNums.Add(9);

            Console.WriteLine("\n" + fiveItems.TotalItemsAdded);

            Console.WriteLine("\n" + fiveItems.GetFirstItem());

            Console.WriteLine("\n" + fiveItems.GetLastItem());

        }
    }


}
