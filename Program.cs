// часть 1 

// int[] numbers = [5, 2, 1, 4, 8];


// Console.WriteLine("До сортировки:");
// Console.WriteLine(string.Join(", ", numbers));

// BubbleSort(numbers);

// Console.WriteLine("После сортировки:");
// Console.WriteLine(string.Join(", ", numbers));

// void BubbleSort(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length - 1; i++)
//     {
//         for (int j = 0; j < numbers.Length - 1 - i; j++)
//         {
//             if (numbers[j] > numbers[j + 1])
//             {
//                 int temp = numbers[j];
//                 numbers[j] = numbers[j + 1];
//                 numbers[j + 1] = temp;
//             }
//         }
//     }
// }
// часть 2
// int[] numbers = { 5, 2, 8, 1, 4 };

// Console.WriteLine("До сортировки:");
// Console.WriteLine(string.Join(", ", numbers));

// SelectionSort(numbers);

// Console.WriteLine("После сортировки:");
// Console.WriteLine(string.Join(", ", numbers));


// void SelectionSort(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length - 1; i++)
//     {
//         int min = i;

//         for (int j = i + 1; j < numbers.Length; j++)
//         {
//             if (numbers[j] < numbers[min])
//             {
//                 min = j;
//             }
//         }

//         int temp = numbers[i];
//         numbers[i] = numbers[min];
//         numbers[min] = temp;
//     }
// }
// часть 3
// int[] numbers = { 5, 2, 4, 1 };

// Console.WriteLine("До сортировки:");
// Console.WriteLine(string.Join(", ", numbers));

// InsertionSort(numbers);

// Console.WriteLine("После сортировки:");
// Console.WriteLine(string.Join(", ", numbers));


// void InsertionSort(int[] numbers)
// {
//     for (int i = 1; i < numbers.Length; i++)
//     {
//         int temp = numbers[i];
//         int j = i - 1;

//         while (j >= 0 && numbers[j] > temp)
//         {
//             numbers[j + 1] = numbers[j];
//             j--;
//         }

//         numbers[j + 1] = temp;
//     }
// }
// int[] arr1 = { 5, 2, 8, 1, 4 };
// int[] arr2 = { 5, 2, 8, 1, 4 };
// int[] arr3 = { 5, 2, 8, 1, 4 };

// Console.WriteLine("Исходный массив:");
// Console.WriteLine(string.Join(", ", arr1));


// BubbleSort(arr1);


// SelectionSort(arr2);


// Array.Sort(arr3);

// Console.WriteLine("BubbleSort:");
// Console.WriteLine(string.Join(", ", arr1));

// Console.WriteLine("SelectionSort:");
// Console.WriteLine(string.Join(", ", arr2));

// Console.WriteLine("Array.Sort:");
// Console.WriteLine(string.Join(", ", arr3));


// List<int> values = [5, 2, 8, 1, 4];

// values.Sort();

// Console.WriteLine("List после Sort():");
// Console.WriteLine(string.Join(", ", values));


// void BubbleSort(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length - 1; i++)
//     {
//         for (int j = 0; j < numbers.Length - 1 - i; j++)
//         {
//             if (numbers[j] > numbers[j + 1])
//             {
//                 int temp = numbers[j];
//                 numbers[j] = numbers[j + 1];
//                 numbers[j + 1] = temp;
//             }
//         }
//     }
// }


// void SelectionSort(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length - 1; i++)
//     {
//         int min = i;

//         for (int j = i + 1; j < numbers.Length; j++)
//         {
//             if (numbers[j] < numbers[min])
//             {
//                 min = j;
//             }
//         }

//         int temp = numbers[i];
//         numbers[i] = numbers[min];
//         numbers[min] = temp;
//     }
// }
// в учебной работе мы писали свою сортировку, потому что нужно было понять как она работает
// итоговая задача
// List<int> results = new List<int>();

// Console.WriteLine("Введите количество участников:");

// if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
// {
//     Console.WriteLine("Ошибка! Введите положительное целое число.");
//     return;
// }


// for (int i = 0; i < count; i++)
// {
//     Console.WriteLine($"Введите результат участника №{i + 1}:");

//     if (!int.TryParse(Console.ReadLine(), out int res))
//     {
//         Console.WriteLine("Ошибка! Необходимо ввести целое число.");
//         return;
//     }

//     results.Add(res);
// }


// Console.WriteLine("\nРезультаты в исходном порядке:");
// Console.WriteLine(string.Join(", ", results));


// List<int> sorted = new List<int>(results);


// sorted.Sort();

// Console.WriteLine("Результаты по возрастанию:");
// Console.WriteLine(string.Join(", ", sorted));


// Console.WriteLine($"Лучший результат: {sorted[sorted.Count - 1]}");
// Console.WriteLine($"Худший результат: {sorted[0]}");


// Console.WriteLine("Три лучших результата:");

// int countTop = 3;

// if (sorted.Count < 3)
// {
//     countTop = sorted.Count;
// }

// for (int i = 0; i < countTop; i++)
// {
//     Console.WriteLine(sorted[sorted.Count - 1 - i]);
// }
// самостоятельные задания
// 1
// List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

// numbers.Sort();
// numbers.Reverse();

// Console.WriteLine("Сортировка по убыванию:");
// Console.WriteLine(string.Join(", ", numbers));
// 2
// List<int> numbers = new List<int> { 5, 2, 8, 1, 4 };

// SortNumbers(numbers, true);

// Console.WriteLine("По возрастанию:");
// Console.WriteLine(string.Join(", ", numbers));

// SortNumbers(numbers, false);

// Console.WriteLine("По убыванию:");
// Console.WriteLine(string.Join(", ", numbers));


// void SortNumbers(List<int> numbers, bool ascending)
// {
//     numbers.Sort();

//     if (ascending == false)
//     {
//         numbers.Reverse();
//     }
// }
// 3
int[] arr1 = new int[10];
int[] arr2 = new int[100];
int[] arr3 = new int[1000];

// Заполняем массивы
for (int i = 0; i < arr1.Length; i++)
{
    arr1[i] = (i * 37) % 101;
}

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = (i * 37) % 101;
}

for (int i = 0; i < arr3.Length; i++)
{
    arr3[i] = (i * 37) % 101;
}

// Сортируем массивы и получаем количество сравнений
BubbleSort(arr1, out int count1);
BubbleSort(arr2, out int count2);
BubbleSort(arr3, out int count3);

// Выводим результаты
Console.WriteLine($"Массив из 10 элементов: сравнений = {count1}");
Console.WriteLine($"Массив из 100 элементов: сравнений = {count2}");
Console.WriteLine($"Массив из 1000 элементов: сравнений = {count3}");


void BubbleSort(int[] numbers, out int comparisons)
{
    comparisons = 0;

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = 0; j < numbers.Length - 1 - i; j++)
        {
            comparisons++;

            if (numbers[j] > numbers[j + 1])
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
}