namespace _03.Array_Test
{
    using System;
    using System.Linq;

    public class ArrayTest
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop")) 
            {
                string[] param = command.Split(' '); // split the line by char
                string operation = param[0]; // adding string for the first index

                int[] args = new int[2];

                if (param[0].Equals("add") || param[0].Equals("subtract") || param[0].Equals("multiply"))
                // not the command line shoud be equal  to the command etc -> the line is it. index[0]
                {
                    //string[] stringParams = line.Split(ArgumentsDelimiter); // remove that
                    args[0] = int.Parse(param[1]);
                    args[1] = int.Parse(param[2]);

                    array = PerformAction(array, operation, args); // :) perform under what the array is equal to the perfom
                }
                else
                {
                    array = PerformAction(array, operation, args); // same and putting it in an else statement
                }


                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args) // method shoud return the array
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {// pos is not correct
                case "multiply":
                    array[pos - 1] *= value;  // same
                    break;
                case "add":
                    array[pos - 1] += value; // same
                    break;
                case "subtract":
                    array[pos - 1] -= value; // same
                    break;
                case "lshift":
                    array = ArrayShiftLeft(array); // array haves to be equal to the method
                    break;
                case "rshift":
                    array = ArrayShiftRight(array); // array haves to be equal to the method
                    break;
            }
            return array;  // add return array
        }

        private static long[] ArrayShiftRight(long[] array) // method shoudnt be void
        {
            long lastElement = array[array.Length - 1]; // add
            for (int i = array.Length - 1; i >= 1; i--) // no where getting the last element of the array
            {
                array[i] = array[i - 1];
            }
            array[0] = lastElement;
            return array;
        }

        private static long[] ArrayShiftLeft(long[] array) // same like the other array
        {
            long firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = firstElement;
            return array;
        }

        private static void PrintArray(long[] array) // cw
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}