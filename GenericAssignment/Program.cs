using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment
{
    
    internal class Program
    {

         
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("Divya");
            names.Add("Astha");
            names.Add("Puja");
            names.Add("Kavya");
            names.Add("Siya");
            names.Add("Monika");
            names.Add("Disha");
            names.Add("Neha");

            Console.WriteLine("Names added to the list");
            foreach (string item  in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nFind last index endswithA:");
            int indx = names.FindLastIndex(lastletter);

            Console.WriteLine(indx);
            int numberIndex = names.FindIndex(x => x == "Monika");
            Console.WriteLine("Monika is  {0}  place", numberIndex);
            IList<string> list1 = names.AsReadOnly();

            Console.WriteLine("\nElements in the read-only IList:");
            foreach (string dinosaur in list1)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nTrueForAll(EndsWithA): {0}",
               names.TrueForAll(EndsWithA));

            Console.WriteLine("\nFind(EndsWithA): {0}",
                names.Find(EndsWithA));

            Console.WriteLine("\nFindLast(EndsWithA): {0}",
                names.FindLast(EndsWithA));

            Console.WriteLine("\nFindAll(EndsWithA):");
            List<string> sublist = names.FindAll(EndsWithA);

            foreach (string item in sublist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nList now contains:");
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(
                "\n{0} elements removed by RemoveAll(EndsWithA).",
                names.RemoveAll(EndsWithA));

            
            Console.WriteLine("\nExists(EndsWithA): {0}",
                names.Exists(EndsWithA));


        }

        // Search predicate returns true if a string ends in "a".
        private static bool EndsWithA(String s)
        {
            return s.EndsWith("a");
        }
        private static bool lastletter(string g)
        {

            if (g == "Puja")
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }



}
   