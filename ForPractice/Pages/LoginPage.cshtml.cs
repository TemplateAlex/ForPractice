using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ForPractice.Model;

namespace ForPractice.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly BookNetDBContext _context;
        [BindProperty]
        public string Nickname { get; set; }

        [BindProperty]
        public string Password { get; set; }


        public LoginPageModel(BookNetDBContext db)
        {
            _context = db;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var user = _context.Users.FirstOrDefault(user => user.Nickname == Nickname);

            if (user != null && user.Password == Password)
            {
                var role = _context.Roles.FirstOrDefault(role => role.Id == user.RoleId);
                HttpContext.Session.SetString("nickname", Nickname);
                HttpContext.Session.SetString("role", role.RoleName);
                return RedirectToPage("Index");
            }

            return RedirectToPage("Error");
        }
    }
}
