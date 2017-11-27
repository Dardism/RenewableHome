using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RenewableHome.Models {
  /// <summary>
  /// Represents an activity that has been logged in the Fitness Frog app.
  /// </summary>
  public class HomeInfo {
    /// <summary>
    /// Default constructor.
    /// </summary>
    public HomeInfo() {
    }

    /// <summary>
    /// Constructor for creating the basic infomration about a home entry.
    /// </summary>
    /// <param name="state">The State that the Home resides in(USA).</param>
    /// <param name="areaSqFt">The area of the home in square ft.</param>
    /// <param name="KWperMonth">The KW hours used per month.</param>
    public HomeInfo(string state, double areaSqFt, double KWperMonth) {
      State = state;
      AreaSqFt = areaSqFt;
      KWperMonth = KWperMonth;
    }

    /// <summary>
    /// The State that the Home resides in(USA).
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// The area of the home in squre ft.
    /// </summary>
    public double AreaSqFt { get; set; }
    
    /// <summary>
    /// The KW hours used per month.
    /// </summary>
    public string KwperMonth { get; set; }
  }
}