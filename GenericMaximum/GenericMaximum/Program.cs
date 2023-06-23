
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaximum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // MaximumGenerics maximumGenerics = new MaximumGenerics();
            /*int check1= MaximumGenerics.MaximumNumber(50,30,10);
             Console.WriteLine(check1);

             Console.WriteLine("Maximun float number");
             double number = MaximumGenerics.MaximunFloatNumber(11.1, 22.2, 33.3);
             Console.WriteLine(number);

             //For Maximun String value
             Console.WriteLine("Maximun string value");
             string output = MaximumGenerics.MaximunStringNumber("Apple", "Peach", "Banana");
             string output1 = MaximumGenerics.MaximunStringNumber("Banana", "Peach", "Apple");
             string output2 = MaximumGenerics.MaximunStringNumber("Apple", "Banana", "Peach");
             Console.WriteLine(output);
             Console.WriteLine(output1);
             Console.WriteLine(output2);*/

            int[] intArray = { 120, 111, 235, 142, 234, 112 };
            GenericsMaximum<int> generic = new GenericsMaximum<int>(intArray);
            generic.PrintValue();
            double[] doubleArray = { 11.2, 11.3, 55.5, 22.2, 33.3 };
            GenericsMaximum<double> genericsDouble = new GenericsMaximum<double>(doubleArray);
            genericsDouble.PrintValue();
            string[] stringArray = { "111", "222", "333", "444", "555" };
            GenericsMaximum<string> genericString = new GenericsMaximum<string>(stringArray);
            genericString.PrintValue();
        }
    }
}