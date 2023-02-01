Console.WriteLine ("Сколько чисел будем проверять?");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Вводите числа:");
int number = 0;
int result = 0;
for (int i = 0; i < count; i++)
    {
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)  result += 1;
    }
Console.WriteLine ($"Вы ввели {result} чисел больше нуля");
