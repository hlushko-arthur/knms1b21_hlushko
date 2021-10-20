using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            var rand = new Random();
            Console.WriteLine("before:");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rand.Next(51);
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("after:");
            int[] new_arr = arr.sort_array();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new_arr[i]);
            }
        }
    }
    public static class IntExtension
    {
        public static int[] sort_array(this int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
    }
}
