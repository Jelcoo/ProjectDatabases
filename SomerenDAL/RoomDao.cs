﻿using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT roomId, building, floor, amountOfBeds FROM [rooms]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    RoomId = (int)dr["roomId"],
                    Building = dr["building"].ToString(),
                    Floor = (int)dr["floor"],
                    AmountOfBeds = (int)dr["amountOfBeds"],
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
