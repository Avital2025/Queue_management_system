namespace Queue_management_system.Entities
{
    public class Queues
    {
        //תורים: שעה, יום, תאריך, לקוח, רופאה, 

        public int Day { get; set; }
        public int hour { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int day { get; set; }
        public int hourOfDay { get; set; }


        public Patients Patient { get; set; }

        public string DoctorName { get;}

        public string RoomName { get; set; }

    }
}
