// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



string[] array = [ "hv", "jjvfg","bfdjk","hfu" ];

char[,] CreateResult{
    char 
    return array;
}

int len0 = array.GetLength(0);
Console.WriteLine(len0);
for (int i=0;i<len0;i++){
    string temp = array[i];
    int lentemp = temp.Length;
    for (int j=0;j<lentemp;j++){
        Console.Write(temp[j]+" ");
 }
 Console.WriteLine();
 }

string[] result = new string[len0];
int t = 0;
Console.WriteLine();

for (int i=0;i<len0;i++){
    string temp = array[i];
    int lentemp = temp.Length;
    if (lentemp<=3){
        result[t]=temp;
        t=t+1;
    }   
 }

Console.Write("[");
int LenRes=result.Length;
for (int i=0;i<t;i++){
   Console.Write(result[i]); 
   if (i!=t-1)
    Console.Write(", "); 
 }
Console.Write("]");