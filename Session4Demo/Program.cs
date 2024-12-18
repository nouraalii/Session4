using System.Diagnostics.CodeAnalysis;

namespace Session4Demo
{
    //1.class     :->Function
    //2.struct    :->Function
    //3.interface :->Function
    //4.enum
    public class NewData
    {
        public int Sum;
        public int Mul;
    }



    internal class Program
    {
        static void PrintShape (string pattern = "^_^" , int count = 9 )
        {
            //body(code)
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        
        static int SumNumbers(int x , int y)
        {
            return x + y;
        }

        static void swap(ref int x ,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int SumArray(ref int[] Arr)
        {
            int sum = 0;
            Arr =  new int[] {4,5,6};
            for (int i = 0; i <Arr.Length; i++)
            {
                sum+= Arr[i];
            }
            return sum;
        }

        //static int[] SumMul(int x, int y)
        //{
        //    int[] result = { x + y, x * y };
        //    return result;
        //}

        static NewData SumMul(int x, int y)
        {
            NewData data = new NewData();
            data.Sum = x + y;
            data.Mul = x * y;
            return data;
        }

        //static void sumMul(int x, int y ,out int Sum , out int mul)
        //{
        //    Sum = x + y;
        //    mul = x * y;
        //}

        static int SumArray2(params int[] Arr)
        {
            int Sum = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                Sum += Arr[i];
            }
            return Sum;
        }

        //Entry point
        static void Main(string[] args)
        {
            #region 1D Array
            //1D Array
            //int[] Numbers;
            //Declare for reference(pointer) from type "Array pf ints"
            //Number:can refer to object from "Array pf ints"
            //Numbers : Refers to Null

            //8 bytes will be allocated at stack for the refernce "Number"
            //0 Bytes will be allocated at heap

            //Numbers=new int[size]
            //Numbers = new int[5];
            //new
            //1.Allocate the number of Required for the object at heap (5*4 bytes)
            //2.Initializes the allocated bytes with the defalut value of the data type
            //3.call user-defined constructor if exists
            //4.Assign the object to the refernece 'Numbers'

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);

            //Numbers[0] = 12;
            //Numbers[1] = 6;
            //Numbers[2] = 7;
            //Numbers[3] = 90;
            //Numbers[4] = 8;
            //Numbers[5] = 12;//Index out of range

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]); 
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Numbers[{i}] : ");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine();

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine();


            //Console.WriteLine(Numbers.Length); //size of array : 5
            //Console.WriteLine(Numbers.Rank); //1 dimention

            //Array fixed size

            //int[] Number01 = new int[5] {1,2,3,4,5}; 
            //int[] Number02 = new int[5] {1,2,3,4,5};
            //int[] Number03 = {1,2,3,4,5}; //New 
            #endregion

            #region 2D Array
            // 2D Array

            //int[,] Marks = new int[3, 4];
            // Marks[0,0] = 99;
            // Marks[0,1] = 98;
            // Marks[0,2] = 97;
            // Marks[0,3] = 88;

            // Marks[1, 0] = 99;
            // Marks[1, 1] = 98;
            // Marks[1, 2] = 97;
            // Marks[1, 3] = 88;

            // Console.WriteLine(Marks[0, 0]);
            // Console.WriteLine(Marks[0, 1]);
            // Console.WriteLine(Marks[0, 2]);
            // Console.WriteLine(Marks[0, 3]);

            // Console.WriteLine(Marks[1, 0]);
            // Console.WriteLine(Marks[1, 1]);
            // Console.WriteLine(Marks[1, 2]);
            // Console.WriteLine(Marks[1, 3]);

            // Console.WriteLine(Marks[2, 0]);
            // Console.WriteLine(Marks[2, 1]);
            // Console.WriteLine(Marks[2, 2]);
            // Console.WriteLine(Marks[2, 3]);

            // for (int i = 0; i < 3; i++)
            // {
            //    for (int j = 0; j < 4;  j++)
            //    {
            //        Console.Write($"{Marks[i,j]}");
            //    }
            // }
            // Console.WriteLine(Marks.Length);//12
            // Console.WriteLine(Marks.Rank);//12

            #endregion

            #region 2D Array
            //int[][] Marks = new int[3][];
            //Marks[0] = new int [3];
            //Marks[1] = new int [2];
            //Marks[2] = new int [4];

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine( $"Enter Mark[{i},{j}]" );
            //        Marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine(Marks[i][j]);

            //    }
            //    Console.WriteLine();
            //} 
            #endregion


            #region Function prototype and calling
            //Function : block of code has name 
            //Reuse 
            //DRY
            //Function Prtotype
            //1.Signature
            //1.1 Name
            //1.2 Return type
            //1.3 parameters (inputs)

            //2.body(code)

            //PrintShape();

            //Function - Method
            //1.Class Member method : (static method)
            //2.Object Member method : (Non Static Method)

            //PrintShape();

            //Program p = new Program();
            //p.PrintShape();

            //PrintShape(5,"#_@");//Passing by order
            //PrintShape(pattern:"#_@",count: 5);//Passing by name
            //PrintShape("#_@");//Passing by Name
            //PrintShape(); passing by name

            //int result = SumNumbers(1, 2);
            //Console.WriteLine(result);

            //Console.WriteLine(SumNumbers(1, 2)); 
            #endregion

            #region Stack Frames
            SumNumbers(1, 2);
            #endregion

            #region passing parameter (Value type) 
            //passing parameter (Value type)
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
            //swap(ref A,ref B); // Paasing by ref

            //Console.WriteLine("=======After SWAP=======");

            //Console.WriteLine($"A:{A}");
            //Console.WriteLine($"B:{B}"); 
            #endregion


            #region passing parameter (reference type)
            //passing parameter (reference type)

            //int[] Numbers = { 1, 2, 3 };

            //1.passing by value

            //Console.WriteLine(SumArray(Numbers));// 105 // passing by value
            //Console.WriteLine(Numbers[0]); // 100

            //2.passing by reference
            //Console.WriteLine(SumArray(ref Numbers));// 105 // passing by ref
            //Console.WriteLine(Numbers[0]);// 100 
            #endregion


            #region  passing parameter (reference type) EX02
            //int[] Numbers = { 1, 2, 3 };
            //1.passing by value
            //Console.WriteLine(SumArray(Numbers));//15
            //Console.WriteLine(Numbers[0]); 

            //2.passing by ref
            //Console.WriteLine(SumArray(ref Numbers));//15
            //Console.WriteLine(Numbers[0]); //4 
            #endregion

            #region Passing by out
            //passing by out
            //Console.WriteLine(SumMul(2, 5));
            //int[] Result = SumMul(2, 5);
            //Console.WriteLine(Result[0]);
            //Console.WriteLine(Result[1]);

            //int A = 3, B = 5;
            //NewData Result = SumMul(A, B);
            //Console.WriteLine(Result.Sum);
            //Console.WriteLine(Result.Mul);


            //int sum, mul;
            //sumMul(2, 5 , out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul); 
            #endregion

            //params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(SumArray2(Numbers));
        }
    }
}
