using System;

namespace Knuth
{
    class Program
    {
        static void Main()
        {
            int[] nums = { 0, 1, 2, 3, 4, 5, 3, 4, 5 };
            Shuffle(nums);
        }

        public static void Shuffle(int[] array)
        {
            Random random = new Random();
            int[] shuffledArray = array;
            int temp = 0;

            for (int i = 0; i < shuffledArray.Length; i++)
            {
                temp = shuffledArray[i];
                int j = random.Next(i, shuffledArray.Length);
                shuffledArray[i] = shuffledArray[j];
                shuffledArray[j] = temp;
            }

            foreach (var item in shuffledArray) { Console.Write(item + ", "); }
        }
    }
}
