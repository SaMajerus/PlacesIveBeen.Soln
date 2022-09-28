using System.Collections.Generic; 

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }  //"Read-only" property
    private static List<Place> _Places = new List<Place> {}; 

    public Place(string cityName)
    {
      CityName = cityName;
      _Places.Add(this); //Adds Places to '_Places'
      Id = _Places.Count;
    }

    public static List<Place> GetAll()  //'Getter' method
    {
      return _Places;
    }

    public static void ClearAll()
    {
      _Places.Clear();
    }

    public static Place Find(int searchId)
    {
      return _Places[searchId-1];
    }

  }
}
