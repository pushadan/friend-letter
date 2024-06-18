using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  // the word "Controller" is omitted from the path we created
  // localhost:5000/home/hello instead of /homeController 
  public class HomeController : Controller
  {
    [Route ("/")]
    public ActionResult Letter() {
      var newLetterVariable = new LetterVariable("Sam", "Danny");
      return View(newLetterVariable);
    }
    [Route ("/form")]
    public ActionResult Form() {
      return View();
    }
    [Route ("/postcard")]
    public ActionResult PostCard(string sender, string recipient) {
      var newLetterVariable = new LetterVariable(recipient, sender);
      return View(newLetterVariable);
    }

    [Route ("/hello")]
    public string Hello() {
      return "Hello World!";
    }
    [Route ("/goodbye")]
    public string Goodbye() {
      return "Goodbye!";  
    }
    [Route ("/TestPage")]
    public ActionResult TestPage() {
      return View();
    } 
  }
  public class UserController : Controller 
  {
    [Route ("user/user-page")]
    public ActionResult UserPage() {
      return View();
    }
  }
}