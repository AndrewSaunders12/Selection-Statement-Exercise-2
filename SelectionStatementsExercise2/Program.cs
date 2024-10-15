namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Yea math is cool, im not the best at it.");
                    break;
                case "histroy":
                    Console.WriteLine("Americas history is so vast!");
                    break;
                case "science":
                    Console.WriteLine("Science is all around us");
                    break;
                case "english":
                    Console.WriteLine("I like books");
                    break;
                case "gym":
                    Console.WriteLine("I Loved gym class!!");
                    break;
                default:
                    Console.WriteLine("Thats intresting, whats it like?");
                    break;
            }
        }
    }
}