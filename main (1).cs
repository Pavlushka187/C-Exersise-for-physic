/******************************************************************************

                            рассчёт расстояния по формуле s=v*t;

*******************************************************************************/

using System;
class HelloWorld {
  static void Main(string []args) {
    Console.WriteLine("Добро пожаловать");
    Console.WriteLine("Введите скорость для рассчёта преодалеваемого расстояния");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите время в пути");
    int y = Convert.ToInt32(Console.ReadLine());
    int z = y*x;
    Console.WriteLine($"Пройденное расстояние равно: {z}");
    Console.ReadKey();
  }
}
