using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult HomeForm() {
    return View();
    }

    [Route("/springmlform")]
    public ActionResult SpringMLForm() {    return View(); }

    [Route("/springmlgardenform")]
    public ActionResult SpringMLGardenForm() { return View(); }

    [Route("/springmlfactsform")]
    public ActionResult SpringMLFactsForm() {
    return View(); }

    [Route("/gardenstory")]
    public ActionResult GardenStory(string noun, string adjective, string noun2, string noun3, string noun4, string noun5, string noun6, string tool, string noun7, string adjective2) { 
        MadLibVariableGarden myMadLibVariableGarden = new MadLibVariableGarden();
        myMadLibVariableGarden.Noun = noun;
        myMadLibVariableGarden.Adjective = adjective;
        myMadLibVariableGarden.Noun2 = noun2;
        myMadLibVariableGarden.Noun3 = noun3;
        myMadLibVariableGarden.Noun4 = noun4;
        myMadLibVariableGarden.Noun5 = noun5;
        myMadLibVariableGarden.Noun6 = noun6;
        myMadLibVariableGarden.Tool = tool;
        myMadLibVariableGarden.Noun7 = noun7;
        myMadLibVariableGarden.Adjective2 = adjective2;
        return View(myMadLibVariableGarden);
    }
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