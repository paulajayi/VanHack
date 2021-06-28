using System;
using System.Data;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            //compute string expression
            string expression = "2* 5";

            DataTable dt = new DataTable();
            double result = Math.Round(Convert.ToDouble(dt.Compute(expression, "")), 6);

            //var exp = 12042.760875000002d;
            //double result = Math.Round(exp, 6);

            Console.WriteLine(result);
        }
    }
}
