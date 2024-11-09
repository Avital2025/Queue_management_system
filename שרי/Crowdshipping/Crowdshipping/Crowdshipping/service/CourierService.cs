using Crowdshipping.Enteties;
using Microsoft.AspNetCore.Mvc;

namespace Crowdshipping.service
{
    public class CourierService
    {

        List<Courier> CouriersList;
        public CourierService()
        {

        }
        public List<Courier> GetCouriersList()
        {
            if (CouriersList == null)
            {
                return null;
            }
            return CouriersList;
        }


        public bool PostCouriersList(Courier cou)
        {
            if (CouriersList == null)
            {
                return false;
            }
            CouriersList.Add(cou);
            return true;
        }



        public bool PutCouriersList(Courier cou, int courierID)
        {
            if (CouriersList == null)
            {
                return false;
            }

            Courier co = CouriersList.Find(c => c.CourierID == courierID);
            co.ContactPhone = cou.ContactPhone;
            co.Rating = cou.Rating;
            co.FullName = cou.FullName;
            co.Availability = cou.Availability;
            co.UserID = cou.UserID;
            co.VehicleID = cou.VehicleID;
            return true;



        }



        public bool DeleteCouriersList(int CourierID)
        {

            if (CouriersList == null)
            {
                return false;
            }

            CouriersList.Remove(CouriersList.Find(c => c.CourierID == CourierID));
            return true;
        }

    }
}
