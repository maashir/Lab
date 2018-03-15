using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSort
{
    class Sorting
    {
       public  int pivNum = 1;
       public  int[] arr;
       public char choice;

        public void QS(int[] arr, int start, int end)
        {

            if (start < end)
            {
                int pIndex=0;
                if (choice == 'a') { pIndex = PartitionAsc(arr, start, end);}
                if (choice == 'd') { pIndex = PartitionDesc(arr, start, end); }
                QS(arr, start, pIndex - 1);
                QS(arr, pIndex + 1, end);
            }
        }

        private int PartitionAsc(int[] arr, int start, int end)
        {
            
            int pivot = start;
            int pIndex = end;
            Console.WriteLine("Pivot # "+pivNum+" : "+arr[pivot]);
            pivNum++;
            for (int i = end; i > start; i--)
            {
                if (arr[i] > arr[pivot])
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex--;
                }
            }
            int temp1 = arr[pivot];
            arr[pivot] = arr[pIndex];
            arr[pIndex] = temp1;
            return pIndex;
        }

        private int PartitionDesc(int[] arr, int start, int end)
        {

            int pivot = start;
            int pIndex = end;
            Console.WriteLine("Pivot no " + pivNum + " : " + arr[pivot]);
            pivNum++;
            for (int i = end; i > start; i--)
            {
                if (arr[i] > arr[pivot])
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex--;
                }
            }
            int temp1 = arr[pivot];
            arr[pivot] = arr[pIndex];
            arr[pIndex] = temp1;
            return pIndex;
        }

        public void QuickSort()
        {
            //input();
            int[] arrOld = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrOld[i] = arr[i];
            }
            QS(arr, 0, arr.Length - 1);
            print(arrOld, arr);
        }

        public void print(int[] arrOld, int[] arr)
        {
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
        }

        public void input()
        {
            //Console.Write("Enter Number Of Elements You Want To Enter   :   ");
            //int numElem = Convert.ToInt32(Console.ReadLine());
            //arr=new int[numElem];

            //Console.Write("-----------------\n");
            //for (int i = 0; i < arr.Length; i++)
            //{
               
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
                
            //}
            
            //Console.Write("-----------------\n");
            //Console.WriteLine("Ascending Or Descending? (a,d)");
            //choice = Convert.ToChar(Console.ReadLine());
            //Console.Write("\nSORTING....\n");
            }

      }
 }

