// 1. Написать программу замену элементов массива на противоположные

/*int[] array = {2, 4, 3, 6, 7, 9, 29, 3, 8};
int length = array.Length;

for (int i = 0; i < length; i++)
{
    int tmp = array[i];
    array[i] = -tmp;
}

for (int i = 0; i < length; i++)
{
   Console.Write(array[i] + " ");
}
*/

/*int[] array = {2, 4, 3, 6, 7, 9, 29, 3, 8};
int length = array.Length;

for (int i = 0; i < length; i++)
{
     array[i] = - array[i];
     Console.Write(array[i] + " ");
}
*/

/*Console.WriteLine("Введите размер массива:");
int arrSize = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int [arrSize];                       
string OrigArray = "";
string RevArray = "";

for (int i = 0; i < arrSize; i++)
{
    array[i] = new Random().Next(1,100);
    OrigArray = OrigArray + $"{array[i]}";
}

Console.WriteLine($"Оригинальный массив: {OrigArray}");

for (int i = 0; i < arrSize; i++)
{
    array[i] = -array[i];
    RevArray = RevArray + $"{array[i]}";
}

Console.WriteLine($"Противоположный массив: {RevArray}");*/


/*Console.WriteLine("Введите размер массива:");
int arrSize = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int [arrSize];                       
string RevArray = "";

for (int i = 0; i < arrSize; i++)
{
    array[i] = new Random().Next(1,100);
    Console.WriteLine($"{array[i]}");
}
for (int i = 0; i < arrSize; i++)
{
    array[i] = -array[i];
    RevArray = RevArray + $"{array[i]}";
}

Console.WriteLine($" Противоположный массив: {RevArray}");*/


/*??????int [] array = {1, 2, 3, 4, 5, 6, 7, 8};
void change (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = 0 - array[i];
    }
}
void PrintArray(int [] array)
{
    int count = array.Length;
    for (int j = 0; j < count; j++)
    {
       Console.Write($"{array[j]}");
    }
}
void change1 (int [] array)
{
   int count = array.Length;
   for (int z = 0; z < (count / 2); z++)
    {
       int tmp = array[z];
       array[z] = array[((count - 1) - z)];
       array[((count - 1) - z)] = tmp;
    } 
}
change1(array);
PrintArray(array);*/