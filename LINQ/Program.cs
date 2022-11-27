using System.Drawing;
using System.Text;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>
            {
                new Person("Vlad", "Pob", new GeoCordinate(-54.32, 84.63), "Oleg"),
                new Person("Oleg", "Berd", new GeoCordinate(3.37, -115.48),"Kolya"),
                new Person("Kiril", "Old", new GeoCordinate(-23.0, 45.89), "Oleg"),
                new Person("Vasya", "Melt", new GeoCordinate(88.7, 2.12), "Oleg"),
                new Person("Stepan", "Valid", new GeoCordinate(34.86, 154.35), "Denis"),
             };


            

            var northiest = list.MaxBy(p => p.Location.Latitude);
            var southiest = list.MinBy(p => p.Location.Latitude);
            var westiest = list.MaxBy(p => p.Location.Longitude);
            var eastier = list.MinBy(p => p.Location.Longitude);

            Console.WriteLine($"Northies:{northiest.Name + " " + northiest.SecondName}" +
                $"\nSouthiest: {southiest.Name + " " + southiest.SecondName}" +
                $"\nEastier: {eastier.Name + " " + eastier.SecondName}" +
                $"\nWestiest: {westiest.Name + " " + westiest.SecondName} ");        


        }
    }
}