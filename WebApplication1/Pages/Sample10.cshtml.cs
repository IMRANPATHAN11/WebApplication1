using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages;
    public class users
{
    [BindProperty]
    public string Uname { get; set; }
    [BindProperty]
    public string password { get; set; }
}

    public class Sample10Model : PageModel
    {

    public string message;
        public void OnGet()
        {
        message = "this is first request";
        }
    public void onpost(users u)
    {
        message="user name is"+u.Uname+"password is "+u.password;
    }
    }
