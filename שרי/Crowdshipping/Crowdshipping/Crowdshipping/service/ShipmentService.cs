using Crowdshipping.Enteties;

namespace Crowdshipping.service
{
    public class ShipmentService
    {
        List<Shipment> shipmentsLinst;
        public ShipmentService()
        {

        }

        public List<Shipment> GetShipmentList()
        {
            if (shipmentsLinst == null)
            {
                return null;
            }
            return shipmentsLinst;
        }


        public bool PostShipmentList(Shipment ship)
        {
            if (shipmentsLinst == null)
            {
                return false;
            }
            shipmentsLinst.Add(ship);
            return true;
        }



        public bool PutShshipmentsLinst(Shipment ship, int shipmentID)
        {
            if (shipmentsLinst == null)
            {
                return false;
            }

            Shipment sh = shipmentsLinst.Find(c => c.ShipmentID == shipmentID);
            sh.PickupDateTime = ship.PickupDateTime;
            sh.Status = ship.Status;
            sh.DropoffLocation = ship.DropoffLocation;
            sh.ShipmentID = ship.ShipmentID;
            sh.SenderID = ship.SenderID;
            sh.PickupLocation = ship.PickupLocation;
            sh.CourierID = ship.CourierID;
            return true;



        }



        public bool DeleteShipmentList( int shipmentID)
        {

            if (shipmentsLinst == null)
            {
                return false;
            }

            shipmentsLinst.Remove(shipmentsLinst.Find(c =>c.ShipmentID ==shipmentID));
            return true;
        }
    }
}
