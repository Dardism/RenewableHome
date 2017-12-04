using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RenewableHome.Models {
  /// <summary>
  /// Represents a type of energy to be used for the home energy calculation
  /// </summary>
  public class EnergyType {
    ///<summary>
    ///Constructors a type of energy to be created
    /// </summary>
    public EnergyType(string name, string descr, double costPerKWhour, string percentInd) {
      Name = name;
      Descr = descr;
      CostPerKWhour = costPerKWhour;
      PercentInd = percentInd;
    }

    /// <summary>
    /// The name of the energy type
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// The long form description of the type of energy
    /// </summary>   
    public string Descr { get; private set; }

    /// <summary>
    /// the cost per KiloWatt hour of the nergy type
    /// </summary>
    public double CostPerKWhour { get; private set; }

    /// <summary>
    /// the indicator of the slider for the selected energy source
    /// </summary>
    public string PercentInd { get; private set; }
  }
}