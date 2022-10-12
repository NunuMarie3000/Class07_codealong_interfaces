using System;

namespace Interfaces.Interfaces
{
  public interface IDrive
  {
    ///<summary>The state the drivers license was issued</summary>
    string StateLicense { get; set; }

    ///<summary>Adjust the settings of the vehicle</summary>
    ///<returns>All of the settings adjusted</returns>
    string AdjustSettings();
  }
}