using System.Collections.Generic;

namespace Travel.Models
{
  public class Places 
  {
    public string CityName { get; set; }
    public string Partner { get; set; }
    public int DaysStayed { get; set; }
    public string Journal { get; set; }
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
    public Places(string cityName, string partner, int daysStayed, string journal)
    {
      CityName = cityName;
      Partner = partner;
      DaysStayed = daysStayed;
      Journal = journal;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static Places Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}