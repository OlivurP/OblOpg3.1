using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OblOpg3._1.Repository;
using OblOpg3._1.Model;

namespace OblOpg3._1.Pages
{
    public class IndexModel : PageModel
    {
        private UserRepository userRepository = new UserRepository();
        private readonly ILogger<IndexModel> _logger;
        public static int LoggedInId { get; set; }

        [BindProperty]
        public User user { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            userRepository.GetAllUsers();
        }
        
        public IActionResult OnPost() 
        {
            string url = "/";
            if(userRepository.CheckValidUser(user))
            {
                LoggedInId = user.Id;
                url = "/Frugter/FrugtPage";
            }
            return Redirect(url);
        }
    }
}