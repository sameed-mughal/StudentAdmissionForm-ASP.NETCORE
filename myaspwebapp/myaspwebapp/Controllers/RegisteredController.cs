using Microsoft.AspNetCore.Mvc;
using myaspwebapp.Models;

namespace myaspwebapp.Controllers
{
    public class RegisteredController : Controller
    {
        public IActionResult RegisterForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult RegisterForm(Registered registered)
        {

           ViewBag.Message = "Form has been Submitted Successfully";
            ModelState.Clear();
            return View();

        }



    }
}
