using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWarkNewArray
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            int numberElement = 30;
            int minNumber = 1;
            int maxNumber = 4;
            int numberRepeat = 0;
            int allRepeat = 1;
            int maxRepeat = 0;
            int tempNumber = 0;
            int[] mainArray = new int[numberElement];
            Random random = new Random();

            for (int i = 0; i < numberElement; i++)
            {
                mainArray[i] = random.Next(minNumber,maxNumber);
            }

            for (int i = 0; i < mainArray.Length; i++)
            {
                Console.Write($"{mainArray[i]}  ");
            }
            Console.WriteLine();

            for (int i = 0; i < mainArray.Length - 1; i++)
            {
                if (mainArray[i] == mainArray[i + 1])
                {
                    allRepeat++;
                    tempNumber = mainArray[i];
                }
                else
                {
                    allRepeat = 1;
                }

                if (allRepeat >= maxRepeat)
                {
                    numberRepeat = tempNumber;
                    maxRepeat = allRepeat;
                }
            }
            Console.WriteLine($"Число, которое само больше раз повторяется подряд {numberRepeat} и количество одинаковых чисел подряд {maxRepeat}.");
        }
    }
}
