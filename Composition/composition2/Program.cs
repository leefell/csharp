using composition2.Entities;

namespace composition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("That's awesome!");
            Post p1 = new Post(DateTime.Parse("21/12/2018 13:05:44"), "Travelling to New Zeeland", "I'm going to visit this country!", 12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the Force be with you!");
            Post p2 = new Post(DateTime.Now, "Good night guys", "See you tomorrow!", 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}