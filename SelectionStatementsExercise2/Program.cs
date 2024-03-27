namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())

            {
                case "math":
                    Console.WriteLine("Yay math so fun!");
                    break;
                case "history":
                    Console.WriteLine("Wow I love history to!");
                    break;
                case "science":
                    Console.WriteLine("Do you you Bill nye?");
                    break;
                case "spanish":
                    Console.WriteLine("Do you like the mexican quisine?");
                    break;
                case "gym":
                    Console.WriteLine("What is your favorite sport?");
                    break;
                default:
                    Console.WriteLine("Whats your favorite thing obout that?");
                    Console.WriteLine("Im not familiar with that");
                    Console.ReadLine();
                    Console.WriteLine("Thats a cool one");
                    break;










            }
        }
    }
}