using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Threading.Channels;

namespace Assignment
{
    internal class Program
    {
        //Question1
        static void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        //Question2
        static int SumArray(ref int[] Arr)
        {
            int sum = 0;
            Arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < Arr.Length; i++)
            {
                sum += Arr[i];
            }
            return sum;
        }

        //Question3
        static void Calculate(int[] numbers, out int sum, out int subtract)
        {
            sum = numbers[0] + numbers[1];        
            subtract = numbers[2] - numbers[3];  
        }

        //Question4
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10; 
                number /= 10;
            }
            return sum;
        }


        //Question5
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true; 
        }


        //Question6
        static void MinMaxArray(int[] numbers, ref int min, ref int max)
        {
            min = numbers[0];
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
                if (numbers[i] > max)
                    max = numbers[i];
            }
        }


        //Question7
        static int Factorial(int number)
        {
            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        //Question8
        static string ChangeChar(string input, int position, char newChar)
        {
            char[] charArray = input.ToCharArray();

            if (position >= 0 && position < charArray.Length)
            {
                charArray[position] = newChar;
            }
            else
            {
                Console.WriteLine("Invalid position.");
            }
            return new string(charArray);
        }

        //Question9
        static void PrintIdentityMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }


        //Question10
        static int SumArray2(int[] numbers)
        {
            int sum = 0;

            // Loop through the array to add each element to sum
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        //Question11
        static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;
            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    mergedArray[k] = array1[i];
                    i++;
                }
                else
                {
                    mergedArray[k] = array2[j];
                    j++;
                }
                k++;
            }
            while (i < array1.Length)
            {
                mergedArray[k] = array1[i];
                i++;
                k++;
            }
            while (j < array2.Length)
            {
                mergedArray[k] = array2[j];
                j++;
                k++;
            }

            return mergedArray;
        }


        //Question14
        static void FindSecondLargest(int[] arr)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }
            Console.WriteLine($"The second largest element is: {secondLargest}");
        }


        //Question15
        static void FindLongestDistance(int[] arr)
        {
            int maxDistance = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        int distance = j - i - 1;
                        if (distance > maxDistance)
                        {
                            maxDistance = distance;
                        }
                    }
                }
            }
            if (maxDistance >= 0)
            {
                Console.WriteLine($"The longest distance between two equal cells is: {maxDistance} cells.");
            }
            else
            {
                Console.WriteLine("No two equal cells found with a valid distance.");
            }
        }

        //-----------------------------------------------
        static void Main(string[] args)
        {

            #region Question1
            ////1.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //int A = 9, B = 4;

            ////1.passing by value
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");

            //swap(A, B);
            //Console.WriteLine("=======After SWAP=======");
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");


            ////2.passing by reference
            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}");

            ////Swao(A,B); // Paasing by ref
            //swap(ref A, ref B); // Paasing by ref

            //Console.WriteLine("=======After SWAP=======");

            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}"); 

            //Explanation:
            //    By Value
            //    swap receives a copy of number.
            //    Any changes to x inside the method do not affect the original number.

            //    By Reference
            //    swap uses the ref keyword.
            //    The method receives a reference to number.
            //    Changes to x directly modify the original number.
            #endregion


            #region Question2
            //2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //int[] Numbers = { 1, 2, 3 };
            ////1.passing by value
            //Console.WriteLine(SumArray(Numbers)); //15
            //Console.WriteLine(Numbers[0]); //1

            ////2.passing by ref
            //Console.WriteLine(SumArray(ref Numbers)); //15
            //Console.WriteLine(Numbers[0]); //4 
            #endregion


            #region Question3
            ////3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int[] numbers = new int[4];
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int sum, subtract;
            //Calculate(numbers, out sum, out subtract);

            //Console.WriteLine($"Summation of first two numbers: {sum}");
            //Console.WriteLine($"Subtraction of last two numbers: {subtract}");
            #endregion


            #region Question4
            ////4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = SumOfDigits(number);

            //Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            #endregion


            #region Question5
            ////5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //bool result = IsPrime(number);

            //if (result)
            //    Console.WriteLine($"{number} is a prime number.");
            //else
            //    Console.WriteLine($"{number} is not a prime number."); 
            #endregion


            #region Question6
            ////6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] numbers = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter number {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int min = 0, max = 0;
            //MinMaxArray(numbers, ref min, ref max);
            //Console.WriteLine($"Minimum value in the array: {min}");
            //Console.WriteLine($"Maximum value in the array: {max}");
            #endregion


            #region Question7
            ////7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = Factorial(number);

            //Console.WriteLine($"The factorial of {number} is: {result}");
            #endregion


            #region Question8
            ////Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter the position (0-based index) of the character to replace: ");
            //int position = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadLine()[0];

            //string result = ChangeChar(input, position, newChar);

            //Console.WriteLine($"Modified string: {result}");
            #endregion


            #region Question9
            ////9.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter the size of the matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //PrintIdentityMatrix(n);
            #endregion


            #region Question10
            ////10.Write a program in C# Sharp to find the sum of all elements of the array.
            //int[] numbers = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Enter element {i + 1}: ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int result = SumArray2(numbers);
            //Console.WriteLine($"The sum of all elements in the array is: {result}"); 
            #endregion


            #region Question11
            ////11. Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order
            //int[] array1 = new int[3];
            //int[] array2 = new int[3];

            //Console.WriteLine("Enter elements for the first sorted array:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter elements for the second sorted array:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array2[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mergedArray = MergeArrays(array1, array2);

            //Console.WriteLine("Merged sorted array:");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{
            //    Console.Write(mergedArray[i] + " ");
            //} 
            #endregion


            //12.

            //13. the same of question 6

            #region Question14
            ////14.Write a program in C# Sharp to find the second largest element in an array.
            //int[] arr = new int[5];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //FindSecondLargest(arr); 
            #endregion


            #region Question15
            ////15.Consider an Array of Integer values with size N, having values as in this Example
            //int[] arr = new int[5];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //FindLongestDistance(arr); 
            #endregion


            #region Question17
            ////17.Given a list of space separated words, reverse the order of the words.
            //Console.Write("Enter a sentence: ");
            //string input = Console.ReadLine();

            //string output = string.Join(" ", input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());

            //Console.WriteLine(output); 
            #endregion


            #region Question18
            ////18.Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array.
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());
            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("The second array (copied from the first array) is:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion


            #region Question19
            ////19.Write a Program to Print One Dimensional Array in Reverse Order
            //int[] array = new int[5];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Array in reverse order:");
            //for (int i = 5 - 1; i >= 0; i--)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine(); 
            #endregion
        }
    }
}
