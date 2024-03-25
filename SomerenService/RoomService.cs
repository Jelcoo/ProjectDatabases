using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomDao roomdb;

        public RoomService()
        {
            roomdb = new RoomDao();
        }

        public List<Room> GetRooms(string sortBy = null)
        {
            List<Room> rooms = roomdb.GetAll(sortBy);
            return rooms;
        }

    }
}
