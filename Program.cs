// Задача: Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите количество элементов:");
int size = Convert.ToInt32(Console.ReadLine());
string[]words = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент:");
    words[i] = Console.ReadLine();
}

void PrintArray(string[] array)
{
    Console.Write("\"" + array[0] + "\"");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write(", " + "\"" + array[i] + "\"");
    }
    Console.WriteLine();
}

int ShortElement(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillArray(string[] array)
{
    int i = 0;
    string[] result = new string[ShortElement(array)];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            result[i] = array[j];
            i++;
        }
    }
    return result;
}

Console.WriteLine();
PrintArray(words);
if(ShortElement(words)!=0) PrintArray(FillArray(words));