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

            var pairs = from i in Enumerable.Range(0, list.Count - 1)
                        let x = list[i]
                        from y in list.Skip(i + 1)
                        select Tuple.Create(
                         $"{x.Name}_{x.SecondName} - {y.Name}_{y.SecondName}",
                         x.Location.Distance(y.Location));

            var maxD = pairs.Aggregate((x, y) => x.Item2 > y.Item2 ? x : y);
            var minD = pairs.Aggregate((x, y) => x.Item2 > y.Item2 ? y : x);

            Console.WriteLine($"Max: {maxD}\nMin: {minD}");

            var friends = from p in list
                          where p.FriendsName == "Oleg"
                          select new
                          {
                              Name = p.Name,
                              SecondName = p.SecondName
                          };


            Console.WriteLine("A common friend:");
            foreach ( var i in friends)
            {
                Console.WriteLine($"{i.Name}  {i.SecondName}");
            }
        }
    }
}