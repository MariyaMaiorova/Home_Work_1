﻿//Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет
System.Console.WriteLine("ВВедите число ->");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{System.Console.WriteLine($"число {number} - четное");}
else
{System.Console.WriteLine($"число {number} - нечетное");}