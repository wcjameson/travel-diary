using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using System.Collections.Generic;

namespace Travel.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Places> allItems = Places.GetAll();
      return View(allItems);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string partner, int daysStayed, string journal, string location_Image)
    {
      Places nameOfCity = new Places(cityName, partner, daysStayed, journal, location_Image);
      return RedirectToAction("Index");
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Places newCityName = Places.Find(id);
      return View(newCityName);
    }

        [HttpPost("/places/delete")]
    public ActionResult DeleteAll()
    {
      Places.ClearAll();
      return View();
    }

  }
}