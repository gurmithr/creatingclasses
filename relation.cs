using System;


namespace CreatingClasses
{
    internal class Relation
    {
        public string RelationshipType;

        public void ShowRelationShip(string name0, string name1)
        {
            Console.WriteLine("Relationship between " + name0 + " and " + name1 + " is " + this.RelationshipType);
        }
    }
}