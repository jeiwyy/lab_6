internal class Cherry
{
    private int berries;
    private int height;
    private int age;

    public Cherry()
    {
        berries = 5;
        height = 150;
        age = 16;
    }

    public Cherry(int age, int height)
    {
        this.Age = age;
        this.Height = height;
    }

    public Cherry(Cherry cherry)
    {
        this.age = cherry.Age;
        this.height = cherry.Height;
        this.berries = cherry.Berries;
    }


    public int Age
    {
        get 
        { 
            return age; 
        }
        set
        {
            if (value > 0 && value < 1200)
            {
                age = value;
                if (age > 24)
                {
                    berries = Random.Shared.Next(100, 30000);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода возраста вишни!");
            }
        }
    }
    public int Height
    {
        get 
        { 
            return height; 
        }
        set
        {
            if (value > 20 && value < 1000)
            {
                if (value > height && height > 30)
                {
                    age += (value - height) / 20;
                    if (age > 24)
                    {
                        berries = Random.Shared.Next(100, 30000);
                    }
                    height = value;
                }
                else
                {
                    height = value;
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода высоты вишни!");
            }
        }   
    }
    public int Berries
    {
        get 
        { 
            return berries; 
        }
        set 
        {
            if (age > 24)
            {
                berries = value + Random.Shared.Next(100, 10000);
                age += 3;
            }
            else
            {
                berries = 0;
            }
            
        }
    }

    public int MinVal(Cherry cherry2)
    {
        if (Age > cherry2.Age) 
        { 
            return cherry2.Age; 
        }
        else 
        { 
            return Age; 
        }
    }

    public override string ToString()
    {
        string s = "Возраст вишни: " + age + " мес.";
        s += "\nВысота вишни: " + height + " см";
        int ber10 = berries % 10;
        int ber100 = berries % 100;
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
        s += "\nНа вишне " + berries + berry;
        return s;
    }
}