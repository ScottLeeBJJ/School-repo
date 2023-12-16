using System;

namespace WPFRegisterStudent
{
    class Course
    {
        private string name;
        private bool isRegisteredAlready;

        // Use properties instead of explicit getter and setter methods
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsRegisteredAlready
        {
            get { return isRegisteredAlready; }
        }

        // Use a constructor to set initial values
        public Course(string name)
        {
            this.name = name;
            this.isRegisteredAlready = false; // Initialize to false by default
        }

        // You can remove the setName method since the property setter is available

        // You can remove the getName method since the property getter is available

        public void SetToRegistered()
        {
            isRegisteredAlready = true;
        }

        // Override the ToString method for better string representation
        public override string ToString()
        {
            return Name;
        }
    }
}
