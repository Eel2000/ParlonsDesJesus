using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parole.Data.Services;

namespace Parole.Pages.Forum
{
    public class IndexModel : PageModel
    {
        private readonly Services _services;

        public IndexModel(Services services)
        {
            _services = services;
        }

        public void OnGet()
        {

        }
    }
}