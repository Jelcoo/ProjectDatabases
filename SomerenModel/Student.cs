using System;

namespace SomerenModel
{
    public class Student
    {
        public int StudentId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Name {
            get {
                return FirstName + " " + LastName;
            }
        }
        public System.Int64 PhoneNumber { get; private set; }
        public string Class { get; private set; }
        public int Vouchers { get; private set; }
        public int RoomId { get; private set; } //TODO convert to Room model

        public Student(string firstName, string lastName, System.Int64 phoneNumber, string @class, int vouchers, int roomId)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Class = @class;
            Vouchers = vouchers;
            RoomId = roomId;
        }

        public Student(int studentId, string firstName, string lastName, System.Int64 phoneNumber, string @class, int vouchers, int roomId)
            : this(firstName, lastName, phoneNumber, @class, vouchers, roomId)
        {
            StudentId = studentId;
        }

        public Student SetId(int id)
        {
            StudentId = id;
            return this;
        }

        // Even though there are 0 references to this constructor, it is still used by the UI.
        public override string ToString()
        {
            return Name;
        }
    }
}
