using Microsoft.AspNetCore.Mvc;
using WordGame.Models;

namespace WordGame.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult AnagramForm()
      {
          return View();
      }

      [Route("/anagram_results")]
      public ActionResult AnagramResults()
      {
          Anagram newGame = new Anagram();
          newGame.SetBaseWord(Request.Query["baseWord"]);
          newGame.SetWordList(Request.Query["wordList"]);
          newGame.FindAnagram();
          return View(newGame);
      }
  }
}
