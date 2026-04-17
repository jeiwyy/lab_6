internal class Cherry
{
    private int _berries;
    private int _height;
    private int _age;

    public Cherry()
    {
        _berries = 5;
        _height = 150;
        _age = 16;
    }

    public Cherry(int _age, int _height)
    {
        this.Age = _age;
        this.Height = _height;
    }

    public Cherry(Cherry cherry)
    {
        this._age = cherry.Age;
        this._height = cherry.Height;
        this._berries = cherry.Berries;
    }


    public int Age
    {
        get 
        { 
            return _age; 
        }
        set
        {
            if (value > 0 && value < 1200)
            {
                _age = value;
                if (_age > 24)
                {
                    _berries = Random.Shared.Next(100, 30000);
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
            return _height; 
        }
        set
        {
            if (value > 20 && value < 1000)
            {
                if (value > _height && _height > 30)
                {
                    _age += (value - _height) / 20;
                    if (_age > 24)
                    {
                        _berries = Random.Shared.Next(100, 30000);
                    }
                    _height = value;
                }
                else
                {
                    _height = value;
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
            return _berries; 
        }
        set 
        {
            if (_age > 24)
            {
                _berries = value + Random.Shared.Next(100, 10000);
                _age += 3;
            }
            else
            {
                _berries = 0;
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
        string s = "Возраст вишни: " + _age + " мес.";
        s += "\nВысота вишни: " + _height + " см";
        int ber10 = _berries % 10;
        int ber100 = _berries % 100;
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
        s += "\nНа вишне " + _berries + berry;
        return s;
    }
}