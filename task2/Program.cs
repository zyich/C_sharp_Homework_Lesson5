/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SumOddNumbers ( int [] array)
    {
        int sum = 0;
        
        for (int i = 1; i < array.Length; i+=2)
            {
                sum += array[i];
            }

        return sum;

    }
     

int [] arr = CreateArray (6, -5, 4);
int sum = SumOddNumbers(arr);
Console.WriteLine($" Sum of numbers in odd position in array is : {sum}");