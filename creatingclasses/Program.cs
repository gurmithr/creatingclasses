using System;


namespace CreatingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person0 = new Person();
            person0.personId = 1;
            person0.firstName = "Ian";
            person0.lastName = "Brooks";
            person0.favoriteColour = "Red";
            person0.age = 30;
            person0.isWorking = true;

            Person person1 = new Person();
            person1.personId = 2;
            person1.firstName = "Gina";
            person1.lastName = "James";
            person1.favoriteColour = "Green";
            person1.age = 18;
            person1.isWorking = false;

            Person person2 = new Person();
            person2.personId = 3;
            person2.firstName = "Mike";
            person2.lastName = "Briscoe";
            person2.favoriteColour = "Blue";
            person2.age = 45;
            person2.isWorking = true;

            Person person3 = new Person();
            person3.personId = 4;
            person3.firstName = "Mary";
            person3.lastName = "Beals";
            person3.favoriteColour = "Yellow";
            person3.age = 28;
            person3.isWorking = true;

            person1.DisplayPersonInfo();

            person3.ToString();

            person0.ChangeFavoriteColour();

            person0.DisplayPersonInfo();

            person3.GetAgeInTenYears();

            Relation relation0 = new Relation();
            Relation relation1 = new Relation();

            relation0.RelationshipType = "Sisterhood";
            relation1.RelationshipType = "Brotherhood";
            relation0.ShowRelationShip(person2.firstName, person3.firstName);
            relation1.ShowRelationShip(person0.firstName, person2.firstName);

            List<Person> personList = new List<Person>();
            personList.Add(person0);
            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);

            float sumofAge = 0;
            for (int i = 0; i < personList.Count(); i++)
            {
                sumofAge += personList[i].age;
            }
            float averageAge = sumofAge / personList.Count();
            Console.WriteLine("Average age is: " + averageAge);

            int YoungestAge = 9999;
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].age <= YoungestAge)
                {
                    YoungestAge = personList[i].age;
                }
            }
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].age.Equals(YoungestAge))
                {
                    Console.WriteLine("The youngest Person is " + personList[i].firstName);
                }
            }

            int OldestAge = 0;
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].age > OldestAge)
                {
                    OldestAge = personList[i].age;
                }
            }
            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].age.Equals(OldestAge))
                {
                    Console.WriteLine("The Oldest Person is " + personList[i].firstName);
                }
            }

            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].firstName.StartsWith("M"))
                {
                    personList[i].ToString();
                }
            }

            for (int i = 0; i < personList.Count(); i++)
            {
                if (personList[i].favoriteColour.Equals("Blue"))
                {
                    personList[i].ToString();
                }
            }
        }
    }
}
