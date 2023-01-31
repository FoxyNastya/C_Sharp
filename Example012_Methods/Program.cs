/*
1. Группа методов. Ничего не принимают, ничего не возвращают. Void
*/
/*
void Method1()
{
    Console.WriteLine("Автор....");
}

Method1();
*/

/*
2. Методы, которые ничего не возвращают, но могут принимать агрументы
*/
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg:"Текст", count: 4);
Method21(count: 4, msg: "новый текст");
*/
// 3. Методы что-то возвращают, но ничего не принимают

/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/

// 4. Методы, которые что-то принимают и что-то возвращают
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z ");
Console.WriteLine(res);

--------------------------------------------
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z ");
Console.WriteLine(res);


for (int i = 2; i<= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
*/

// Задача. В тексте нужно все пробелы заменить черточками, маленькие "к" 
// заменить большими "К", а большие "С" заменить на "с"


/*string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгороде,"
            + "вы бы вязли присутпом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
*/
// string s = "qwerty
//             012345
// s[3] // r
/*
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;

}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine( );

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine( );

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
Console.WriteLine( );
*/

// Сортировка массива


int[] arr = {1, 2, 3, 4, 5, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);


PrintArray(arr);