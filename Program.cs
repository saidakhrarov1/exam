/*Задача:Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
 либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/


void Main()

{
    string[] array = AskWords("Введите элементы массива через пробел: ");
    CreateArray(array);
    ArrayPrint(CreateArray(array));
}

string[] CreateArray(string[] array)
{
    int count = 0;
    foreach (string word in array)
    {
        if (word.Length <= 3)
        {
            count++;
        }
    }

    string[] NewArray = new string[count];
    int index = 0;

    foreach (string word in array)
    {
        if (word.Length <= 3)
        {
            NewArray[index] = word;
            index++;
        }
    }
    return NewArray;
}

    string[] AskWords(string msg)
    {
        System.Console.WriteLine(msg);
        string[] tempArray = Console.ReadLine()!.Split(' ');
        return tempArray;
    }

    void ArrayPrint(string[] array)
    {
        foreach (string word in array)
        {
            System.Console.Write(word + ", ");
        }
    }

    Main();