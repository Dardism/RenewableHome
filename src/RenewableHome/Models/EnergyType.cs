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
    public EnergyType(string name, string descr, double costPerKWhour) {
      Name = name;
      Descr = descr;
      CostPerKWhour = costPerKWhour;
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
  }
}