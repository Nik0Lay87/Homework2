// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.Write("Введите номер дня недели: "); 
int num = int.Parse(Console.ReadLine()); 

if (num >= 1 && num <= 5) 
{ 
    Console.Write(" Увы, это не выходной "); 
} 
else if (num >= 6 && num <= 7) 
{ 
    Console.Write(" УРА, выходной "); 
} 
else Console.Write(" Нет такого дня недели"); 
             