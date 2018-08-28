namespace vehicles
{
    public interface IFloat
    {
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxWaterSpeed { get; set; }
        void Start();
        void Stop();
        void Float();
    }
}