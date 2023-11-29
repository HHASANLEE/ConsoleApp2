using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              Access Modified:
              
              public
              private
              protect
              internal
              protected internal
             */

        }

        //Methodun Signature(imzasi)
        //Access modified + Geri donus tipi + Metodun adi (input deyerler
        public void GetArray()
        {
            string choose = "";
            while(choose != "1")
            {
                string[] arr;
                Console.WriteLine("Arrayin uzunlugunu daxil edin");
                int num = Convert.ToInt32(Console.ReadLine());
                arr = new string[num];
                while (choose != "2");
                {
                    choose = Console.ReadLine();
                }
                Console.ReadLine();
            }
        }
    }
}
