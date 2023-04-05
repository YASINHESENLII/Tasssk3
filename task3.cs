// Task3
// InsertArray methodu yaradılır. Method parametr olaraq int tipindən array və params olaraq int-lər qəbul edir. 
// Paramslardan gələn dəyərləri həmin arraya əlavə etsin və sonda dəyişilmiş hal köhnə arraya bərabər olsun. 
// (Array resize istifade etmirsiz ozunuz Custom yazirsiz)
using System;

namespace AB103task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] myarray = { 1, 2, 3 };
            InsertArray(ref myarray, 4, 5, 6,7);
            for(int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }

        }
        public static void InsertArray(ref int[] arr, params int[] value)
        {
            int[] newarr = new int[arr.Length + value.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newarr[i] = arr[i];
            }
            for (int i = arr.Length; i < newarr.Length; i++)
            {
                newarr[i] = value[i -arr.Length];
            }
            arr = newarr;
        }
    }
}