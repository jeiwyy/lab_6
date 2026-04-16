internal class Program
{
    private static void Main(string[] args)
    {
        bool isCorrect;
        string input;
        double a;
        isCorrect = false;
        a = 0;
        while (!isCorrect)
        {
            Console.Write("Введите значение a: ");
            input = Console.ReadLine();
            isCorrect = double.TryParse(input, out a);
            if (!isCorrect || a <= 0)
            {
                isCorrect = false;
                Console.WriteLine("Ошибка ввода!");
            }
        }
        double b;
        isCorrect = false;
        b = 0;
        while (!isCorrect)
        {
            Console.Write("Введите значение b: ");
            input = Console.ReadLine();
            isCorrect = double.TryParse(input, out b);
            if (!isCorrect || b <= 0)
            {
                isCorrect = false;
                Console.WriteLine("Ошибка ввода!");
            }
        }

        RightTriangle triangle2 = new RightTriangle();
        RightTriangle triangle1 = new RightTriangle(a, b);

        Console.WriteLine("Созданный треугольник: " + triangle1);
        if (triangle1)
        {
            Console.WriteLine("Треугольник существует!");
        }
        else
        {
            Console.WriteLine("Треугольник не существует :(");
        }
        Console.WriteLine("Его площадь: " + triangle1.CalcArea());
        triangle1++;
        Console.WriteLine("Его площадь после умножения катетов на 2: " + triangle2.CalcArea());
        triangle1--;
        Console.WriteLine("Его площадь после деления катетов на 2: " + (double)triangle2);

        Console.WriteLine("\nТреугольник созданный автоматиечски: " + triangle2);
        if (triangle2 >= triangle1)
        {
            Console.WriteLine("Треугольник созданный автоматически больше или равен созданному вручную");
        }
        else
        {
            Console.WriteLine("Треугольник созданный автоматически меньше созданному вручную");
        }

        triangle1.B = -10;
        Console.WriteLine("Изменяем сторону на некорректную: " + triangle1);
        Console.WriteLine("Теперь его площадь: " + (double)triangle1);
        Console.WriteLine("Также: ");
        if (triangle1)
        {
            Console.WriteLine("Треугольник существует!");
        }
        else
        {
            Console.WriteLine("Треугольник не существует :(");
        }
    }
    
}