// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("enter a number greater than 100");
int num = Convert.ToInt32(Console.ReadLine());

void FindThirdDigit (int arg) {
    if (arg >= 1000) {
        while (arg > 1000) {
            arg = arg / 10;
        }
        int result = arg % 10;
        Console.WriteLine(result);
    }
    else if (arg < 1000 && arg >= 100) {
        int result = arg % 10;
        Console.WriteLine(result);
    }
    else {
        Console.WriteLine("no third digit");
    }
}

FindThirdDigit(num);
