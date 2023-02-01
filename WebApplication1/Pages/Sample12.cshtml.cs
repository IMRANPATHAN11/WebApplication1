using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace WebApplication1.Pages
{
    public class Sample12Model : PageModel
    {
        public string message;
        public void OnGet()
        {
            message = "this is first request";
        }
        public void OnPost (arithmatic A)
        {
            if(A.operation=="ADD")
            {
                A.result=A.num1+A.num2;
                message = "addition is" + A.result;
            }
            else if(A.operation=="SUBSTRACT")
            {
                A.result = A.num1 - A.num2;
                message = "substract is" + A.result;
            }
            else if (A.operation == "MULTIPLY")
            {
                A.result = A.num1 * A.num2;
                message = "multiply is" + A.result;
            }
            else if (A.operation == "DIVIDE")
            {
                A.result = A.num1 / A.num2;
                message = "quetient is" + A.result;
            }
        }
    }
}
