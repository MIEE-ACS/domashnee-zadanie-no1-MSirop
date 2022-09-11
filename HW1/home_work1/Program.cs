using System;


class Program
{
    const float pi = 3.14f;
    public static void Main(string[] args)
    {
        Console.WriteLine("Станов Степан УТС-22\nДомашнее задание\nВариант 16\n");
        Console.Write("Введиие значения угла в радианах ar: ");
        float ar = float.Parse(Console.ReadLine());

        if ((ar <= 2 * pi)&&(ar >= 0))
        {
            float ad = ar *(180/pi);//перевод в фаренгейты
            Console.Write("Значения угла в градусах ad:         ");
            Console.WriteLine(string.Format("{0:F3}", ad));
        }
        else
        {
            Console.WriteLine("Значение угла вне диапазона: [0;2pi].Программа завершит работу");
        }
        Console.WriteLine("Для завершения нажмите на любую кнопку");
        Console.ReadKey();
    }
}