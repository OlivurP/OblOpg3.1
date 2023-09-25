using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OblOpg3._1.Repository;
using OblOpg3._1.Model;

namespace OblOpg3._1.Pages.Kurven
{
    public class IndexModel : PageModel
    {
        private KurvRepository kurvRepository = new KurvRepository();
        public static List<Kurv> kurvList;

        [BindProperty] 
        public Kurv minKurv { get; set; }
        public void OnGet()
        {
            kurvList = kurvRepository.GetAllItems(Pages.IndexModel.LoggedInId);
        }
    }
}
