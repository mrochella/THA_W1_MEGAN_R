using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

Dealership dealership = new Dealership();
Console.WriteLine("Add Dealership name:");
dealership.DSname = Console.ReadLine();
Console.WriteLine("Add Dealership location:");
dealership.DSloc = Console.ReadLine();
Console.WriteLine("--------------------");
Console.WriteLine("1. Add Car");
Console.WriteLine("2. Remove Car");
Console.WriteLine("3. Print Car List");
Console.WriteLine("4. Make Sales");
Console.WriteLine("5. Print Sales");
Console.WriteLine("6. Exit");
Console.WriteLine("Menu Choice:");
int choiceApa = Convert.ToInt32(Console.ReadLine());

while (choiceApa != 6)
{
    if (choiceApa == 1)
    {
        Console.WriteLine("1. Electric\n2. Hybrid\n3. Gasoline");
        int choiceCar = Convert.ToInt32(Console.ReadLine());
        if (choiceCar == 1)
        {
            Electric electric = new Electric();
            Console.WriteLine("Car Make:");
            electric.setMake(Console.ReadLine());

            dealership.Addcars(electric);

            Console.WriteLine("Input Car Model:");
            electric.setModel(Console.ReadLine());
            Console.WriteLine("Input Car Year:");
            electric.setYear(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input Car Price:");
            electric.setPrice(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Input Car Battery Capacity:");
            electric.setBatteryCapacity(Convert.ToInt32(Console.ReadLine()));

            electric.setCarType("Electric");
            Console.ReadKey();
            Console.Clear();
        }
        else if (choiceCar == 2)
        {
            Hybrid hybrid = new Hybrid();
            Console.WriteLine("Car Make:");
            hybrid.setMake(Console.ReadLine());

            dealership.Addcars(hybrid);

            Console.WriteLine("Input Car Model:");
            hybrid.setModel(Console.ReadLine());
            Console.WriteLine("Input Car Year:");
            hybrid.setYear(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input Car Price:");
            hybrid.setPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input Car Battery Capacity:");
            hybrid.setBatteryCapacity(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Input Gas Tank Size:");
            hybrid.setGasTankSize(Convert.ToInt32(Console.ReadLine()));

            hybrid.setCarType("Hybrid");
            Console.ReadKey();
            Console.Clear();
        }
        else if (choiceCar == 3)
        {
            Gasoline gasoline = new Gasoline();
            Console.WriteLine("Car Make:");
            gasoline.setMake(Console.ReadLine());

            dealership.Addcars(gasoline);

            Console.WriteLine("Car Model:");
            gasoline.setModel(Console.ReadLine());
            Console.WriteLine("Car Year:");
            gasoline.setYear(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Car Price:");
            gasoline.setPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Gas Tank Size:");
            gasoline.setGasTankSize(Convert.ToInt32(Console.ReadLine()));

            gasoline.setCarType("Gasoline");
            Console.ReadKey();
            Console.Clear();
        }
    }
    else if (choiceApa == 2)
    {
        Console.WriteLine("Remove Car Make:");
        string carMake = Console.ReadLine();
        Console.WriteLine("Remove Car Model:");
        string carModel = Console.ReadLine();
        dealership.RemoveCars(carMake,carModel);

        dealership.PrintCars();
    }
    else if (choiceApa == 3)
    {
        dealership.PrintCars();
    }
    else if (choiceApa == 4)
    {
        Sale sale = new Sale();
        Console.WriteLine("Customer name:");
        sale.setName(Console.ReadLine());

        dealership.MakeSale(sale);

        Console.WriteLine("Input Car Make:");
        sale.setMake(Console.ReadLine());
        Console.WriteLine("Input Car Model:");
        sale.setModel(Console.ReadLine());
        Console.WriteLine("Input Car Year:");
        sale.setYear(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Input Customer Price Paid:");
        sale.setPaid(Convert.ToDouble(Console.ReadLine()));

        Console.ReadKey();
    }
    else if (choiceApa == 5)
    {
        dealership.PrintSale();
    }

    Console.WriteLine("1. Add Car");
    Console.WriteLine("2. Remove Car");
    Console.WriteLine("3. Print Car List");
    Console.WriteLine("4. Make Sales");
    Console.WriteLine("5. Print Sales");
    Console.WriteLine("6. Exit");
    Console.WriteLine("Menu Choice:");

    choiceApa = Convert.ToInt32(Console.ReadLine());
}

if (choiceApa == 6)
{
    Console.Clear();
    Console.WriteLine("Program exited.");

    Console.ReadKey();
}

public class Dealership : Car
{
    private string Dsname, Dsloc;
    public string DSname
    {
        get {  return Dsname; }
        set {  Dsname = value; }
    }

    public string DSloc
    {
        get { return Dsloc; }
        set { Dsloc = value; }
    }

    List<Car> ListCars = new List<Car>();

    public void Addcars(Car car)
    {
        ListCars.Add(car);
    }

    public void RemoveCars(string carMake, string carModel)
    {
        foreach (Car a in ListCars)
        {
            if (a.getModel().Equals(carModel) && a.getMake().Equals(carMake))
            {
                ListCars.Remove(a);
                break;
            }
        }
    }

    public void PrintCars()
    {
        foreach (Car b in ListCars)
        {
            b.info();
        }
    }

    List<Sale> sales = new List<Sale>();

    public void MakeSale(Sale sale)
    {
        ListCars.Remove(sale.Car);
        sales.Add(sale);
    }

    public void PrintSale()
    {
        Console.WriteLine("Sales History\n---------------------");
        foreach(Sale c in sales)
        {
            c.infoSales();
        }
    }
}

public class Sale : Car
{
    protected string Custname;
    public Car Car;
    protected double Pricepaid;

    public void setName(string CustName)
    {
        Custname = CustName;
    }

    public string getName()
    {
        return Custname;
    }

    public void setPaid(double PricePaid)
    {
        Pricepaid = PricePaid;
    }

    public double getPaid()
    {
        return Pricepaid;
    }
    public void infoSales()
    {
        Console.WriteLine("Customer name:" + Custname);
        Console.WriteLine("Car Make:" + make);
        Console.WriteLine("Car Model:" + model);
        Console.WriteLine("Car Year:" + year);
        Console.WriteLine("Price paid: Rp." + Pricepaid);
        Console.WriteLine("");
    }
}