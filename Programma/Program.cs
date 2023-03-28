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

Console.WriteLine("Введите количество n: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] str = CreateArray(n);
ShowArray (str);
