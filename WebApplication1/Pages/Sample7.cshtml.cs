using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Sample7Model : PageModel
    {
        public string message;
        public void OnGet()
        {
            message = "this is first request";
        }
        public void onpost()
        {
            message = "this is postback request";
        }
    }
}
