namespace JokesWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string? jokeQuestion { get; set; }
        public string? jokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
