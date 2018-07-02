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
          return View();
      }
  }
}
