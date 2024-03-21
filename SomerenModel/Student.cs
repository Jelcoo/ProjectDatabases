using System;

namespace SomerenModel
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name {
            get {
                return FirstName + " " + LastName;
            }
        }
        public string PhoneNumber { get; set; }
        public string Class { get; set; }
        public int Vouchers { get; set; }
        public int RoomId { get; set; }
    }
}
