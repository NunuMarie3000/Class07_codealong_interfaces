using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Car : IDrivable
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public Car(string make, string model)
    {
      Make = make;
      Model = model;
    }
    public void Start()
    {
      Console.WriteLine("The car is starting");
    }
    public void Stop()
    {
      Console.WriteLine("The car is stopping");
    }
    public void Brake()
    {
      Console.WriteLine("The car is breaking!");
    }
    public void Accelerate()
    {
      Console.WriteLine("The car is accelerating");
    }
  }
}
