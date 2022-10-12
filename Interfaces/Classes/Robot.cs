using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Robot : IDrive, IDrivable
  {
    public int NumberOfEyes { get; set; }
    public string SerialNumber { get; set; }
    public string StateLicense { get; set; }
    public Robot(int eyes, string serialnum, string license)
    {
      NumberOfEyes = eyes;
      SerialNumber = serialnum;
      StateLicense = license;
    }
    public string AdjustSettings()
    {
      return "Beep boop";
    }
    public void Start()
    {
      Console.WriteLine("Robot is starting");
    }
    public void Stop()
    {
      Console.WriteLine("Robot stop");
    }
    public void Brake()
    {
      Console.WriteLine("Robot stop so as not to hit pedestrian");
    }
    public void Accelerate()
    {
      Console.WriteLine("Robot go zoom");
    }
  }
}