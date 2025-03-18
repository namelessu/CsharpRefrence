using Adv_c__revision;

public class Football
{
    public int BallId { get; set; }
    //public Location BallLocation { get; set; }  // Not Right 
    Location ballLocation;
    public Location BallLocation
    {
        set
        {
            if (value != ballLocation)
            {
                ballLocation = value;
                ballLocationChanged?.Invoke();  // Firing Event
            }
            // event will be fired
            //ballLocationChanged(); // Unprotective 
            //if (ballLocationChanged != null) { ballLocationChanged(); }
        }
        get
        {
            return ballLocation;
        }
    }

    public Football()
    {
        BallId = 11;
        BallLocation = new Location() { X = 1, Y = 2, Z = 3 };
    }

    public override string ToString()
    {
        return $"Ball Location is {ballLocation}";
    }
    public event Action ballLocationChanged;

}