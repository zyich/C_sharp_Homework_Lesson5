/*
Задача 38: Задайте массив вещественных чисел. Найдите 
разницу между максимальной
 и минимальной вещественной частью
 элементов массива.
[3.01, 4.2, 1.15, 77.15, 65.3] => 0.29
*/
double[] CreateArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = array[i] = rand.NextDouble() * (maxValue - minValue) + minValue;
    }

    return array;
}

double FindMaxRemaindernumber (double []array)
    {
        double MaxRem = 0;
        
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] > MaxRem )
        MaxRem = array[i];

      }
    
       return MaxRem;     
    }   
    
double FindMinRemainderNumber (double []array)
    {
        double MinRem = array[0] ;


foreach (double num in array)
{
    if (num < MinRem)
    {
        MinRem = num;

    }

      }
    return MinRem;
    }
double[] arr = CreateArray(4, 1,10);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
double max = FindMaxRemaindernumber(arr);
double min = FindMinRemainderNumber(arr);
Console.WriteLine($"max number here is {max} and  min number here is {min}");

