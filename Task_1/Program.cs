// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int length = 0;
string strNumber = String.Empty;
while(length != 5)
{
    Console.WriteLine("Enter five-digit number");
    strNumber = Console.ReadLine();
    length = strNumber.Length;
}
int i = 0;
while(i < length / 2)
{
    if(strNumber[i] != strNumber[length - i - 1])
    {
        Console.WriteLine("Number isn't palindrom");
        return;
    }
    i++;
}
Console.WriteLine("Number is palindrom");
