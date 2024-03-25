using System;
using System.Collections.Generic;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartOfActivity { get; set; }
        public DateTime EndOfActivity { get; set; }
    }
}
