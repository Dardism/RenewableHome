using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RenewableHome.Models;

namespace RenewableHome.Data {
  public class EnergyData {
    /// <summary>
    /// Provides in-memory data storage for the energy sources
    /// </summary>
    public static List<EnergyType> EnergyTypes { get; set; }

    /// <summary>
    /// Static constructor used to initialize the data.
    /// </summary>
    static EnergyData() {
      InitData();
    }
    
    private static void InitData() {
      var energyTypes = new List<EnergyType>() {
        new EnergyType("Nuclear", "Nuclear reactions that release nuclear energy to generate heat.", 3.31),
        new EnergyType("Geo-Thermal", "Derived from the natural heat of the earth.", 5.55),
        new EnergyType("Hydropower", "This includes tidal, low dams, free-flow currents, tidal fence, and submerged array", 8.75),
        new EnergyType("Solar", "Solar photovoltaic panels are used to convert sunlight into electricity.", 6),
        new EnergyType("Wind", "Wind powered turbines rotate to power an electric generator", 3.45)
      };

      EnergyTypes = energyTypes;
    }

  }
}