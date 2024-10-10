using Candidate_BussinessObjects.Models;
using Candidate_Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CandidateRazorWeb.Pages
{
    public class LoginModel : PageModel
    {
        private IHRAccountService hraccountService;
        public LoginModel(IHRAccountService hraccountService)
        {
            this.hraccountService = hraccountService;
        }
        public void OnGet()
        {
        }
        public void OnPost() {
            string email = Request.Form["txtEmail"];
            string password = Request.Form["txtPassword"];
            Hraccount hraccount = hraccountService.GetHraccount(email);
            if (hraccount != null && hraccount.Password.Equals(password))
            {
                int? roleId = hraccount.MemberRole;
                HttpContext.Session.SetString("RoleID", roleId.ToString());
                Response.Redirect("/JobPostingPage/Index");
            }  
            //else
            //{
            //    Response.Redirect("/Permission");
            //}
        }
    }
}
