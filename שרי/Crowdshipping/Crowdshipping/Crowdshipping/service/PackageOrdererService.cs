using Crowdshipping.Enteties;

namespace Crowdshipping.service
{
    public class PackageOrdererService
    {


        List<PackageOrderer> packageOrdererList;

        public PackageOrdererService()
        {
        }

        public List<PackageOrderer> GetPackageOrdererList()
        {
            if (packageOrdererList == null)
            {
                return null;
            }
            return packageOrdererList;
        }


        public bool PostpackageOrdererList(PackageOrderer orderer)
        {
            if (packageOrdererList == null)
            {
                return false;
            }
            packageOrdererList.Add(orderer);
            return true;
        }



        public bool PutpackageOrdererList(PackageOrderer orde, int ordererID)
        {
            if (packageOrdererList == null)
            {
                return false;
            }

            PackageOrderer po = packageOrdererList.Find(c => c.OrdererID == ordererID);
            po.OrdererID=orde.OrdererID;
            po.HomeAddress = orde.HomeAddress;
            po.DeliveryPreferences= orde.DeliveryPreferences;
            po.ContactPhone=orde.ContactPhone;
            po.Email=orde.Email;
            po.FullName=orde.FullName;
            po.Status=orde.Status;
            return true;
        }



        public bool DeletePackageOrderer(int ordererID)
        {

            if (packageOrdererList == null)
            {
                return false;
            }

            packageOrdererList.Remove(packageOrdererList.Find(c => c.OrdererID == ordererID));
            return true;
        }
    }
}
