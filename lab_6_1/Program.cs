//4 вариант
using Microsoft.Win32.SafeHandles;

internal class Program
{
    private static void Main(string[] args)
    {
        Cherry basicCherry = new Cherry();
        Console.WriteLine(basicCherry);

        Console.WriteLine("Создание нового дерева вишни...");

        bool isCorrect;
        int age;
        int height;
        isCorrect = false;
        age = 0;
        height = 0;
        while (!isCorrect)
        {
            Console.Write("Введите возраст: ");
            string input = Console.ReadLine();
            isCorrect = int.TryParse(input, out age);
            if (!isCorrect || age <= 0 || age >= 1200)
            {
                Console.WriteLine("Ошибка ввода!");
                isCorrect = false;
            }
        }
        isCorrect = false;
        while (!isCorrect)
        {
            Console.Write("Введите высоту: ");
            string input = Console.ReadLine();
            isCorrect = int.TryParse(input, out height);
            if (!isCorrect || height <= 20 || height >= 1000)
            {
                Console.WriteLine("Ошибка ввода!");
                isCorrect = false;
            }
        }

        Cherry newCherry = new Cherry(age, height);
        Console.WriteLine("Новосозданная вишня: ");
        Console.WriteLine(newCherry);
        Console.WriteLine("Возраст самой молодой вишни: " + Cherry.MinVal(newCherry, basicCherry));
        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
        CherryVariety simpleCherry = new CherryVariety();
        Console.WriteLine("Создание нового дерева вишни с указанным сортом...");
        Console.Write("Напишите название сорта вишни: ");
        string name;
        name = Console.ReadLine();
        isCorrect = false;
        while (!isCorrect)
        {
            Console.Write("Введите возраст: ");
            string input = Console.ReadLine();
            isCorrect = int.TryParse(input, out age);
            if (!isCorrect || age <= 0 || age >= 1200)
            {
                Console.WriteLine("Ошибка ввода!");
                isCorrect = false;
            }
        }
        isCorrect = false;
        while (!isCorrect)
        {
            Console.Write("Введите высоту: ");
            string input = Console.ReadLine();
            isCorrect = int.TryParse(input, out height);
            if (!isCorrect || height <= 20 || height >= 1000)
            {
                Console.WriteLine("Ошибка ввода!");
                isCorrect = false;
            }
        }
        int frostResist;
        frostResist = 0;
        isCorrect = false;
        while (!isCorrect)
        {
            Console.Write("Введите морозоустойчивость: ");
            string input = Console.ReadLine();
            isCorrect = int.TryParse(input, out frostResist);
            if (!isCorrect || frostResist < 0 || frostResist > 10)
            {
                Console.WriteLine("Ошибка ввода!");
                isCorrect = false;
            }
        }
        double yield;
        yield = 0;
        isCorrect = false;
        while (!isCorrect)
        {
            Console.Write("Введите урожайность: ");
            string input = Console.ReadLine();
            isCorrect = double.TryParse(input, out yield);
            if (!isCorrect || yield <= 0 || yield > 10)
            {
                Console.WriteLine("Ошибка ввода!");
                isCorrect = false;
            }
        }
        CherryVariety newVarietyCherry = new CherryVariety(age, height, name, frostResist, yield);
        Console.WriteLine("Новый вид вишни: ");
        Console.WriteLine(newVarietyCherry);

        Console.Write("Введите название нового вида: ");
        name = Console.ReadLine();
        CherryVariety superCherry = CherryVariety.MergeVariety(name, simpleCherry, newVarietyCherry);
        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
        Console.WriteLine("Новый вид полученный слиянием двух видов: ");
        Console.WriteLine(superCherry);

        Console.WriteLine("_-_-_-_-_-_-_-_-_-_-_-_");
        CherryVariety.Comparison(newVarietyCherry, superCherry);

        superCherry.SurviveInUral();
    }
}