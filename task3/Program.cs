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
        if (array[i]%1.0 > MaxRem%1.0 )
        MaxRem = array[i];
      }
      return MaxRem%1.0 ;     
    }   
    
double FindMinRemainderNumber (double []array)
    {
        double MinRem = array[0] ;
        foreach (double num in array)
            {
                if (num%1.0 < MinRem%1.0)
                    {
                         MinRem = num;

                    }

            }
            return MinRem%1.0;
    }


double[] arr = CreateArray(5, 1,3);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
double max = FindMaxRemaindernumber(arr);
double min = FindMinRemainderNumber(arr);
double  difference =  max -  min ; 
Console.WriteLine($"max remainder  here is {max} and  min remaider here is {min} and difference between max and min is {difference}");

