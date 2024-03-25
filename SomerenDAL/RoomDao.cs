using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAll()
        {
            SqlCommand command = new SqlCommand("SELECT roomId, building, floor, amountOfBeds FROM [rooms] ORDER BY building, floor, roomId ASC", OpenConnection());

            SqlDataReader reader = command.ExecuteReader();
            List<Room> rooms = new List<Room>();

            while (reader.Read())
            {
                Room room = ReadRoom(reader);
                rooms.Add(room);
            }
            reader.Close();
            CloseConnection();

            return rooms;
        }

        public Room ReadRoom(SqlDataReader reader)
        {
            Room room = new Room()
            {
                RoomId = (int)reader["roomId"],
                Building = reader["building"].ToString(),
                Floor = (int)reader["floor"],
                AmountOfBeds = (int)reader["amountOfBeds"],
            };

            return room;
        }
    }
}
