namespace SafraBootcamp.Module2.LetsDate;

public class Location
{
    private string _city;
    private string _state;
    private Coordinates _coordinates;

    public Location(string city, string state, Coordinates coordinates)
    {
        _city = city;
        _state = state;
        _coordinates = coordinates;
    }
    public string City { get; set; }

    public string State { get; set; }

    public Coordinates Coordinates { get; set; }
}