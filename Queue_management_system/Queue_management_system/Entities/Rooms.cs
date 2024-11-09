namespace Queue_management_system.Entities
{
    public class Rooms
    {
        //חדרים: מספר חדר, רופא, יש מזגן, יש ארונות, 
        public int RoomId { get; set;}
        public string RoomName { get; set;}
        public string DoctorName { get; set;}

        public bool Window { get; set; }

        public int RoomLevel { get; set;}

        
    }
}
