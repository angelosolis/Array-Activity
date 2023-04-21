using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayActivity
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter length: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] evenArr = new int[n];
            int[] oddArr = new int[n];
            int evenCount = 0, oddCount = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter num[{0}]: ", i);
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    evenArr[evenCount] = arr[i];
                    evenCount++;
                }
                else
                {
                    oddArr[oddCount] = arr[i];
                    oddCount++;
                }
            }
            int[] evenArrCopy = new int[evenCount];
            Array.Copy(evenArr, evenArrCopy, evenCount);
            int[] oddArrCopy = new int[oddCount];
            Array.Copy(oddArr, oddArrCopy, oddCount);
            Console.WriteLine("Odd: " + string.Join(", ", oddArrCopy));
            Console.WriteLine("Even: " + string.Join(", ", evenArrCopy));
            Console.WriteLine("Sum of all odd: " + ComputeSumOdd(oddArrCopy, oddCount));
            Console.WriteLine("Sum of all even: " + ComputeSumEven(evenArrCopy, evenCount));
        }

        static int ComputeSumOdd(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static int ComputeSumEven(int[] arr, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
