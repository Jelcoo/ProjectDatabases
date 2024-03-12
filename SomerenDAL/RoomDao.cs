using System.Collections.Generic;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAll(string sortBy = null)
        {
            string query = "SELECT roomId, building, floor, amountOfBeds FROM [rooms]";

            if (sortBy != null)
            {
                query += $" ORDER BY {sortBy}";
            }
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

        private Room ReadRoom(SqlDataReader reader)
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
