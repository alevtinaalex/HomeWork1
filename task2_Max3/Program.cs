Console.Write("Введите число a и нажмите Enter ");
string First = Console.ReadLine();
int FirstA = Convert.ToInt32(First);
Console.Write("Введите число b и нажмите Enter ");
string Second = Console.ReadLine();
int SecondB = Convert.ToInt32(Second);
Console.Write("Введите число c и нажмите Enter ");
string Third = Console.ReadLine();
int ThirdC = Convert.ToInt32(Third);

int max = FirstA;
if (FirstA > max)
 { 
    max = FirstA;
 }
if (SecondB > max)
  {  
    max = SecondB;
  }
if ( ThirdC > max)
 {
   max = ThirdC;
 }
  Console.Write("Максимальное число ");
  Console.Write(max); 

