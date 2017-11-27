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
    /// Constructor for easily creating entries.
    /// </summary>
    /// <param name="state">The State that the Home resides in(USA).</param>
    /// <param name="intensity">The intensity for the entry.</param>
    /// <param name="exclude">Whether or not the entry should be excluded when calculating the total fitness activity.</param>
    /// <param name="notes">The notes for the entry.</param>
    public HomeInfo(string state, bool exclude = false, string notes = null) {
      State = state;
      Exclude = exclude;
      Notes = notes;
    }

    /// <summary>
    /// The ID of the entry.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The date of the entry. Should not include a time portion.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The State that the Home resides in(USA).
    /// </summary>
    public string State { get; set; }

    /// <summary>
    /// Whether or not this entry should be excluded when calculating the total fitness activity.
    /// </summary>
    public bool Exclude { get; set; }

    /// <summary>
    /// The notes for the entry.
    /// </summary>
    [MaxLength(200, ErrorMessage = "The Notes filed cannot be longer than 200 characters.")]
    public string Notes { get; set; }
  }
}