using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            ShowTaskMenu();
            string input = Console.ReadLine();

            try
            {
                int taskNumber = int.Parse(input);
                Console.Clear();

                switch (taskNumber)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    case 6: Task6(); break;
                    case 7: Task7(); break;
                    case 8: Task8(); break;
                    case 9: Task9(); break;
                    case 10: Task10(); break;
                    default: Console.WriteLine("Неверный номер задачи."); break;
                }

                Console.WriteLine("\nЗадача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Введите число.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ReadKey();
            }
        }
    }


    static void ShowTaskMenu()
    {
        Console.WriteLine("Выберите номер задания:");
        Console.WriteLine("1. Программа, которая принимает четыре числа и находит среднее значение между ними");
        Console.WriteLine("2. Программа-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:");
        Console.WriteLine("3. Программа для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
        Console.WriteLine("4. Программа, которая позволяет определить имя файла (с расширением) по введенному пути");
        Console.WriteLine("5. Программа для нахождения самого длинного слова в предложении");
        Console.WriteLine("6. Программа, которая может перемножить два массива значений");
        Console.WriteLine("7. Программа, которая может найти максимальное и минимальное число из пяти введенных");
        Console.WriteLine("8. Программа, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
        Console.WriteLine("9. Часть 2. 1. Напечатать полную таблицу умножения");
        Console.WriteLine("10. Часть 3. 1. программа, которая на основе выбранно действия выполняет действие");
    }


    static void Task1()
    {
        Console.WriteLine("Задача 1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");

        Console.WriteLine("Введите четыре числа через пробел:");
        string[] input = Console.ReadLine().Split(' ');

        if (input.Length != 4)
        {
            Console.WriteLine("Необходимо ввести четыре числа.");
            return;
        }

        double sum = 0;
        try
        {
            foreach (string numStr in input)
            {
                sum += double.Parse(numStr);
            }
            double average = sum / 4;
            Console.WriteLine($"Среднее значение: {average}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод. Введите числа.");
        }
    }

    static void Task2()
    {

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите два числа (через enter):");

            double num1, num2;
            try
            {
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Введите числа.");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine($"Вы ввели числа: {num1} и {num2}");
            Console.WriteLine("Какое действие выполнить?");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Нахождение остатка");
            Console.WriteLine("6. Выход");


            string operationChoice = Console.ReadLine();

            try
            {
                int choice = int.Parse(operationChoice);
                double result = 0;
                string operation = "";

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        operation = "+";
                        break;
                    case 2:
                        result = num1 - num2;
                        operation = "-";
                        break;
                    case 3:
                        result = num1 * num2;
                        operation = "*";
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Деление на ноль невозможно!");
                            Console.ReadKey();
                            continue;
                        }
                        result = num1 / num2;
                        operation = "/";
                        break;
                    case 5:
                        result = num1 % num2;
                        operation = "%";
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор действия.");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine($"Результат: {num1} {operation} {num2} = {result}");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Введите число.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
    static void Task3()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите шкалу вводимой температуры:");
            Console.WriteLine("1. Цельсий");
            Console.WriteLine("2. Кельвин");
            Console.WriteLine("3. Фаренгейт");
            Console.WriteLine("4. Выход");

            string inputScale = Console.ReadLine();

            try
            {
                int inputScaleChoice = int.Parse(inputScale);

                if (inputScaleChoice == 4) return;


                Console.WriteLine("Введите показатель температуры (градусы):");
                double temperature;
                if (!double.TryParse(Console.ReadLine(), out temperature))
                {
                    Console.WriteLine("Некорректный ввод температуры.");
                    Console.ReadKey();
                    continue;
                }


                Console.WriteLine("Выберите тип шкалы для конвертации:");
                Console.WriteLine("1. Цельсий");
                Console.WriteLine("2. Кельвин");
                Console.WriteLine("3. Фаренгейт");

                string outputScale = Console.ReadLine();
                int outputScaleChoice;
                if (!int.TryParse(outputScale, out outputScaleChoice) || outputScaleChoice < 1 || outputScaleChoice > 3)
                {
                    Console.WriteLine("Некорректный выбор шкалы для конвертации.");
                    Console.ReadKey();
                    continue;
                }

                double result = ConvertTemperature(inputScaleChoice, outputScaleChoice, temperature);
                string inputScaleName = GetScaleName(inputScaleChoice);
                string outputScaleName = GetScaleName(outputScaleChoice);

                Console.WriteLine($"Вы выбрали: {inputScaleName}->{outputScaleName}");
                Console.WriteLine($"Результат конвертации: {result:F1}");
                Console.ReadKey();

            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ReadKey();
            }
        }
    }

    static double ConvertTemperature(int inputScale, int outputScale, double temperature)
    {
        switch (inputScale)
        {
            case 1: // Цельсия
                switch (outputScale)
                {
                    case 2: return temperature + 273.15; // Цельсий -> Кельвин
                    case 3: return temperature * 9 / 5 + 32; // Цельсий -> Фаренгейт
                    default: return temperature; // Цельсий -> Цельсий
                }
            case 2: // Кельвин
                switch (outputScale)
                {
                    case 1: return temperature - 273.15; // Кельвин -> Цельсий
                    case 3: return (temperature - 273.15) * 9 / 5 + 32; // Кельвин -> Фаренгейт
                    default: return temperature; // Кельвин -> Кельвин
                }
            case 3: // Фаренгейт
                switch (outputScale)
                {
                    case 1: return (temperature - 32) * 5 / 9; // Фаренгейт -> Цельсий
                    case 2: return (temperature - 32) * 5 / 9 + 273.15; // Фаренгейт -> Кельвин
                    default: return temperature; // Фаренгейт -> Фаренгейт
                }
            default: return temperature; // Неизвестная шкала
        }
    }

    static string GetScaleName(int scale)
    {
        switch (scale)
        {
            case 1: return "Цельсий";
            case 2: return "Кельвин";
            case 3: return "Фаренгейт";
            default: return "Неизвестная шкала";
        }
    }

    static void Task4()
    {
        Console.WriteLine("Введите путь до файла:");
        string filePath = Console.ReadLine();

        try
        {
            string fileName = Path.GetFileName(filePath);

            if (fileName != null)
            {
                Console.WriteLine($"Имя файла: {fileName}");
            }
            else
            {
                Console.WriteLine("Некорректный путь к файлу.");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }

    static void Task5()
    {
        Console.WriteLine("Введите предложение:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries); 

        if (words.Length == 0)
        {
            Console.WriteLine("Предложение пустое.");
            return;
        }

        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Самое длинное слово: {longestWord}");
        Console.ReadKey();
    }

    static void Task6()
    {
        Console.WriteLine("Введите значения для первого массива через пробел:");
        string input1 = Console.ReadLine();
        int[] arr1 = ParseIntArrayFromInput(input1); 

        Console.WriteLine("Введите значения для второго массива через пробел:");
        string input2 = Console.ReadLine();
        int[] arr2 = ParseIntArrayFromInput(input2); 

        if (arr1 == null || arr2 == null || arr1.Length != arr2.Length)
        {
            Console.WriteLine("Ошибка: массивы должны быть одинаковой длины и содержать только числа.");
            return;
        }

        int[] result = new int[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = arr1[i] * arr2[i];
        }

        Console.WriteLine("Результат: " + string.Join(" ", result));
        Console.ReadKey();
    }

    static int[] ParseIntArrayFromInput(string input) 
    {
        try
        {
            return input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: некорректный ввод. Введите числа через пробел.");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
            return null;
        }
    }

    static void Task7()
    {
        Console.WriteLine("Введите пять чисел:");
        string input = Console.ReadLine();

        int[] numbers = ParseIntArray(input);

        if (numbers == null || numbers.Length != 5)
        {
            Console.WriteLine("Ошибка: необходимо ввести пять чисел через пробел.");
            return;
        }

        int maxNumber = numbers.Max();
        int minNumber = numbers.Min();

        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
        Console.ReadKey();
    }

    static int[] ParseIntArray(string input) 
    {
        try
        {
            return input.Split(' ').Select(int.Parse).ToArray();
        }
        catch (FormatException)
        {
            return null;
        }
    }


    static void Task8()
    {
        Console.WriteLine("Введите количество ступеней:");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int numSteps) || numSteps <= 0)
        {
            Console.WriteLine("Ошибка: необходимо ввести положительное целое число.");
            return;
        }

        for (int i = 1; i <= numSteps; i++)
        {
            string row = "";
            for (int j = 1; j <= i; j++)
            {
                row += j;
            }
            Console.WriteLine(row);
        }

        Console.ReadKey();
    }


    static void Task9()
    {
        for (int i = 1; i <= 9; i++)
        {
            string row = "";
            for (int j = 1; j <= 9; j++)
            {
                row += $"{i} x {j} = {i * j}\t"; 
            }
            Console.WriteLine(row);
        }
        Console.ReadKey();
    }


    static void Task10()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Вывести числа от 1 до 100");
            Console.WriteLine("2. Вывести числа от -100 до 5");
            Console.WriteLine("3. Вывести четные числа от 1 до 100");
            Console.WriteLine("4. Выход");

            string input = Console.ReadLine();

            try
            {
                int choice = int.Parse(input);
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        PrintNumbers1To100();
                        break;
                    case 2:
                        PrintNumbersMinus100To5();
                        break;
                    case 3:
                        PrintEvenNumbers1To100();
                        break;
                    case 4:
                        return; 
                    default:
                        Console.WriteLine("Неверный выбор действия.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
                Console.ReadKey();
            }
        }
    }

    static void PrintNumbers1To100()
    {
        Console.WriteLine("Числа от 1 до 100:");
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void PrintNumbersMinus100To5()
    {
        Console.WriteLine("Числа от -100 до 5:");
        for (int i = -100; i <= 5; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void PrintEvenNumbers1To100()
    {
        Console.WriteLine("Четные числа от 1 до 100:");
        for (int i = 2; i <= 100; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
    
    
