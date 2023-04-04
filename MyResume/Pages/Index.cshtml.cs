using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyResume.Pages
{
    public class IndexModel : PageModel
    {
        public string? FullName { get; set; }
        public string? LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string>? Languages { get; set; }

        public void OnGet()
        {
            FullName = "Igor Makowski";
            LinkedInUsername = "My Telegram";
            YearsOfExperience = 2;
            Languages = new List<string> { "Russian(native)", "English(intermediate)", "Japanese (N5)" };
        }

    }
}