/*Задача 1

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

14212 -> нет

12821 -> да

23432 -> да
*/
System.Console.WriteLine("Введите число ");
string? text = Console.ReadLine();
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string result = new string(obrtext);
System.Console.WriteLine(result);
if (result == text)
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не палидром");
}
