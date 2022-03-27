/*
Задача 1.
Задайте массив заполненый случайными положительными трёхзначными 
числами. Напишите программу, которая покажит количество чётных
чисел в массиве.
*/

int[] MakeArray()
{
    int[] arr = new int[5];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 999);
    }

    return arr;
}

void CountNum(int[] arg)
{
    int count = 0;

    for (int i = 0; i < arg.Length; i++)
    {
        if (arg[i] % 2 == 0) count++;
    }

    string arrStr = "";
    arrStr = arrStr + "[";

    foreach (int i in arg)
    {
        if (i == arg[arg.Length - 1]) arrStr += i + "]";
        else arrStr += i + ", ";
    }

    Console.WriteLine($"\nВ массиве {arrStr} чётных чисел {count}.\n");
}

CountNum(MakeArray());

/*
Задача 2.
Задайте одномерный массив, заполненый случайными числами. Найдите
сумму элементов, стоящих на нечётных позициях.
*/

/*
int[] MakeArray()
{
    int[] arr = new int[4];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

int SumElemArray(int[] arg)
{
    int result = 0;
    for (int i = 0; i < arg.Length; i++)
    {
        if (i % 2 != 0) result += arg[i];
    }
    return result;
}

string StrArray(int[] arg)
{
    string arrStr = "";
    arrStr += "[";
    
    for (int i = 0; i < arg.Length; i++)
    {
        if (i == arg.Length - 1) arrStr += arg[i];
        else arrStr += (arg[i] + ", ");
    }
    arrStr += "]";
    return arrStr;
}

int[] array = MakeArray();
int sumElem = SumElemArray(array);
string arrayElem = StrArray(array);

Console.WriteLine($"\nВ массиве {arrayElem}\n" +
                  $"сумма елементов стоящих на нечётных позициях " +
                  $"равна {sumElem}\n");
*/

/*
Задача 3.
Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.
*/

/*
double[] MakeArray()
{
    double[] arr = new double[5];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
    return arr;
}

void FindMinMaxElem(double[] arg)
{
    double resultMin = arg[0];
    double resultMax = arg[0];
    for (int i = 0; i < arg.Length; i++)
    {
        if (resultMin > arg[i]) resultMin = arg[i];
        if (resultMax < arg[i]) resultMax = arg[i];
    }
    Console.WriteLine("\nравна: {0:0.00}\n", resultMax - resultMin);
}

void PrintArray(double[] arg)
{
    Console.Write("[");
    for (int i = 0; i < arg.Length; i++)
    {
        if (i == arg.Length - 1) Console.Write("{0:f2}]", arg[i]);
        else Console.Write("{0:f2}, ", arg[i]);
    }
}

double[] arr = MakeArray();
Console.Write("\nРазница между максимальным и минимальным " +
              "значением массива:\n");
PrintArray(arr);
FindMinMaxElem(arr);
*/
