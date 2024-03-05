namespace SomerenModel
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Building { get; set; }
        public int Floor { get; set; }
        public int AmountOfBeds { get; set; }

        public string Name
        {
            get
            {
                return $"{Building}{Floor}{RoomId:00}";
            }
        }
    }
}