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
    [Route("/springmlform")]
    public ActionResult SpringMLForm() { return View(); }
    [Route("/story")]
    public ActionResult Story(string color, string color2, string adjective, string animals, string adjective2, string animals2, string animals3, string color3, string noun, string color4, string adjective3, string color5, string verb2, string adjective4)
    {
      MadLibVariable myMadLibVariable = new MadLibVariable();
      myMadLibVariable.Color = color;
      myMadLibVariable.Color2 = color2;
      myMadLibVariable.Adjective = adjective;
      myMadLibVariable.Animals = animals;
      myMadLibVariable.Adjective2 = adjective2;
      myMadLibVariable.Animals2 = animals2;
      myMadLibVariable.Animals3 = animals3;
      myMadLibVariable.Color3 = color3;
      myMadLibVariable.Noun = noun;
      myMadLibVariable.Color4 = color4;
      myMadLibVariable.Adjective3 = adjective3;
      myMadLibVariable.Color5 = color5;
      myMadLibVariable.Verb2 = verb2;
      myMadLibVariable.Adjective4 = adjective4;
      return View(myMadLibVariable);
    }
  }   
}