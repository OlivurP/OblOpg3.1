using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OblOpg3._1.Data;
using OblOpg3._1.Model;
using OblOpg3._1.Repository;

namespace OblOpg3._1.Pages.Frugter
{
    public class FrugtPageModel : PageModel
    {
        private readonly OblOpg3._1.Data.OblOpg3_1Context _context;
        private FrugtRepository frugtRepository = new FrugtRepository();
        private KurvRepository kurvRepository = new KurvRepository();
        
        public FrugtPageModel(OblOpg3._1.Data.OblOpg3_1Context context)
        {
            _context = context;
        }
        [BindProperty]
        public int frugtId { get; set; }
        public IList<Frugt> FrugtList { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Frugt != null)
            {
                FrugtList = await _context.Frugt.ToListAsync();
            }
        }

        public IActionResult OnPostAddToKurv()
        {
            int userId = IndexModel.LoggedInId;
            kurvRepository.AddToKurv(userId, frugtId);
            FrugtList = frugtRepository.GetAllFrugt();
            return Redirect("/Kurven/Index");
        }
    }
}
