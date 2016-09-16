using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerchSaito
{
    class Program
    {



        static void Main(string[] args)
        {
            string WL = output(100);
            Console.WriteLine(WL);
            Console.ReadKey();
        }

        static string output(int count)
        {
            string st = "";
            for (int i = 0; i < count; i++)
            {
                st += "斎";
            }

            StringBuilder sb = new StringBuilder(st);
            int replacePosision = 3;
            sb.Insert(replacePosision, "齋");
            sb.Remove(replacePosision-1, 1);
            for (int i=0 ; i < count+1 ; i+=10)
            {
                sb.Insert(i, "\n");
            }
            st = sb.ToString(); ;

            return st;
        }

        static string output_answer(int x,int y)
        {

            return st;
        }
    }
}
