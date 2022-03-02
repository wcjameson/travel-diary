using System.Collections.Generic;

namespace Travel.Models
{
  public class Places 
  {
    public string CityName { get; set; }
    public int Id { get; }
    private static List<Places> _instances = new List<Places> {}; 
    public static List<Places> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public Places(string cityName)
    {
      CityName = cityName;
      Id = _instances.Count;
      _instances.Add(this);
    }
    public static Places Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}