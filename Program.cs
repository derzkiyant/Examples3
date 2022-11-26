Task19();
Console.ReadKey();

Task21();
Console.ReadKey();

Task23();

void Task19()
{
    Console.WriteLine("\nЗадача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, " +
                        "является ли оно палиндромом.\n14212 -> нет\n12821 -> да\n23432 -> да");

    Console.Write("Введите положительное пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 9999 & number < 100000)
    {
        int currrentNumber = number;
        int palindrome = 0;

        while (currrentNumber > 0)
        {
            int remainder = currrentNumber % 10;
            palindrome = palindrome * 10 + remainder;
            currrentNumber /= 10;
        }

        if (number == palindrome) Console.WriteLine($"Число {number} является палиндромом");
        else Console.WriteLine($"Число {number} не является палиндромом");
    }

    else Console.WriteLine($"Введено неверное число");
}

void Task21()
{
    Console.WriteLine("\nЗадача 21: Напишите программу, которая принимает на вход координаты двух точек " +
                            "и находит расстояние между ними в 3D пространстве." +
                            "\nA(3,6,8); B(2, 1, -7) -> 15.84\nA(7, -5, 0); B(1, -1, 9) -> 11.53");

    Console.WriteLine("Введите координаты точки A:");
    Console.Write("xA: ");
    int xA = Convert.ToInt32(Console.ReadLine());
    Console.Write("yA: ");
    int yA = Convert.ToInt32(Console.ReadLine());
    Console.Write("zA: ");
    int zA = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты точки B:");
    Console.Write("xB: ");
    int xB = Convert.ToInt32(Console.ReadLine());
    Console.Write("yB: ");
    int yB = Convert.ToInt32(Console.ReadLine());
    Console.Write("zB: ");
    int zB = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Добавим 2 вспомогательные точки C и D, тогда:");

    int AD = xB - xA;
    Console.WriteLine($"Расстояние AD = xB - xA = {AD}");
    int BC = yB - yA;
    Console.WriteLine($"Расстояние BC = yB - yA = {BC}");
    int CD = zB - zA;
    Console.WriteLine($"Расстояние CD = zB - zA = {CD}");

    double AC = Math.Sqrt(Math.Pow(AD, 2) + Math.Pow(CD, 2));
    Console.WriteLine($"Расстояние AC = √((AD)^2 + (CD)^2) = {Math.Round(AC, 2)}");
    double AB = Math.Sqrt(Math.Pow(AC, 2) + Math.Pow(BC, 2));
    Console.WriteLine($"Искомое расстояние AB = √((AC)^2 + (BC)^2) = {Math.Round(AB, 2)}");
}

void Task23()
{
    Console.WriteLine("\nЗадача 23: Напишите программу, которая принимает на вход число (N) " +
                        "и выдаёт таблицу кубов чисел от 1 до N.\n3 -> 1, 8, 27\n5 -> 1, 8, 27, 64, 125");

    Console.Write("Введите число N: ");
    int N = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Число\tКуб");
    for (int i = 1; i <= N; i++)
    {
        double power = Math.Pow(i, 3);
        Console.WriteLine("{0}\t{1}", i, power);
    }
}
