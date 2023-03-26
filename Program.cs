
class Program
{
    static void Main()
    {
        // Создание исходного массива строк
        string[] inputArray = { "hello", "2", "world", "-1-二", "1234", "1567", "-2", "computer science" };

        // Создание пустого массива строк для результата
        string[] resultArray = new string[inputArray.Length];

        // Переменная-счетчик для отслеживания индекса в массиве resultArray
        int index = 0;

        // Перебор каждой строки в исходном массиве
        for (int i = 0; i < inputArray.Length; i++)
        {
            // Проверка длины текущей строки и добавление в массив результатов
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        // Создание массива с результатами меньше или равными 3 символам
        string[] finalResultArray = new string[index];

        // Копирование значений из resultArray в finalResultArray
        Array.Copy(resultArray, finalResultArray, index);

        // Вывод результата на экран
        Console.WriteLine(string.Join(", ", finalResultArray));
    }
}
