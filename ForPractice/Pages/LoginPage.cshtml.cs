using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForPractice.Pages
{
    public class LoginPageModel : PageModel
    {
        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
