namespace SomerenModel
{
    public class Room
    {
        public int RoomId { get; private set; }
        public string Building { get; private set; }
        public int Floor { get; private set; }
        public int AmountOfBeds { get; private set; }

        public string Name
        {
            get
            {
                return $"{Building}{Floor}{RoomId:00}";
            }
        }

        public Room(int roomId, string building, int floor, int amountOfBeds)
        {
            RoomId = roomId;
            Building = building;
            Floor = floor;
            AmountOfBeds = amountOfBeds;
        }
    }
}
