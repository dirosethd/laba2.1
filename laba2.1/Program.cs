try
{  
  Console.WriteLine("Введите число:");
    int a = int.Parse(Console.ReadLine());
    if ((a % 10 == 0) && (a % 3 != 0)) Console.WriteLine("Правильно");
    else Console.WriteLine("Неправильно");
}
catch
{
    Console.WriteLine("Введите правильно");
}

