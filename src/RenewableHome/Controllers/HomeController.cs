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

    private HomeInfo _homeInfo = null;
    private EnergySourcesRepo _energySourceRepo = null;

    public HomeController() {
      _homeInfo = new HomeInfo();
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
        TempData["HomeInfo"] = new HomeInfo { State = homeInfo.State, AreaSqFt = homeInfo.AreaSqFt, KWperMonth = homeInfo.KWperMonth };
        TempData.Keep();

        return RedirectToAction("EnergySelection");
      }

      return View(homeInfo);
    }

    // GET: EnergySelection
    public ActionResult EnergySelection(){

      List<EnergyType> energyTypes = _energySourceRepo.GetEnergyTypes();
      _homeInfo = (HomeInfo)TempData["HomeInfo"];

      return View(energyTypes);
    }

    // POST: EnergySelection
    [HttpPost]
    public ActionResult EnergySelection(List<EnergyType> energyTypes){

      string solarVal = Request.Form["solarValueName"];
      string windVal = Request.Form["windValueName"];
      string hydroVal = Request.Form["hydroValueName"];
      string biomassVal = Request.Form["biomassValueName"];
      string geothermalVal = Request.Form["geothermalValueName"];

      //validate input for calculation

      //perform caluclation

      //send user to result screen

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
  }
}
