using Microsoft.VisualStudio.TestTools.UnitTesting;
using Travel.Models;
using System.Collections.Generic;
using System;

namespace Travel.Tests
{
  [TestClass]
  public class PlacesTests : IDisposable
  {
    public void Dispose()
    {
      Places.ClearAll();
    }

    [TestMethod]
    public void Places_ShouldCreateInstanceOfPlaces_Object()
    {
      Places places = new Places("test");
      Assert.AreEqual(typeof(Places), places.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnNameOfCity_String()
    {
      string cityName = "Tokyo";
      Places newPlace = new Places(cityName);
      string result = newPlace.CityName;
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void GetAll_ShouldCreateInstanceOfList_List()
    {
      List<Places> instances = new List<Places> {};

      List<Places> testthis = Places.GetAll();

      CollectionAssert.AreEqual(instances, testthis);
    }

    [TestMethod]
    public void GetAll_ShouldReturnValuesInsideOfList_List()
    {
      string cityName = "Tokyo";
      string cityName2 = "California";
      Places newPlace = new Places(cityName);
      Places newPlace2 = new Places(cityName2);
      List<Places> instances = new List<Places> {newPlace, newPlace2};

      List<Places> result = Places.GetAll();
      
      CollectionAssert.AreEqual(instances, result);
    }
  }
}