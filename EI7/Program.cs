/*Поле шахматной доски определяется парой натуральных чисел, каждое из которых не превосходит 8:
 первое число — номер вертикали (при счете слева направо), второе — номер горизонтали (при счете снизу вверх).
  Даны натуральные числа a, b, c, d, каждое из которых не превосходит 8.
а) на поле (a, b) расположена ладья. Определить, угрожает ли она полю (c, d); */
using System;
Console.Clear();
Console.WriteLine("Введите х координату фигуры оппонента");
int xa= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату фигуры оппонента");
int ya= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите х координату вашей фигуры");
int xb= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y координату вашей фигуры");
int yb= Convert.ToInt32(Console.ReadLine());
void Move(int x, int y)
{
     int xM = 0;
     int yM = 0;
     if (x>xb) xM=-1;
     if (x<xb) xM=1;
     if (y>yb) yM=-1;
     if (y<yb) yM=1;
     while (x<=8 & y<=8 & x >=1 & y>=1)
 {
   Console.WriteLine(x +" "+ y);
    if (x == xb & y == yb)
    {
     Console.WriteLine("Фигура в опасности, миллорд");
     System.Environment.Exit(0); 
    } 
    x=x+xM;
    y=y+yM;

}
}
Move(xa,ya);
Console.WriteLine("Можно разжать булки, миллорд");