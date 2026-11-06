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
