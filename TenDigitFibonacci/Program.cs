using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = 0;
            int preValue = 0;
            int superPreValue = 1;
            List<int> values = new List<int>();
            //terminating loop when length of value hits 10 digits
            while (value.ToString().Count() < 10)
            {
                Console.WriteLine(value);
                value = preValue + superPreValue;
                superPreValue = preValue;
                preValue = value;
                //add value to list to keep track of indexes
                values.Add(value);
            }

            //the index after the last index will have 10 digits
            Console.WriteLine(values.Count + 1);




        }//end main
    }
}
