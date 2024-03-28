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
        public long PhoneNumber { get; private set; }
        public string Class { get; private set; }
        public int Vouchers { get; private set; }
        public Room Room { get; private set; }

        public Student(string firstName, string lastName, long phoneNumber, string @class, int vouchers)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Class = @class;
            Vouchers = vouchers;
        }

        public Student(int studentId, string firstName, string lastName, long phoneNumber, string @class, int vouchers)
            : this(firstName, lastName, phoneNumber, @class, vouchers)
        {
            StudentId = studentId;
        }

        public Student SetId(int id)
        {
            StudentId = id;
            return this;
        }

        public Student SetRoom(Room room)
        {
            Room = room;
            return this;
        }

        // Even though there are 0 references to this constructor, it is still used by the UI.
        public override string ToString()
        {
            return Name;
        }
    }
}
