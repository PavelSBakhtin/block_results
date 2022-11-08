// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.

string ReadData(string msg) // Принимает данные от пользователя.
{
    Console.Write(msg);
    string text = Console.ReadLine() ?? "0"; // конструкция ??"0" нивелирует ошибку NULL
    return text;
}

string[] FillArray(int length) // Создаёт массив.
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = ReadData("Enter any text or word: ");
    }
    return array;
}

void PrintArray(string[] array) // Выводит массив.
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int arrayLength = new Random().Next(3, 10);
string[] array = FillArray(arrayLength);
PrintArray(array);
