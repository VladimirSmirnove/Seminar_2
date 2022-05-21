// Программа которая на вход принимает цифру, обозначающая день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void DayWeek(int dayNumber)
{
  if (dayNumber == 6 || dayNumber == 7)
  {
      Console.WriteLine($"{dayNumber} -> да, этот день Выходной");
  }
  else
  if (dayNumber < 1 || dayNumber >7)
  {
Console.WriteLine("Эта цифра не день недели");
  }
  else Console.WriteLine($"{dayNumber} -> нет, это НЕ выходной");
}
DayWeek(dayNumber);
 



