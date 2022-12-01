using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDArrayv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");
            //Single Dimension array 
            string[] Fruits = new string[4];
            //add value to the array
            Fruits[0] = "Apple";  //1
            Fruits[1] = "Banana"; //2
            Fruits[2] = "Cherry"; //3
            Fruits[3] = "Durian"; //4
            //Fruits[4] = "Guava"; //Hizole - the items are greater than the no of items

            // to determine the capacity of array
            int daminglamanngarray = Fruits.Length; 
            Console.WriteLine($"Array size: {daminglamanngarray}");

            //Resize
            Array.Resize(ref Fruits, daminglamanngarray +1);
            Console.WriteLine($"new size {Fruits.Length}");
            //we could add new items to the array
            Fruits[4] = "Guava";

            //Show value of the array
            Console.WriteLine(Fruits[0]);
            Console.WriteLine(Fruits[4]);

            //Declare and initialize a dynamic array
            string [] Animals = new string[] 
            {"Ape","Bat","Crocodile","Dog","Elephant","Frog","Goat","Horse","Iguana","Jaguar"};
            // 0      1     2          3     4          5      6      7
            //To show value
/*            Console.WriteLine(Animals[0]);
            Console.WriteLine(Animals[1]);
            Console.WriteLine(Animals[2]);
            Console.WriteLine(Animals[3]);
            Console.WriteLine(Animals[4]);
            Console.WriteLine(Animals[5]);
            Console.WriteLine(Animals[6]);
            Console.WriteLine(Animals[7]);*/

            //Display array value using a loop
/*            for (int i = 0; i < Animals.Length; i++)
            {
                Console.WriteLine(Animals[i]);
            }*/

            //Display value of an array using foreach loop
            foreach(string value in Animals)
            {
                Console.WriteLine(value);
            }





            Console.ReadLine();

        }
    }
}
