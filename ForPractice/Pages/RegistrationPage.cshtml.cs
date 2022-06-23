using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ForPractice.Pages
{
    public class RegistrationPageModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Reppasswd { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
}
