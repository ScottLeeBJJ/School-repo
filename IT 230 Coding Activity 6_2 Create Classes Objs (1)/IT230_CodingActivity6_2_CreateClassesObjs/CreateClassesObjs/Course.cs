namespace CreateClassesObjs
{
    public class Course
    {
        // Private field to hold the name of the course
        private string name;

        // Method to set the name field to a given string value
        public void setName(string name)
        {
            this.name = name;
        }

        // Method to retrieve the name field
        public string getName()
        {
            return name;
        }

        // Method that overrides the ToString() method
        public override string ToString()
        {
            // Return the name field
            return name;
        }
    }
}
