Console.WriteLine("Добрый день!!!");
Console.Write("Введите, пожалуйста, первое число для деления - А: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите, пожалуйста, второе число для деления - Б: ");
double b = double.Parse(Console.ReadLine());

double c = a/b;

Console.Write("Результат деления А/Б:   ");
Console.WriteLine(c);