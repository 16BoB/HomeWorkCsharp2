// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter a three-digit number");
int num = Convert.ToInt32(Console.ReadLine());

void FindSecondDigit (int arg) {
    if (arg >= 100) {
        int result = (num % 100) / 10;
        Console.WriteLine(result);
    }
    else {
        Console.WriteLine("number is not three digits");
    }
}

FindSecondDigit(num);