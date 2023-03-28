// Описываем метод создания строчного массива, принимающего n - количество элементов массива
// пользователь вводит размер массива (количество элементов)
// пользователь вводит текст строки под каждый элемнет массива
string [] CreateArray(int n)
{
    string [] str = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите элемент: "+ i);
        string text = Convert.ToString(Console.ReadLine());
        str[i] = text;
    }
    return str;
}
// Описываем метод вывода на экран заданного пользователем строчного массива
void ShowArray(string [] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write('"' + str[i] + '"' + "," + " ");
    }        
    Console.WriteLine();
}
// Описываем метод для вычисления размера итогового строчного массива
int SizeArray1(string [] str, int n)
{
    int i = 0;
    while (i < str.Length)
    {
        int si = str[i].Length;
        if (si > 3)
        {
            n = n - 1;
        }
    i++;
    }
    Console.WriteLine("размер итогового массива: " + n);//выводим размер итогового строчного массива
    return n;
}
// Описываем метод для создания итогово строчного массива
string [] CreateArray1(string [] str, int n)
{
    string [] str1 = new string [n];
    int i = 0;
    int j = 0;
    while (i < str.Length)
    {
        int si = str[i].Length;
        if (si < 4)
        {
            str1[j] = str[i];
            j = j + 1;
        }
    i++;
    }
    return str1;
}
// Ввод и примение в заявленных метода параметров от пользователя
Console.WriteLine("Введите количество n: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] str = CreateArray(n);
Console.WriteLine();
ShowArray (str);
Console.WriteLine();
int n1 = SizeArray1(str, n);
string[] str1 = CreateArray1(str, n1);
ShowArray (str1);