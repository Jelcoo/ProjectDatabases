using System;
using System.Collections.Generic;

namespace SomerenModel
{
    public class Activity
    {
        public int ActivityId { get; private set; }
        public string Name { get; private set; }
        public string Location { get; private set; }
        public DateTime StartOfActivity { get; private set; }
        public DateTime EndOfActivity { get; private set; }

        public Activity(int activityId, string name, string location, DateTime startOfActivity, DateTime endOfActivity)
        {
            ActivityId = activityId;
            Name = name;
            Location = location;
            StartOfActivity = startOfActivity;
            EndOfActivity = endOfActivity;
        }
    }
}
