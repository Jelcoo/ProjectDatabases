using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAll()
        {
            string query = @"
SELECT roomId, building, floor, amountOfBeds
FROM [rooms]
WHERE deleted=0
ORDER BY building, floor, roomId ASC";

            SqlCommand command = new SqlCommand(query, OpenConnection());

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
            Room room = new Room(
                (int)reader["roomId"],
                reader["building"].ToString(),
                (int)reader["floor"],
                (int)reader["amountOfBeds"]
            );

            return room;
        }
    }
}
