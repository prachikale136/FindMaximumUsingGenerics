
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
           int check1= MaximumGenerics.MaximumNumber(50,30,10);
            Console.WriteLine(check1);
        }
    }
}