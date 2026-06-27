// task 1

//Device[] Devices = { new Teapot("Teapot", "Capacity 2 litr"), new Microwave("Microwave", "Power 1200 VT"), new Car("Car", "Fuel gasoline"), new Steamboat("Steamboat", "Passenger steamboat") };

//foreach (var item in Devices)
//{
//    item.Show();
//    item.Desc();
//    item.Sound();

//    Console.WriteLine();
//}


//class Device
//{
//    protected string Name;
//    protected string Description;

//    public Device(string Name, string Description)
//    {
//        this.Name = Name;
//        this.Description = Description;
//    }

//    public virtual void Sound()
//    {
//        Console.WriteLine("Devices sound");
//    }

//    public virtual void Show()
//    {
//        Console.WriteLine($"Name - {Name}");
//    }

//    public virtual void Desc()
//    {
//        Console.WriteLine($"Description - {Description}");
//    }
//}


//class Teapot : Device
//{
//    public Teapot(string Name, string Description)
//        : base(Name, Description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - ffff");
//    }
//}

//class Microwave : Device
//{
//    public Microwave(string Name, string Description)
//        : base(Name, Description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - vvvv");
//    }
//}

//class Car : Device
//{
//    public Car(string Name, string Description)
//        : base(Name, Description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - bip bip");
//    }
//}


//class Steamboat : Device
//{
//    public Steamboat(string Name, string Description)
//        : base(Name, Description) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - Tuuu Tuuu");
//    }
//}



// task 2

//Musical_Instrument[] Instruments = { new Violin("Violin", "String musical instrument", "Appeared in Italy in the 16th century"), new Trombone("Trombone", "Brass wind instrument", "Known since the 15th century"), new Ukulele("Ukulele", "Four-string musical instrument", "Originated in Hawaii in the 19th century"),new Cello("Cello", "Large string musical instrument", "Appeared in Italy in the 16th century")};

//foreach (var item in Instruments)
//{
//    item.Show();
//    item.Desc();
//    item.History();
//    item.Sound();

//    Console.WriteLine();
//}


//class Musical_Instrument
//{
//    protected string Name;
//    protected string Description;
//    protected string History_Info;

//    public Musical_Instrument(string Name, string Description, string History_Info)
//    {
//        this.Name = Name;
//        this.Description = Description;
//        this.History_Info = History_Info;
//    }

//    public virtual void Sound()
//    {
//        Console.WriteLine("Instrument sound");
//    }

//    public virtual void Show()
//    {
//        Console.WriteLine($"Name - {Name}");
//    }

//    public virtual void Desc()
//    {
//        Console.WriteLine($"Description - {Description}");
//    }

//    public virtual void History()
//    {
//        Console.WriteLine($"History - {History_Info}");
//    }
//}


//class Violin : Musical_Instrument
//{
//    public Violin(string Name, string Description, string History_Info)
//        : base(Name, Description, History_Info) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - Screech...");
//    }
//}

//class Trombone : Musical_Instrument
//{
//    public Trombone(string Name, string Description, string History_Info)
//        : base(Name, Description, History_Info) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - Too Too");
//    }
//}

//class Ukulele : Musical_Instrument
//{
//    public Ukulele(string Name, string Description, string History_Info)
//        : base(Name, Description, History_Info) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - Ding Ding");
//    }
//}

//class Cello : Musical_Instrument
//{
//    public Cello(string Name, string Description, string History_Info)
//        : base(Name, Description, History_Info) { }

//    public override void Sound()
//    {
//        Console.WriteLine("Sound - Boom...");
//    }
//} 


// task 3

Worker[] Workers = { new President(), new Security(), new Manager(), new Engineer()};

foreach (var item in Workers)
{
    item.Print();
    Console.WriteLine();
}


abstract class Worker
{
    public abstract void Print();
}

class President : Worker
{
    public override void Print()
    {
        Console.WriteLine("President - Manages the entire company.");
    }
}

class Security : Worker
{
    public override void Print()
    {
        Console.WriteLine("Security - Protects the company and maintains order.");
    }
}

class Manager : Worker
{
    public override void Print()
    {
        Console.WriteLine("Manager - Organizes the work of employees.");
    }
}

class Engineer : Worker
{
    public override void Print()
    {
        Console.WriteLine("Engineer - Develops and maintains technical systems.");
    }
}