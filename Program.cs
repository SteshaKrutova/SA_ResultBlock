using System.Xml.XPath;

Console.WriteLine("Hello, World!");
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// функция формирует входную строку
string CreateArray() {
    string NewElevent = Console.ReadLine();
    string Array="";
    while (NewElevent!=""){
        Array+=NewElevent;
        Array+=" ";
        NewElevent = Console.ReadLine();
    }
    return Array;
}

string str = CreateArray();

// //функция определяет сколько в выходной строке элементов
int len=1;
int LenRes(string str){
    int i = 1;
    while (i<str.Length){
        if (str[i].ToString()==" "){
            len = len+1;
        }
        i=i+1;
    }
    return len;
}

LenRes(str);
string[] result = new string[len];

string[] StrToArray(string str){
    string Turn="";
    int Len = 0;
     for(int j=0;j<str.Length;j++){
        if (str[j].ToString()==" "){
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
 
StrToArray(str);

// for (int i=0;i<result.GetLength(0);i++){
//     Console.WriteLine(result[i]);
// }

//функция формирует выходную строку

string[] array = StrToArray(str);


string[] Three(string[] array){
    int len = 0;
    for (int i=0;i<array.GetLength(0);i++){
        if (array[i].Length>=3){
            len=len+1;
        }
    }

    string[] result = new string[len];
    int len1 = 0;
     for (int i=0;i<array.GetLength(0);i++){
        if (array[i].Length>=3){
            result[len1]=array[i];
            len1=len1+1;
        }
    }

    for (int i=0;i<result.GetLength(0);i++){
    Console.WriteLine(result[i]);
    }
    return result;
}

Three(array);


// //функция формирует выходную строку
// string Three(string array){
//     string result = "";
//     string Tern = "";
//     int len = array.Length;
//     for (int i=0;i<len;i++){
//         if (array[i].ToString()!=" "){
//            Tern+=array[i];
//         }
//         else{
//             if (Tern.Length<=3){
//                 result+=Tern;
//                 result+=" ";
//                 Tern="";
//             }
//                 Tern="";
//         }
//     }
//     return result;
// }



// void PrintArray(string result){
//     int len = result.Length;
//     string Tern ="";
//     Console.Write("[");
//     for (int i=0;i<len;i++){
//         if (result[i].ToString()!=" "){
//            Tern+=result[i];
//         }
//         else{
//             if (i!=Tern.Length){
//                 Console.Write(",");
//             }
//             Console.Write("'"+Tern+"'");
//             Tern="";
//         }
//     }
//     Console.Write("]");
// }

// void main(){
//     Console.WriteLine("Enter some values. After print each value press 'Enter'");
//     Console.WriteLine("If you introdusted sufficent quantivalues values press 'Enter' whithout values!!!");
//     string array = CreateArray();
//     Console.WriteLine("Your values: "+array);
//     Console.Write("Your resul in if his data type an array: ");
//     PrintArray(Three(array));
// }

// //main();

// void ThreWithDouble(){
//     string[] StrRes=new string[100];
//     int i=0;
//     string TempStr= Console.ReadLine();
//     while(TempStr!=""){
//         if (TempStr.Length<=3)
//             StrRes[i]=TempStr;
//             i=i+1;
//         TempStr= Console.ReadLine();
//     }
//     for (int j=0;j<i;j++){
//         Console.Write(StrRes[j]+" ");
//     }
// }
// ThreWithDouble();
