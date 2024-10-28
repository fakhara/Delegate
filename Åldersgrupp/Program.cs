namespace Åldersgrupp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("Alice", 25),
                new Person("Bob", 45),
                new Person("Charlie", 15),
                new Person("Diana", 75)

            };
            Display.DisplayPeople("Barn:", people, Display.IsChild);
            Display.DisplayPeople("Vuxna:", people, Display.IsAdult);
            Display.DisplayPeople("Pensionærer:", people, Display.IsPensioner);
        }
    }
}