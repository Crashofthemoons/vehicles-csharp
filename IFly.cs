namespace vehicles
{
    public interface IFly
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        bool Winged { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxAirSpeed { get; set; }
        void Start();
        void Stop();
        void Fly();
    }
}