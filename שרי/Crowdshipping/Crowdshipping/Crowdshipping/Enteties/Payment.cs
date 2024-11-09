namespace Crowdshipping.Enteties
{
    public class Payment
    {
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }
        public int PaymentMethod { get; set; }
        public int Amount { get; set; }
        public int ShipmentID { get; set; }
        public int PaymentID { get; set; }
        public int MyProperty { get; set; }
    }
}
