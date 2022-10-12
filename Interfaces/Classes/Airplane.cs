using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Airplane : IDrivable
  {
    public int Wingspan { get; set; }
    public int NumberOfPassengers { get; set; }
    public string Model { get; set; }
    public void Start()
    {
      Console.WriteLine("We're starting the plane");
    }
    public void TakeOff()
    {
      Console.WriteLine("The plane is taking off");
    }
    public void Stop()
    {
      Console.WriteLine("The plane is stopping");
    }
    public void Brake()
    {
      Console.WriteLine("The plane is breaking! Oh no!!!\nOh wait, the plane is braking....ooooh.\nWe're all good");
    }
    public void Accelerate()
    {
      Console.WriteLine("The plane is accelerating");
    }
  }
}