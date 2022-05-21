// Напишите программу которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int Numberthree = Convert.ToInt32(Console.ReadLine());
if (Numberthree > 99 && Numberthree < 1000)
{
  string stringNumber = Convert.ToString(Numberthree);
  Console.WriteLine("Вторая цифра этого числа -> " + stringNumber[1]);
}
else
if (Numberthree > -1000 && Numberthree < -99)
{
  string stringNumber = Convert.ToString(Numberthree);
  Console.WriteLine("Вторая цифра этого числа -> " + stringNumber[2]);
}
else
{
  Console.WriteLine("Число не трехзначное");
}
