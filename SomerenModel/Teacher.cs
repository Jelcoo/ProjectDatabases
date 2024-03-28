using System;

namespace SomerenModel
{
    public class Teacher
    {
        public int TeacherId { get; private set; }
        public string Name {
            get {
                return FirstName + " " + LastName;
            }
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public long PhoneNumber { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public Room Room { get; private set; }

        public Teacher(string firstName, string lastName, long phoneNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }

        public Teacher(int teacherId, string firstName, string lastName, long phoneNumber, DateTime dateOfBirth)
            : this(firstName, lastName, phoneNumber, dateOfBirth)
        {
            TeacherId = teacherId;
        }

        public Teacher SetId(int id)
        {
            TeacherId = id;
            return this;
        }

        public Teacher SetRoom(Room room)
        {
            Room = room;
            return this;
        }
    }
}
