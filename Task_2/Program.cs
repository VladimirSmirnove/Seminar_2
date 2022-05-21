// Напишите программу которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
 
Console.Write("Введите число ");
int Number = int.Parse(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2 && Number > 0)
{
   Console.WriteLine("Третья цифра этого числа -> " + NumberText[2]);
}
else
if (NumberText.Length > 2 && Number < 0)
{
   Console.WriteLine("Третья цифра этого числа -> " + NumberText[3]);
}
else
{
   Console.WriteLine("Третьей цифры нет");
}
