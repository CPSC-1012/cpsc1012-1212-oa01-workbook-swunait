using System;

namespace ListOfObjectsDemo
{
    internal class Participant
    {
        // Define property for the Name (string), Join Time (DateTime), and Leave Time (DateTime)
        private string _name;
        private DateTime _joinTime;
        private DateTime _leaveTime;

        public string Name
        {
            get { return _name; }   
            set
            {
                // Throw an exception if the new value is null or an empty string or contains just whitespaces
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be null or empty or whitespaces only");
                }
                _name = value;
            }
        }
        public DateTime JoinTime
        {
            get { return _joinTime; }
            set { _joinTime = value; }
        }
        public DateTime LeaveTime
        {
            get { return _leaveTime; }      
            set { _leaveTime = value; }
        }

        // Define an constructor with a parameter for the Name and write code 
        // inside to assign JoinTime to current date time.
        public Participant(string name)
        {
            Name = name;
            JoinTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Name: {Name}, JoinTime: {JoinTime}, LeaveTime: {LeaveTime}";
        }

    }
}
