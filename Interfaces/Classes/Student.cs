using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Student : Person, IDrive
  {
    public Student(string firstname, string lastname, string state)
    {
      FirstName = firstname;
      LastName = lastname;
      StateLicense = state;
    }
    public string StateLicense { get; set; }
    public string AdjustSettings()
    {
      return "I'm a student and I adjusted my settings";
    }
    public string Drive(IDrivable drivable)
    {
      drivable.Accelerate();
      drivable.Brake();
      return "I'm a student and I can drive, you can too!";
    }
  }
}