namespace StudentDatabase
{
    class StudentsObject
    {
        public string HometownProperty { get; set; }
        public string FavFoodProperty { get; set; }
        public string StudentNameProperty { get; set; }

        public int StudentAge { get; set; }

        //now for the constructor to give 
        public StudentsObject(string StudentNameProperty, string HometownProperty, string FavFoodProperty, int StudentAge)
        {
            //Store properties in the object:
            this.StudentNameProperty = StudentNameProperty;
            this.HometownProperty = HometownProperty;
            this.FavFoodProperty = FavFoodProperty;
            this.StudentAge = StudentAge;

        }

    }

}
