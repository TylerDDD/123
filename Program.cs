// Задача номер 23.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= N)
{
    Console.WriteLine( index * index * index );
    index ++;
}   

// ------------------------------------------------

// Задача номер 21.

/* Console.Write("Укажите координаты точик A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите координаты точик B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
Console.WriteLine(Math.Round(d, 2)); */

// ------------------------------------------------

// Задача 19.

/* Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

{

if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");

}      */ 
