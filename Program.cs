using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Sorting s = new Sorting(); 
            Console.Write("Enter Number Of Elements You Want To Enter in Array :   ");
            int numElem = Convert.ToInt32(Console.ReadLine());
          int   []arr = new int[numElem];

           Console.Write("\n");
           for (int i = 0; i < arr.Length; i++)
           {

               arr[i] = Convert.ToInt32(Console.ReadLine());
           }
            Console.Write("\n");
            Console.WriteLine("Select Ascending Or Descending? (a,d)");
           s.choice = Convert.ToChar(Console.ReadLine());
           int[] arrOld = new int[arr.Length];

           for (int i = 0; i < arr.Length; i++)
           {
               arrOld[i] = arr[i];
           }
            s.QS(arr, 0, arr.Length - 1);
            Console.Write("\nSORTING....\n");
            Console.Write("\nGiven List : \n{");
            for (int i = 0; i < arrOld.Length; i++)
            {
                if (i == arrOld.Length - 1)
                {
                    Console.Write(arrOld[i] + "}");
                }
                else
                    Console.Write(arrOld[i] + " , ");
            }
            Console.Write("\n\nSORTED LIST : \n{");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i] + "}\n");
                }
                else
                    Console.Write(arr[i] + " , ");
            }
          s.QuickSort();

            
        }
    }
}
