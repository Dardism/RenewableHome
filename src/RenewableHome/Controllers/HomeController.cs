using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RenewableHome.Models;
using RenewableHome.Data;

namespace RenewableHome.Controllers {
  public class HomeController : Controller {

    private static HomeInfo _homeInfo = new HomeInfo();
    private static EnergySourcesRepo _energySourceRepo = null;
    private static double totalCost = 0;
    private static List<EnergyType> _energyTypes = null;

    public HomeController() {
      _energySourceRepo = new EnergySourcesRepo();
    }

    // GET: HomeInfo initialization
    public ActionResult Index(){
      return View(_homeInfo);
    }

    //POST: Index, HomeInfo validation
    [HttpPost]
    public ActionResult Index(HomeInfo homeInfo) {

      ValidateHomeInfo(homeInfo);

      if (ModelState.IsValid) {
        _homeInfo.AreaSqFt = homeInfo.AreaSqFt;
        _homeInfo.KWperMonth = homeInfo.KWperMonth;

        return RedirectToAction("EnergySelection");
      }

      return View(homeInfo);
    }

    // GET: EnergySelection
    public ActionResult EnergySelection(){
      _energyTypes = _energySourceRepo.GetEnergyTypes();

      return View(_energyTypes);
    }

    // POST: EnergySelection
    [HttpPost]
    public ActionResult EnergySelection(List<EnergyType> energyTypes){

      double solarVal = double.Parse(Request.Form["solarValueName"]) / 100;
      double windVal = double.Parse(Request.Form["windValueName"]) / 100;
      double hydroVal = double.Parse(Request.Form["hydroValueName"]) / 100;
      double biomassVal = double.Parse(Request.Form["biomassValueName"]) / 100;
      double geothermalVal = double.Parse(Request.Form["geothermalValueName"]) / 100;

      //validate input for calculation
      if (ValidateEnergySelection(solarVal, windVal, hydroVal, biomassVal, geothermalVal)) {
        //perform calculation
        totalCost = CalculateSelection(solarVal, windVal, hydroVal, biomassVal, geothermalVal);
        return RedirectToAction("ResultPage");
      }

      return RedirectToAction("EnergySelection");
    }

    public ActionResult ResultPage() {

      double costPerSqFt = totalCost / _homeInfo.AreaSqFt;

      costPerSqFt = Math.Truncate(costPerSqFt * 100) / 100;
      totalCost = Math.Truncate(totalCost * 100) / 100;

      ViewBag.costPerSqFt = costPerSqFt;
      ViewBag.totalCost = totalCost;
      return View();
    }

    private void ValidateHomeInfo(HomeInfo homeInfo) {
      if (ModelState.IsValidField("AreaSqFt") && homeInfo.AreaSqFt <= 0) {
        ModelState.AddModelError("AreaSqFt", "The square footage of your home must be greater than '0'.");
      }
      if (ModelState.IsValidField("KWperMonth") && homeInfo.KWperMonth <= 0) {
        ModelState.AddModelError("KWperMonth", "The Kilowatt hours of your home must be greater than '0'.");
      }
    }

    private bool ValidateEnergySelection(double sVal, double wVal, double hVal, double bVal, double gVal) {
      if ((sVal + wVal + hVal + bVal + gVal) != 1) {
        //ModelState.AddModelError(string.Empty, "Your current selection doesn't add up to 100%. Be sure to double check your total.");
        return false;
      }
      else {
        return true;
      }
    }

    private double CalculateSelection(double sVal, double wVal, double hVal, double bVal, double gVal) {
      double solDist = ((sVal * _homeInfo.KWperMonth) * _energySourceRepo.GetEnergyCost("Solar")) * 12;
      double windDist = ((wVal * _homeInfo.KWperMonth) * _energySourceRepo.GetEnergyCost("Wind")) * 12;
      double hydroDist = ((hVal * _homeInfo.KWperMonth) * _energySourceRepo.GetEnergyCost("Hydropower")) * 12;
      double bioDist = ((bVal * _homeInfo.KWperMonth) * _energySourceRepo.GetEnergyCost("Biomass")) * 12;
      double geoDist = ((gVal * _homeInfo.KWperMonth) * _energySourceRepo.GetEnergyCost("Geothermal")) * 12;

      double totalCost = solDist + windDist + hydroDist + bioDist + geoDist;

      return totalCost;
    }
  }
}
