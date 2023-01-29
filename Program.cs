// Написать программу которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равно 3 символа. Первонаяальный массив можно ввести с клавиатуры
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно  массивами. 
// Примеры:
// ["hello", "2", "world"] - вывод ["2"]



Console.WriteLine("Введите количество строк в массиве");
int count = int.Parse(Console.ReadLine());

string[] enteredArray = GettArray(count);
Console.WriteLine();

PrintArray(enteredArray);
Console.WriteLine();

int countStrings = CountStringsWhereLessThreeSymbols(enteredArray);
string[] newArray = ArrayWithLessThreeSymbolsInString(countStrings, enteredArray);
Console.WriteLine();

PrintArray(newArray);

string[] GettArray(int countStr)
{
    string[] enteredStringInArray = new string[countStr];
    for (int i = 0; i < enteredStringInArray.Length; i++)
    {
        Console.WriteLine("Введите строку в массиве");
        enteredStringInArray[i] = Console.ReadLine();
    }
    return enteredStringInArray;
}
void PrintArray(string[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + ", ");
    }
}

int CountStringsWhereLessThreeSymbols(string[] entArray)
{
    int countStringsWithSymbolsLessThree = 0;
    for (int str = 0; str < entArray.Length; str++)
    {
        if (entArray[str].Length <= 3)
        {
            countStringsWithSymbolsLessThree += 1;
        }
    }
    return countStringsWithSymbolsLessThree;
}

string[] ArrayWithLessThreeSymbolsInString(int countStrings, string[] enteredArray)
{
    int numberStrings = 0;
    string[] lessThreeSymbols = new string[countStrings];
    for (int i = 0; i < enteredArray.Length; i++)
    {
        if (enteredArray[i].Length <= 3)
        {
            lessThreeSymbols[numberStrings] = enteredArray[i];
            numberStrings += 1;
        }
    }
    return lessThreeSymbols;
}
