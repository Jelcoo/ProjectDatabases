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

        public override string ToString()
        {
            return Name;
        }

        // Due to limitations in the UI, we need to override Equals and GetHashCode.
        public override bool Equals(object obj)
        {
            return obj is Room room && Name == room.Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
