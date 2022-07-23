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

string[] MainTask(string[] inputStringArray, int criterion)
{
    int Length(string[] array, int criterion)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length <= criterion)
                count++;
        return count;
    }

    int count = inputStringArray.Length;
    string[] outputStringArray = new string[Length(inputStringArray, 3)];
    int i = 0;
    int index = 0;
    while(i < count)
    {
        if(inputStringArray[i].Length <= criterion)
        {
            outputStringArray[index] = inputStringArray[i];
            index = index + 1;
        }
        i = i + 1;
    }

    return outputStringArray;
}

void PrintArray(string[] input, string[] output)
{
    Console.Write("[");
    for (int i = 0; i < input.Length; i++)
        if(i == input.Length - 1)
            Console.Write("\"{0}\"] -> [",input[i]);
        else
            Console.Write("\"{0}\", ",input[i]);
    for(int i = 0; i < output.Length; i++)
        if (i == output.Length - 1)
             Console.Write("\"{0}\"]", output[i]);
        else
            Console.Write("\"{0}\", ", output[i]);
}