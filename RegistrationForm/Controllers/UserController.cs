using RegistrationForm.Models;
using System.Web.Mvc;
namespace RegistrationForm.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View("userregistration");
        }
        public ActionResult userregistration(string Firstname, string Lastname, string Username, string Email, string Password, string ConfirmPassword, string PhoneNumber, string Gender, string Age, string Address)
        {
            User gd = new User();

            gd.Firstname = Firstname;
            gd.Lastname = Lastname;
            gd.Username = Username;
            gd.Email = Email;
            gd.Password = Password;
            gd.ConfirmPassword = ConfirmPassword;
            gd.PhoneNumber = PhoneNumber;
            gd.Gender = Gender;
            gd.Age = Age;


            gd.Address = Address;
            return View(gd);
        }
        public ActionResult getuserdetail()

        {
            User obj = new User();

            obj.Firstname = "";
            obj.Lastname = "";
            obj.Username = "";
            obj.Email = "";
            obj.Password= "";
            obj.ConfirmPassword = "";
            obj.PhoneNumber = "";

            obj.Gender = "";
            obj.Age = "";
            obj.Address = "";

            return View();
        }
      
      
    }
}