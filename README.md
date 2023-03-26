// Создание исходного массива строк
input_array = ["hello", "2", "world", "-1-二", "1234", "1567", "-2", "computer science"]

// Создание пустого массива строк для результата
result_array = []

// Перебор каждой строки в исходном массиве
for i = 0 to length(input_array) - 1 do
    // Проверка длины текущей строки и добавление в массив результатов
    if length(input_array[i]) <= 3 then
        add input_array[i] to result_array
    end if
end for

// Вывод результата на экран
print result_array
