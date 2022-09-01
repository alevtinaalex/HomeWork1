Console.Write("Введите число a и нажмите Enter ");
string First = Console.ReadLine();
int FirstA = Convert.ToInt32(First);
Console.Write("Введите число b и нажмите Enter ");
string Second = Console.ReadLine();
int SecondB = Convert.ToInt32(Second);

int max = FirstA;
if (FirstA > SecondB)
 { 
    max = FirstA;
 }
else 
  {  
    max = SecondB;
  }
  Console.Write("Максималььное число ");
  Console.Write(max);
