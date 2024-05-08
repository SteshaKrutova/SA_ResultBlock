Console.WriteLine("Hello, World!");
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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

string Three(string array){
    string result = "";
    string Tern = "";
    int len = array.Length;
    for (int i=0;i<len;i++){
        if (array[i].ToString()!=" "){
           Tern+=array[i];
        }
        else{
            if (Tern.Length<=3){
                result+=Tern;
                result+=" ";
                Tern="";
            }
                Tern="";
        }
    }
    return result;
}

void PrintArray(string result){
    int len = result.Length;
    string Tern ="";
    Console.Write("[");
    for (int i=0;i<len;i++){
        if (result[i].ToString()!=" "){
           Tern+=result[i];
        }
        else{
            if (i!=Tern.Length){
                Console.Write(",");
            }
            Console.Write("'"+Tern+"'");
            Tern="";
        }
    }
    Console.Write("]");
}

void main(){
    Console.WriteLine("Enter some values. After print each value press 'Enter'");
    Console.WriteLine("If you introdusted sufficent quantivalues values press 'Enter' whithout values!!!");
    string array = CreateArray();
    Console.WriteLine("Your values: "+array);
    Console.Write("Your resul in if his data type an array: ");
    PrintArray(Three(array));
}

main();


