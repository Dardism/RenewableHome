using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RenewableHome.Models;

namespace RenewableHome.Controllers {
  public class HomeController : Controller {

    private HomeInfo _homeInfo = null;

    public HomeController() {
      HomeInfo _homeInfo = new HomeInfo();
    }

    // GET: HomeInfo initialization
    public ActionResult Index(){
      return View(_homeInfo);
    }

    //POST: Index, HomeInfo validation
    [HttpPost]
    public ActionResult Index(HomeInfo homeInfo) {

      ValidateEntry(homeInfo);

      if (ModelState.IsValid) {
        TempData["HomeInfo"] = new HomeInfo { State = homeInfo.State, AreaSqFt = homeInfo.AreaSqFt, KwperMonth = homeInfo.KwperMonth };
        TempData.Keep();

        return RedirectToAction("EnergySelection");
      }

      return View(homeInfo);
    }

    // GET: EnergySelection
    public ActionResult EnergySelection(){

      _homeInfo = (HomeInfo)TempData["HomeInfo"];

      return View(_homeInfo);
    }

    // POST: EnergySelection
    [HttpPost]
    public ActionResult EnergySelection(EnergyType energySelection){
      return View();
    }

    private void ValidateEntry(HomeInfo homeInfo) {
      if (ModelState.IsValidField("AreaSqFt") && homeInfo.AreaSqFt <= 0) {
        ModelState.AddModelError("AreaSqFt", "The Square Footage of your home must be greater than '0'.");
      }
    }
  }
}
