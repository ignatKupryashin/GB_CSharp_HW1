//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

void Task2()
{
    Console.WriteLine("Данная пррограмма вычисляет какое число большее, а какое меньшее из двух чисел");
    Console.WriteLine("Введитте число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine()); //вводим первое число
    Console.WriteLine("Введитте число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine()); // вводим второе число

    if (number1 == number2)
    {
        Console.WriteLine("Числа равны между собой. Вы дважды ввели число  " + number1);
    }
    else if (number1 > number2)
    {
        Console.WriteLine("Число " + number1 + " является наибольшим, а число " + number2 + " является наименьшим.");
    }
    else
    {
        Console.WriteLine("Число " + number2 + " является наибольшим, а число " + number1 + " является наименьшим.");
    }
    Console.WriteLine(" "); //пустая строка для красоты
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

void Task4()
{
    Console.WriteLine("Данная пррограмма вычисляет максимальное число из трёх чисел");
    Console.WriteLine("Введитте число 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine()); //вводим первое число
    Console.WriteLine("Введитте число 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine()); // вводим второе число
    Console.WriteLine("Введитте число 2: ");
    int number3 = Convert.ToInt32(Console.ReadLine()); // вводим третье число
    int answer = number1;
    if (number2 > answer)
    {
        answer = number2;
    }
    if (number3 > answer)
    {
        answer = number3;
    }
    Console.WriteLine("Максимальным введённым числом является число " + answer);

    Console.WriteLine(" "); //пустая строка для красоты
}


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт , является ли число чётным (делится ли оно без остатка).

void Task6()
{
    Console.WriteLine("Данная пррограмма вычисляет, является ли чётным введённое число");
    Console.WriteLine("Введитте число:");
    int number1 = Convert.ToInt32(Console.ReadLine()); //вводим  число
    if (number1 % 2 == 0)
    {
        Console.WriteLine("Число " + number1 + " является чётным");
    }
    else
    {
        Console.WriteLine("Число " + number1 + " является нечётным");
    }
    Console.WriteLine(" "); //пустая строка для красоты
}

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

void Task8()
{
    Console.WriteLine("Данная пррограмма выводит все чётные числа от 1 до введённого числа");
    Console.WriteLine("Введитте число больше 0:");
    int number1 = Convert.ToInt32(Console.ReadLine()); //вводим  число
    int count = 2; //наименьшее чётное число по условиям задачи
    Console.WriteLine("Чётными числами от 1 до " + number1 + " являются: ");
    while (count <= number1)
    {
        Console.Write(count + " ");
        count += 2;
    }
    Console.WriteLine(" "); //пустая строка для красоты
    Console.WriteLine(" "); //пустая строка для красоты

}

//Запуск всех заданий поочерёдно. При меобходимости, любое задание можно закомментировать.

Task2();
Task4();
Task6();
Task8();