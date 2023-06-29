/* Задача 34: Задайте массив заполненный случайными
 положительными трёхзначными числами.
Напишите программу, которая покажет количество
 чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/



int [] CreateArray(int size, int min, int max){ 
    int [] array = new int [size]; 
    Random rand = new Random(); 
 
    for (int i = 0; i < size; i++) 
    { 
        array [i] = rand.Next(min, max+1); 
    } 
    Console.WriteLine($"[{string.Join(", ", array)}]"); 
    return array; 
} 
 
int FindEvenNumbers (int [] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2 == 0)
                {
                    count +=1;
                }
            }
            return count;
    }


int [] arr = CreateArray (10 ,100,999);
int count = FindEvenNumbers(arr);
Console.WriteLine($"count of even number here is  : {count}");
