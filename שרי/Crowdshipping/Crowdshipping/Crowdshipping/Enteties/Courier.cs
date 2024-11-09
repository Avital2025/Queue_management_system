namespace Crowdshipping.Enteties
{
    public class Courier
    {
        public int CourierID { get; set; }
        public int UserID { get; set; }
        public string FullName { get; set; }
        public int VehicleID { get; set; }
        public int Rating { get; set; }
        public bool Availability { get; set; }
        public string ContactPhone { get; set; }
    }
}
