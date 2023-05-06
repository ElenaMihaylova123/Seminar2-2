//Задача 21
// Вычислить расстояние между двумя 3D точками


Double x1=0;
Double x2=0;
Double y1=0;
Double y2=0;
Double z1=0;
Double z2=0;
Double rasst;
Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1=");
z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2=");
z2 = Convert.ToDouble(Console.ReadLine());

rasst = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine("rasst:" + rasst);
