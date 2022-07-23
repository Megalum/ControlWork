//1. Создание массива
//2. Заполнение массива
//  2.1. Подсчет строк удовлетворяющий условию 
//3. Основная задача
//4. Печать массива

string[] CreateArray(int count)
{
    return new string[count];
}

void FillArray(string[] array)
{
    Console.WriteLine("Введите массив строк:");
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
}

int Length(string[] array, int criterion)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= criterion)
            count++;
    return count;
}