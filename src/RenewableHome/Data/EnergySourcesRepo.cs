using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RenewableHome.Models;

namespace RenewableHome.Data {
  /// <summary>
  /// Repository for Energy sources
  /// </summary>
  public class EnergySourcesRepo {

    /// <summary>
    /// Gets the energy sources from the data class
    /// </summary>
    /// <returns>The list of Energy sources in the data class</returns>
    public List<EnergyType> GetEnergyTypes() {
      return EnergyData.EnergyTypes.ToList();
    }

    /// <summary>
    /// Returns a single energy source
    /// </summary>
    /// <param name="name">Name of energy source</param>
    /// <returns></returns>
    public EnergyType GetEnergyName(string name) {
      EnergyType energy = EnergyData.EnergyTypes.Where(e => e.Name == name).SingleOrDefault();

      return energy;
    }

    /// <summary>
    /// Returns the cost per KW hour of a type of energy
    /// </summary>
    /// <param name="name">Name of energy source</param>
    /// <returns></returns>
    public double GetEnergyCost(string name) {
      EnergyType energy = EnergyData.EnergyTypes.Where(e => e.Name == name).SingleOrDefault();

      return energy.CostPerKWhour;
    }
  }
}