namespace NumberGuessingGame.Models
{
    public class GameModel
    {
        public int SecretNumber { get; set; }
        public int? UserGuess { get; set; }
        public string ResultMessage { get; set; }
    }

}
