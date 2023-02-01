using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Pages
{
    public class arithmatic

    {
        [BindProperty]
        public int num1 { set; get; }
        
        [BindProperty]
        public int num2 { set; get; }   

        [BindProperty]
            public int result{ set; get; }
        [BindProperty]
        public string operation { set; get; }
    }
}
