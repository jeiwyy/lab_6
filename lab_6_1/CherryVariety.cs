internal class CherryVariety : Cherry
{
    private string varietyName;
    private int frostResist;
    private double yield;

    public CherryVariety()
    :base()
    {
        varietyName = "Обыкновенная";
        frostResist = 5;
        yield = 1;
    }

    public CherryVariety(int age, int height, 
        string varietyName, int frostResist, double yield)
    :base(age, height)
    {
        this.varietyName = varietyName;
        this.frostResist = frostResist;
        this.Yield = yield;
    }
    public string VarietyName
    {
        get 
        { 
            return varietyName; 
        }
    }
    public int FrostResist
    {
        get 
        { 
            return frostResist; 
        }
    }
    public double Yield
    {
        get 
        { 
            return yield; 
        }
        set
        {
            if (value > 0 && value <= 10)
            {
                this.yield = value;
            }
            else
            {
                Console.WriteLine("Введите реальное значение урожайности!");
            }
            
        }
    }

    public static CherryVariety MergeVariety(string varietyName, 
        CherryVariety cherry1, CherryVariety cherry2)
    {
        int frostResist = (cherry1.FrostResist + cherry2.FrostResist) / 2;
        double temp;
        temp = (cherry1.Yield + cherry2.Yield) / 2 + Random.Shared.NextDouble();
        double yield = Math.Round(temp, 2);
        return new CherryVariety(16, 150, varietyName, frostResist, yield);
    }

    public static void Comparison(CherryVariety cherry1, CherryVariety cherry2)
    {
        Console.WriteLine("Сравнение " + cherry1.VarietyName +
            " и " + cherry2.VarietyName);
        if (cherry1.Age < cherry2.Age)
        {
            Console.WriteLine(cherry1.VarietyName +
                " моложе " + cherry2.VarietyName);
        }
        else if (cherry2.Age < cherry1.Age)
        {
            Console.WriteLine(cherry2.VarietyName + 
                " моложе " + cherry1.VarietyName);
        }
        else
        {
            Console.WriteLine(cherry1.VarietyName + " и " + 
                cherry2.VarietyName + " одинакового возраста");
        }
        
        if (cherry1.Height > cherry2.Height)
        {
            Console.WriteLine(cherry1.VarietyName + 
                " выше " + cherry2.VarietyName);
        }
        else if (cherry2.Height > cherry1.Height)
        {
            Console.WriteLine(cherry2.VarietyName + " выше " 
                + cherry1.VarietyName);
        }
        else
        {
            Console.WriteLine(cherry1.VarietyName + " и " + 
                cherry2.VarietyName + " одинаковой высоты");
        }

        if (cherry1.Berries > cherry2.Berries)
        {
            Console.WriteLine("На " + cherry1.VarietyName + 
                " больше ягод чем на " + cherry2.VarietyName);
        }
        else if (cherry2.Berries > cherry1.Berries)
        {
            Console.WriteLine(cherry2.VarietyName + " больше ягод чем на "
                 + cherry1.VarietyName);
        }
        else
        {
            Console.WriteLine("На " + cherry1.VarietyName + " и на " + 
                cherry2.VarietyName + " одинаковое кол-во ягод");
        }

        if (cherry1.FrostResist > cherry2.FrostResist)
        {
            Console.WriteLine(cherry1.VarietyName + 
                " более морозоустойчива чем " + cherry2.VarietyName);
        }
        else if (cherry2.FrostResist > cherry1.FrostResist)
        {
            Console.WriteLine(cherry2.VarietyName + 
                " более морозоустойчива чем " + cherry1.VarietyName);
        }
        else
        {
            Console.WriteLine(cherry1.VarietyName + " и " + 
                cherry2.VarietyName + " одинаково морозоустойчивы");
        }

        if (cherry1.Yield > cherry2.Yield)
        {
            Console.WriteLine(cherry1.VarietyName + " более урожайная чем " + 
                cherry2.VarietyName);
        }
        else if (cherry2.Yield > cherry1.Yield)
        {
            Console.WriteLine(cherry2.VarietyName + " более урожайная чем " + 
                cherry1.VarietyName);
        }
        else
        {
            Console.WriteLine(cherry1.VarietyName + " и " + 
                cherry2.VarietyName + " одинаково урожайны");
        }
    }

    public void SurviveInUral()
    {
        if (this.FrostResist > 5)
        {
            Console.WriteLine(this.VarietyName + " выживет на урале");
        }
        else
        {
            Console.WriteLine(this.VarietyName + " не выживет на урале");
        }
    }

    public override string ToString()
    {
        string s = "Возраст вишни: " + Age + " мес.";
        s += "\nВысота вишни: " + Height + " см";
        int ber10 = Berries % 10;
        int ber100 = Berries % 100;
        string berry;
        if (ber100 >= 11 && ber100 <= 14)
        {
            berry = " ягод.";
        }
        else if (ber10 == 1) 
        {
            berry = " ягода.";
        }
        else if (ber10 >= 2 && ber10 <= 4) 
        {
            berry = " ягоды.";
        }
        else 
        {
            berry = " ягод.";
        }
        s += "\nНа вишне " + Berries + berry;
        s += "\nСорт вишни: " + varietyName;
        s += "\nМорозоустойчивость: " + frostResist + "/10";
        if (yield > 1)
        {
            s += "\nУрожайность лучше в " + yield + " раз";   
        }
        else if (yield < 1)
        {
            s += "\nУрожайность хуже в " + Math.Round(1 / yield, 2) + " раз"; 
        }
        return s;
    }
}