namespace Zoo.Interfaces
{
    public interface IFly
    {
        // Properties
        int WingSpan { get; set; }

        // Methods
        int FlightSpeed();
    }
}