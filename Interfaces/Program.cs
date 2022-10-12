using System;
using Interfaces.Classes;
using Interfaces.Interfaces;

namespace Interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Student stormy = new Student("Storm", "O'Bryant", "Mississippi");
      Car nonExistent = new Car("invisi-mobile", "2022");
      stormy.Drive(nonExistent);
    }
  }
}