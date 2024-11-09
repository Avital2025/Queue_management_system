namespace Crowdshipping.Enteties
{
    public class Shipment
    {
        public int ShipmentID { get; set; }
        public int SenderID { get; set; }
        public int CourierID { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public string Status { get; set; }
        public string PickupDateTime { get; set; }
    }
}
