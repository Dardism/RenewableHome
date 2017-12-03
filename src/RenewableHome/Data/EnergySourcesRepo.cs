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
    /// 
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
    public EnergyType GetEnergy(string name) {
      EnergyType energy = EnergyData.EnergyTypes.Where(e => e.Name == name).SingleOrDefault();

      return energy;
    }
  }
}