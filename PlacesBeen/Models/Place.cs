using System.Collections.Generic; 

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Duration { get; set; }
    public string Accomp { get; set; }  //Truncation of "accompanied by" 
    public string Journal { get; set; }
    public int Id { get; }  //"Read-only" property
    private static List<Place> _places = new List<Place> {}; 

    public Place(string cityName, string duration, string accomp, string journal)
    {
      CityName = cityName;
      Duration = duration;
      Accomp = accomp;
      Journal = journal;
      _places.Add(this); //Adds Places to '_places'
      Id = _places.Count;
    }

    public static List<Place> GetAll()  //'Getter' method
    {
      return _places;
    }

    public static void ClearAll()
    {
      _places.Clear();
    }

    public static Place Find(int searchId)
    {
      return _places[searchId-1];
    }

  }
}
