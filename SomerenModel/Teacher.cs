using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int RoomId { get; set; }
    }
}