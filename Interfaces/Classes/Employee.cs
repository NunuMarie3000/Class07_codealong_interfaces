using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Employee : Person, IDrive
  {
    public int Vacation { get; set; }
    public int AnnualSalary { get; set; }
    public string StateLicense { get; set; }
    public Employee(int annual, string state, string firstname, string lastname)
    {
      AnnualSalary = annual;
      StateLicense = state;
      FirstName = firstname;
      LastName = lastname;
    }
    public string AdjustSettings()
    {
      return "All my settings are adjusted";
    }
    public double GetHourlyRate()
    {
      double hourlyRate = (AnnualSalary / 52) / 40;
      return hourlyRate;
    }
    public string Drive(IDrivable drivable)
    {
      drivable.Accelerate();
      drivable.Brake();
      return "I can drive, you can too!";
    }

  }
}