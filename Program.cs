// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// function generates the entrance string from the introduced values
string CreateArray() {
    string NewElevent = Console.ReadLine();
    string Array="";
    while (NewElevent!=""){
        Array+=NewElevent;
        Array+="~";
        NewElevent = Console.ReadLine();
    }
    return Array;
}

//function converts array to string 
string[] StrToArray(string str){
    int len = LenRes(str);

    int LenRes(string str){
    int len=0;
    int i = 1;
    while (i<str.Length){
        if (str[i].ToString()=="~"){
            len = len+1;
        }
        i=i+1;
    }
    return len;
    }
    string[] result = new string[len];
    string Turn="";
    int Len = 0;
     for(int j=0;j<str.Length;j++){
        if (str[j].ToString()=="~"){
           result[Len]=Turn;
           Turn="";
           Len=Len+1;
        }
        else if(j==str.Length-1) {
            Turn = Turn +str[j];
            result[Len]=Turn;
        }
        else{
            Turn = Turn +str[j];
        }
    }
    return result;
}

//function generates an output array (of three elements)
string[] Three(string[] array){
    int len = 0;
    for (int i=0;i<array.GetLength(0);i++){
        if (array[i].Length<=3){
            len=len+1;
        }
    }

    string[] result = new string[len];
    int len1 = 0;
     for (int i=0;i<array.GetLength(0);i++){
        if (array[i].Length<=3){
            result[len1]=array[i];
            len1=len1+1;
        }
    }

    return result;
}

//function beautiful prints array
void PrintArray(string[] result){
    int len = result.GetLength(0);
    Console.Write("[");
    for (int i=0;i<len;i++){
        if (i!=(len-1))
            Console.Write("'"+result[i]+"'"+", ");
        else
            Console.Write("'"+result[i]+"'");
    }
    Console.Write("]");
}

//function beautifuly calls all functions
 void main(){
    Console.WriteLine("This program outputs all three-digit elements.");
    Console.WriteLine("Enter some values. After print each value press 'Enter'");
    Console.WriteLine("!!!Plese, don't use simbole '~'!!!");
    Console.WriteLine("If you introdusted sufficent quantivalues values press 'Enter' whithout values!");
    string str = CreateArray();
    Console.Write("Your array: ");
    PrintArray(StrToArray(str));
    Console.WriteLine();
    Console.Write("Your array the result: ");
    PrintArray(Three(StrToArray(str)));
 }

main();