using CandidateManagement.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateManagement_HuynhNhan.Pages.LoginPage
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        private IHRAccountRepository hRAccountRepository;

        public IndexModel(IHRAccountRepository hRAccountRepository)
        {
            this.hRAccountRepository = hRAccountRepository;
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                var account = hRAccountRepository.GetAccount(Email, Password);
                if (account != null && (account.MemberRole == 2))
                {
                    TempData["Message"] = "Login success";
                    Console.WriteLine("Login success");
                    HttpContext.Session.SetInt32("RoleID", account.MemberRole ?? default);
                    return RedirectToPage("/CandidatePage/Index");
                }
                else
                {
                    TempData["Message"] = "You are not allowed to do this function!";
                    return Page();
                }

            }
            catch(Exception e)
            {
                TempData["Message"] = e.Message;
                return Page();
            }
        }
    }
}
