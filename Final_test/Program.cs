/* Задача: Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

Console.Clear();

/*

//  !!! Тест с вводом массива с клавиатуры:

int num = ReadInt("Введите число элементов массива: ");
int n1 = ReadInt("Введите максимальную длину элемента массива: ");
string[] testArrey4 = new string[num];
FillArrey1D(testArrey4);

//  Метод, позволяющий заполнить массив с клавиатуры:

void FillArrey1D(string[] arrey)
{
    Console.Write($"Введите {num} элементов массива: ");

    for (int i = 0; i < arrey.Length; i++)
    {
        arrey[i] = ReadStr();
    }
}

//  Метод, позволяющий вводить целочисленные значения с клавиатуры:

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

*/

//  Тест с примерами:

string[] testArrey1 = new string[4] { "hello", "2", "world", ":-)" };
string[] testArrey2 = new string[4] { "1234", "1567", "-2", "computer science" };
string[] testArrey3 = new string[3] { "Russia", "Denmark", "Kazan" };


PrintArrey1D(testArrey1);
string[] newArrey1 = SotrArrey1D(testArrey1, 3);
Console.Write(" --> ");
PrintArrey1D(newArrey1);
Console.WriteLine();
Console.WriteLine();

PrintArrey1D(testArrey2);
newArrey1 = SotrArrey1D(testArrey2, 3);
Console.Write(" --> ");
PrintArrey1D(newArrey1);
Console.WriteLine();
Console.WriteLine();

PrintArrey1D(testArrey3);
newArrey1 = SotrArrey1D(testArrey3, 3);
Console.Write(" --> ");
PrintArrey1D(newArrey1);
Console.WriteLine();
Console.WriteLine();


//  Метод сотрирует создаёт копию массива с элементами 
//  массива "arrey", длина которых меньше или ровна "num";

string[] SotrArrey1D(string[] arrey, int num)
{
    int count = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i].Length <= num)
        {
            count++;
        }
    }
    string[] newArreyStr = new string[count];
    int k = 0;
    for (int j = 0; j < arrey.Length; j++)
    {
        if (arrey[j].Length <= num)
        {
            newArreyStr[k] = arrey[j];
            k++;
        }
    }
    return newArreyStr;
}


void PrintArrey1D(string[] arrey)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write('"' + arrey[i] + '"');
        if (i != arrey.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

