

#region Value And Reference Type
/*
 * 1 -
          // Value type Parameter by value

        static void Swap(int x,int y)
        {
           Console.WriteLine("swapping");
            int Temp = x;
            x = y;
           y = Temp;
        }
            //  Value type Parameter by Ref 
static void ReferSwap( ref int x,ref int y)
{
    Console.WriteLine(" Before  swapping");
    int Temp = x;
    x = y;
    y = Temp;
}
int A = 5;
int B = 8 ;
Console.WriteLine($"A ={A}");
Console.WriteLine($"B ={B}");
Swap(A,B);
Console.WriteLine($"A ={A}");
Console.WriteLine($"B ={B}");

Console.WriteLine(" Swapping by passing reference type ");
Console.WriteLine($"A ={A}");
Console.WriteLine($"B ={B}");
ReferSwap( ref A, ref B);
Console.WriteLine($"A ={A}");
Console.WriteLine($"B ={B}");

*/

/*
 * 2 -
using System.Reflection.Metadata.Ecma335;

static int SumArr(int[] Arr)
{
    int Sum = 0;
    if(Arr is not null)
    {
        for(int i = 0; i < Arr.Length; i++)
        {
            Sum += Arr[i];
        }
    }
    return Sum;
}


static int SumArray( ref int[] Arr)
{
    int Sum = 0;
    if (Arr is not null)
    {

        Arr[0] = 100;
        for (int i = 0; i < Arr.Length; i++)
        {
            Sum += Arr[i];
        }
    }
    return Sum;
}

int [] NumbersArr = [2 , 6, 8];
int total = SumArray( ref NumbersArr);
Console.WriteLine(total);
Console.WriteLine(NumbersArr[0]);
*/

/*
 * 3 -
 static bool IsPrime(int number)
{
    if (number <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if(number % i == 0) return false;
    }
    return true;
}


Console.WriteLine("Please enter your integer number");
int number =int.Parse(Console.ReadLine());
bool result =IsPrime(number);
Console.WriteLine($"The result is {result}");   


*/




using System.Globalization;

static void MinMaxArray(int[] arr, ref int min, ref int max)
{
   min =arr[0];
    max = arr[0];

    foreach (var num in arr)
    {
        if(num < min) min = num;
        if(num > max) max = num;
        
    }
}

int[] numbers = { 1, 3, 6, 8, 9, 10, 7 };
int min = 0;
int max = 0;

MinMaxArray(numbers, ref min, ref max);
Console.WriteLine($"Minimum value: {min}");
Console.WriteLine($"Maximum value: {max}");





#endregion

