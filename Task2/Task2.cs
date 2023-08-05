using System;

Console.WriteLine("Введите число:");
var number = Convert.ToInt32(Console.ReadLine());

bool checkPalindrom(int number)
{
    int num = 0;
    int key = number;
    int reverse = 0;
    bool check;

    for(int i = 1; number!=0; i++)
    {
        num = number % 10;
        number = number / 10;
        reverse = num + (reverse * 10);
    }

    if (reverse == key) return true;
    else return false;
}

Console.WriteLine(checkPalindrom(number)); 