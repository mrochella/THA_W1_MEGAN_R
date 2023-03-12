using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    protected string make, model, type;
    protected int year;
    protected double price;

    public void info()
    {
        Console.WriteLine("Car make:" + make);
        Console.WriteLine("Car type:" + type);
        Console.WriteLine("Car model:" + model);
        Console.WriteLine("Car year:" + year);
        Console.WriteLine("Car price:" + price);
        Console.WriteLine(" ");
    }

    public void setModel(string Model)
    {
        model = Model;
    }
    public string getModel()
    {
        return model;
    }

    public void setMake(string Make)
    {
        make = Make;
    }
    public string getMake()
    {
        return make;
    }

    public void setYear(int Year)
    {
        year = Year;
    }

    public int getYear()
    {
        return year;
    }

    public void setPrice(double Price)
    {
        price = Price;
    }

    public double getPrice()
    {
        return price;
    }

    public void setCarType(string Type)
    {
        type = Type;
    }

    public string getCarType()
    {
        return type;
    }
}

class Electric : Car
{
    private int Batterycapacity;

    public void setBatteryCapacity(int Batterycapacity)
    {
        Batterycapacity = Batterycapacity;
    }

    public int getBatteryCapacity()
    {
        return Batterycapacity;
    }
}

class Hybrid : Car
{
    private int Gastanksize;
    private int Batterycapacity;

    public void setGasTankSize(int Gastanksize)
    {
        Gastanksize = Gastanksize;
    }

    public int getGasTankSize()
    {
        return Gastanksize;
    }
    public void setBatteryCapacity(int Batterycapacity)
    {
        Batterycapacity = Batterycapacity;
    }

    public int getBatteryCapacity()
    {
        return Batterycapacity;
    }

}

class Gasoline : Car
{
    private int Gastanksize;

    public void setGasTankSize(int Gastanksize)
    {
        Gastanksize = Gastanksize;
    }

    public int getGasTankSize()
    {
        return Gastanksize;
    }
}