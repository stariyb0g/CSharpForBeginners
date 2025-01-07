using System;

namespace CSharpForBeginners
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Bishop={ChessMasterBishop(1, 1, 8, 8)}");
            Console.WriteLine($"Castle={ChessMasterCastle(1, 1, 1, 8)}");
            Console.WriteLine($"Number={CountDigitOccuresInNumber(1111, 1)}");
            int[][] array = JaggedArray(6);
            for (int k = 0; k < 6; k++)
            {
                for (int m = 0; m <= k; m++)
                {
                    Console.Write(array[k][m] + " ");
                }
                Console.Write("\n");
            }
            int[] unsorted_array = { 1, 7, 4, 9, 3, 6 };
            unsorted_array = SortArray(unsorted_array);
            foreach (int num in unsorted_array)
            {
                Console.Write(num + " ");
            }
        }

        /*
        * на шахматній дошці у клітинці з координатами (a,b) знаходиться слон(офіцер),
        * створіть функцію що буде повертати істину
        якщо клітина (c,d) знаходиться під боєм
         */
        public static bool ChessMasterBishop(byte a, byte b, byte c, byte d)
        {
            // return false;
            return Math.Abs(a - b) == Math.Abs(c - d);
        }

        /*
         на шахматній дошці у клітинці з координатами (a,b) знаходиться тура(ладья),
         створіть функцію що буде повертати істину
         якщо клітина (c,d) знаходиться під боєм
        */
        public static bool ChessMasterCastle(byte a, byte b, byte c, byte d)
        {
            return (a == c && b != d) || (a != c && b == d);
        }

        /*Необхідно обчислити скільки разів у числі number зустрічається цифра digit*/
        public static int CountDigitOccuresInNumber(int number, int digit)
        {
            int k = 0;
            for (int i = number; i >= 1; i = i / 10)
            {
                if (i % 10 == digit)
                    k++;
            }
            return k;
        }

        /*
           Дано число n необхідно сформувати зубчастий масив наступним чином
           1
           1  2
           1  2  3
           1  2  3  4
           .............
           1  2  3  4 ..... n
        */

        public static int[][] JaggedArray(int n)
        {
            int i = n;
            int[][] Arr = new int[n][];
            for (int k = 0; k < i; k++)
            {
                Arr[k] = new int[k + 1];
                for (int m = 0; m <= k; m++)
                {
                    Arr[k][m] = m + 1;
                }
            }
            return Arr;
        }

        /*
         * Дан масив  inputArray.
         * За допомогою класу Array відсортуйте його в порядку зростання його елементів
         */
        public static int[] SortArray(int[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray;
        }
    }
}
