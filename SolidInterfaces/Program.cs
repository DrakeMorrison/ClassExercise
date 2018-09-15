using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }

    void Start();
    void Stop();
}

public interface IAirVehicle : IVehicle
{
    bool Winged { get; set; }
    int PassengerCapacity { get; set; }
    double MaxAirSpeed { get; set; }

    void Fly();
}

public interface IGroundVehicle : IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    int PassengerCapacity { get; set; }
    double MaxLandSpeed { get; set; }

    void Drive();
}

public interface IWaterVehicle : IVehicle
{
    double MaxWaterSpeed { get; set; }

    void Drive();
}

public class JetSki : IWaterVehicle
{
    public double MaxWaterSpeed { get; set; } = 60.5;
    public string TransmissionType { get; set; } = "none";
    public double EngineVolume { get; set; } = 250;

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Submarine : IWaterVehicle
{
    public double MaxWaterSpeed { get; set; } = 200;
    public string TransmissionType { get; set; } = "Complicated";
    public double EngineVolume { get; set; } = 5000;

    public void Drive()
    {
        Console.WriteLine("The Submarine glides through the water");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Motorcycle : IGroundVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 1;
    public double MaxLandSpeed { get; set; } = 200;
    public string TransmissionType { get; set; } = "manual";
    public double EngineVolume { get; set; } = 600;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Tricycle : IGroundVehicle
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; } = 1;
    public double MaxLandSpeed { get; set; } = 200;
    public string TransmissionType { get; set; } = "manual";
    public double EngineVolume { get; set; } = 650;

    public void Drive()
    {
        Console.WriteLine("The Tricycle races down the road");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Cessna : IAirVehicle
{
    public bool Winged { get; set; } = true;
    public int PassengerCapacity { get; set; } = 9;
    public double MaxAirSpeed { get; set; } = 400;
    public string TransmissionType { get; set; } = "automatic";
    public double EngineVolume { get; set; } = 900;

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}

public class Paraglider : IAirVehicle
{
    public bool Winged { get; set; } = false;
    public int PassengerCapacity { get; set; } = 0;
    public double MaxAirSpeed { get; set; } = 50;
    public string TransmissionType { get; set; } = "none";
    public double EngineVolume { get; set; } = 400;

    public void Fly()
    {
        Console.WriteLine("The Paraglider soars through the air");
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public void Stop()
    {
        throw new NotImplementedException();
    }
}


public class Program
{

    public static void Main()
    {
        var motorcycle = new Motorcycle();
        var tricycle = new Tricycle();
        var jetski = new JetSki();
        var submarine = new Submarine();
        var cessna = new Cessna();
        var paraglider = new Paraglider();


        // Build a collection of all vehicles that fly
        var flyers = new List<IAirVehicle>();
        flyers.Add(cessna);
        flyers.Add(paraglider);

        // With a single `foreach`, have each vehicle Fly()
        foreach (var plane in flyers)
        {
            plane.Fly();
        }


        // Build a collection of all vehicles that operate on roads
        var drivers = new List<IGroundVehicle>();
        drivers.Add(motorcycle);
        drivers.Add(tricycle);

        // With a single `foreach`, have each road vehicle Drive()
        foreach (var ride in drivers)
        {
            ride.Drive();
        }



        // Build a collection of all vehicles that operate on water
        var swimmers = new List<IWaterVehicle>();
        swimmers.Add(jetski);
        swimmers.Add(submarine);

        // With a single `foreach`, have each water vehicle Drive()
        foreach (var fish in swimmers)
        {
            fish.Drive();
        }

        Console.ReadLine();
    }

}