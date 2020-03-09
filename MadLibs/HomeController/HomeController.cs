using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    public string Hello() { return "Hello friend!"; }

    public string Goodbye() { return "Goodbye friend."; }
    [Route("/")]
    public ActionResult MadLib() { 
        MadLibVariable myMadLibVariable = new MadLibVariable();
        myMadLibVariable.Recipient = "Lina";
        myMadLibVariable.Sender = "Jasmine";
        return View(myMadLibVariable);
    }
    [Route("/form")]
    public ActionResult SpringMLForm() { return View(); }
    [Route("/Story")]
    public ActionResult Story(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }   
}