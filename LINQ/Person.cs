 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LINQ
{
    internal class Person
    {
        public string Name;
        public string SecondName;
        public GeoCordinate Location;
        public string FriendsName;

        public Person(string name, string secondName, GeoCordinate location, string friendsName)
        {
            Name = name;
            SecondName = secondName;
            Location = location;
            FriendsName = friendsName;
        }


    }
}
