//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите Случайное число");
int random =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("третья цифра в числе");
Console.WriteLine(random>99 ? random.ToString()[2]:"нет");
