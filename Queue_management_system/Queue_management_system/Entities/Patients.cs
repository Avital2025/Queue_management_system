namespace Queue_management_system.Entities
{
    public class Patients
    {

        //לקוח: שם, ת.ז. גיל, פלאפון, מייל, טלפון נוסף, סוג ביטוח

        public string Name { get; set; }
        public string TZ { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }
        public string AnotherPhone { get; set; }

        public string Mail { get; set; }

        public string Insurance { get; set; }

       

    }
}
