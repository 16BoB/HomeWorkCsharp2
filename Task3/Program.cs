// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Enter the number of the day of the week");
int num = Convert.ToInt32(Console.ReadLine());

void FindDate (int arg) {
    if (7 >= arg && arg >= 6)
    {
        Console.WriteLine("This day is a day off");
    }
    else if (arg == 0 || arg > 7) {
        Console.WriteLine("There is no such day in the week");
    }
    else {
        Console.WriteLine("This day is not a holiday");
    }
}

FindDate(num);