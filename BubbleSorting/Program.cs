using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class Program
    {
        // funkcja do zamiany miejscami dwóch liczb
        static void Swap(int a, int b)
        {
            int temp = 0;
            temp = a;
            a = b;
            b = temp;
        }

        // funkcja do sortowania bąbelkowego
        static int[] BubbleSort(int[] input_tab)
        {
            int size = input_tab.Length;
            int[] output_tab = new int[size];
            int temp;

            try
            {
                do
                {
                    for (int i = 0; i < size - 1; i++)
                    {
                        if (input_tab[i] > input_tab[i + 1])
                        {
                            temp = input_tab[i + 1];
                            input_tab[i + 1] = input_tab[i];
                            input_tab[i] = temp;
                        }
                    }
                    size--;
                }
                while (size > 1);
            }
            catch
            {
                Exception ex;
            }
            output_tab = input_tab;
            return output_tab;
        }

        static void Main(string[] args)
        {
            int[] numbers = {3746, 75, 87, 976, 1, 2332, 756873, 767, 75};
            int[] sorted_numbers = new int[numbers.Length];

            // Unsorted array of numbers
            
            Console.WriteLine("The unsorted array: ");
            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
            
            Console.WriteLine();
            sorted_numbers = BubbleSort(numbers);

            // Sorted array of numbers
            Console.WriteLine("The sorted array: ");
            foreach (int n in sorted_numbers)
            {
                Console.Write(n + " ");
            }                    
            Console.Read();
        }
    }
}
