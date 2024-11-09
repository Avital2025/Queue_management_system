using Crowdshipping.Enteties;
using Microsoft.AspNetCore.Mvc;

namespace Crowdshipping.service
{
    public class PaymentService
    {
        List<Payment> PaymentsList;
        public PaymentService()
        {

        }
        public List<Payment> GetPaymentsList()
        {
            if (PaymentsList == null)
            {
                return null;
            }
            return PaymentsList;
        }


        public bool PostPaymentsList(Payment p)
        {
            if (PaymentsList == null)
            {
                return false;
            }
            PaymentsList.Add(p);
            return true;
        }



        public bool PutPaymentsList(Payment pay, int paymentID)
        {
            if (PaymentsList == null)
            {
                return false;
            }

            Payment p = PaymentsList.Find(c => c.PaymentID == paymentID);
            p.PaymentDate = pay.PaymentDate;
            p.PaymentID=pay.PaymentID;
            p.Status=pay.Status;
            p.Amount=pay.Amount;
            p.PaymentMethod=pay.PaymentMethod;
            p.ShipmentID=pay.ShipmentID;
            return true;



        }



        public bool DeleteCouriersList(int paymentID)
        {

            if (PaymentsList == null)
            {
                return false;
            }

            PaymentsList.Remove(PaymentsList.Find(c => c.PaymentID == paymentID));
            return true;
        }
    }
}
