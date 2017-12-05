using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RenewableHome.Models;

namespace RenewableHome.Data {
  public class EnergyData {
    /// <summary>
    /// Provides in-memory data storage for the energy sources used
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
        new EnergyType("Solar", "Solar photovoltaic panels are used to convert sunlight into electricity.", .18, ""),
        new EnergyType("Wind", "Wind powered turbines rotate to power an electric generator", .03, ""),
        new EnergyType("Hydropower", "This includes tidal, low dams, free-flow currents, tidal fence, and submerged array", .08, ""),
        new EnergyType("Biomass", "Burning bio material such as food or plant waste as a source of fuel.", .09, ""),
        new EnergyType("Geothermal", "Derived from the natural heat from the earth.", .05, "")
      };

      EnergyTypes = energyTypes;
    }

  }
}