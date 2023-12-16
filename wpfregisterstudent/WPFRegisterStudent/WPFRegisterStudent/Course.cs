using System;

namespace WPFRegisterStudent
{
    class Course
    {
        private string name;
        private bool isRegisteredAlready;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsRegisteredAlready
        {
            get { return isRegisteredAlready; }
        }

        public Course(string name)
        {
            this.name = name;
            this.isRegisteredAlready = false;
        }

        public void SetToRegistered()
        {
            isRegisteredAlready = true;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
