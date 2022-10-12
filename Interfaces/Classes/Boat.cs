using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Boat : IDrivable
  {
    public string BoatName { get; set; }
    public int Size { get; set; }
    public void Start()
    {
      Console.WriteLine("The boat is starting");
    }
    public void Stop()
    {
      Console.WriteLine("The boat is stopping");
    }
    public void Brake()
    {
      Console.WriteLine("The boat is braking");
    }
    public void Accelerate()
    {
      Console.WriteLine("The boat is accelerating");
    }
    void BoardProcedure()
    {
      Console.WriteLine("Now boarding the boat");
    }
    void UnBoardingProcedure()
    {
      Console.WriteLine("Now unboarding the boat");
    }
  }
}