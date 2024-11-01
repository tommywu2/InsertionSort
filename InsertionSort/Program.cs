using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                intArray[i] = rnd.Next(1,1000);
            }

            int currentPosition = 1;
            int position2 = 1;
            int currentNumber = intArray[0];
            int temp = 0;

            int currentItem;
            int numItems;
            int shuffleItem;
            int comparison;
            bool finish;
            int currentDataItem = intArray[currentItem];

            while (comparison < numItems && finish = false)
            {
                if (currentDataItem < intArray(comparison)
                {
                    shuffleItem = currentItem;
                    while (shuffleItem > comparison)
                    {
                        intArray[shuffleItem] = intArray[shuffleItem - 1];
                        shuffleItem--;
                        finish = true;
                    }
                    comparison++;
                }
                else
            }
            currentItem++;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(intArray[i]);
            }

        }
    }
}
