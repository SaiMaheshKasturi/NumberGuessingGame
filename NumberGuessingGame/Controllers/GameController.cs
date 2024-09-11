using Microsoft.AspNetCore.Mvc;
using NumberGuessingGame.Models;

public class GameController : Controller
{
    private static GameModel gameModel = new GameModel();

    public IActionResult Index()
    {
        if (gameModel.SecretNumber == 0)
        {
            gameModel.SecretNumber = new Random().Next(1, 101); // Generate a random number between 1 and 100
        }
        return View(gameModel);
    }

    [HttpPost]
    public IActionResult Guess(int guess)
    {
        gameModel.UserGuess = guess;

        if (guess < gameModel.SecretNumber)
        {
            gameModel.ResultMessage = "Too low!";
        }
        else if (guess > gameModel.SecretNumber)
        {
            gameModel.ResultMessage = "Too high!";
        }
        else
        {
            gameModel.ResultMessage = "Congratulations! You guessed it right!";
        }

        return RedirectToAction("Index");
    }

    public IActionResult Reset()
    {
        gameModel = new GameModel(); // Reset the game
        return RedirectToAction("Index");
    }
}
namespace NumberGuessingGame.Controllers
{
    public class GameController
    {
    }
}
