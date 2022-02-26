/*Поле шахматной доски определяется парой натуральных чисел, каждое из которых не превосходит 8:
 первое число — номер вертикали (при счете слева направо), второе — номер горизонтали (при счете снизу вверх).
  Даны натуральные числа a, b, c, d, каждое из которых не превосходит 8.
а) на поле (a, b) расположена ладья. Определить, угрожает ли она полю (c, d); */
Console.Clear();
bool result=false;
Console.WriteLine("Введите х координату фигуры оппонента");
int xa= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату фигуры оппонента");
int ya= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите х координату вашей фигуры");
int xb= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату вашей фигуры");
int yb= Convert.ToInt32(Console.ReadLine());
int xa1=xa;
int ya1=ya;
 
 while (xa1<=8 & ya1<=8 & xa1 >=1 & ya1>=1)
 {
   Console.WriteLine(xa1 +" "+ ya1);
    if (xa1==xb & ya1== yb)
    {
         result=true;
         break; 
    }
    xa1++;
    ya1--;
 }
 xa1=xa;
 ya1=ya;
while (xa1<=8 & ya1<=8 & xa1 >=1 & ya1>=1)
{
    Console.WriteLine(xa1 +" "+ ya1);
    if (xa1==xb & ya1== yb)
    {
         result=true;
         break; 
    }
    xa1++;
    ya1++;
}
 xa1=xa;
 ya1=ya;
while (xa1<=8 & ya1<=8 & xa1 >=1 & ya1>=1)
{
    Console.WriteLine(xa1 +" "+ ya1);
    if (xa1==xb & ya1== yb)
    {
         result=true;
         break; 
    }
    xa1--;
    ya1--;
}
xa1=xa;
ya1=ya;
while (xa1<=8 & ya1<=8 & xa1 >=1 & ya1>=1)
{
    Console.WriteLine(xa1 +" "+ ya1);
    if (xa1==xb & ya1== yb)
    {
         result=true;
         break; 
    }
    xa1--;
    ya1++;
}
if (result==true) Console.WriteLine("Фигура в опасности, миллорд");
else Console.WriteLine("Можно разжать булки, миллорд");