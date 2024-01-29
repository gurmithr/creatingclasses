using System;


namespace CreatingClasses

{
    internal class Person
    {
        public int personId;
        public int age;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public bool isWorking;

        public void DisplayPersonInfo()
        {
            string fullname = this.firstName + " " + this.lastName;
            Console.WriteLine(this.personId + ": " + fullname + "'s favorite colour is " + this.favoriteColour);
        }

        public string ChangeFavoriteColour()
        {
            return this.favoriteColour = "White";
        }

        public void GetAgeInTenYears()
        {
            string fullname = this.firstName + " " + this.lastName;
            Console.WriteLine(fullname + "'s age in 10 years is " + (this.age + 10));
        }

        public void ToString()
        {
            Console.WriteLine("PersonId: " + this.personId + "\n" +
                "FirstName: " + this.firstName + "\n" +
                "LastName: " + this.lastName + "\n" +
                "FavoriteColour: " + this.favoriteColour + "\n" +
                "Age: " + this.age + "\n" +
                "IsWorking: " + this.isWorking);
        }
    }
}
