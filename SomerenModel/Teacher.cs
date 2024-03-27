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
        public string PhoneNumber { get; private set; } //TODO: validate input fields properly for all forms
        public DateTime DateOfBirth { get; private set; }
        public int RoomId { get; private set; } //TODO convert to Room model

        public Teacher(string firstName, string lastName, string phoneNumber, DateTime dateOfBirth, int roomId)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            RoomId = roomId;
        }

        public Teacher(int teacherId, string firstName, string lastName, string phoneNumber, DateTime dateOfBirth, int roomId)
            : this(firstName, lastName, phoneNumber, dateOfBirth, roomId)
        {
            TeacherId = teacherId;
        }

        public Teacher SetId(int id)
        {
            TeacherId = id;
            return this;
        }
    }
}
