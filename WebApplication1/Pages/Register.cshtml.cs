using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [BindProperty]
        [DataType(DataType.Date)]
        public DateTime ConsultationDate { get; set; }

        [BindProperty]
        public string Product { get; set; }

        public void OnGet()
        {
            // Код для виконання при першому завантаженні сторінки
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Логіка обробки форми реєстрації

            return RedirectToPage("/Index"); // Перенаправлення на іншу сторінку після успішної реєстрації
        }
    }
}

