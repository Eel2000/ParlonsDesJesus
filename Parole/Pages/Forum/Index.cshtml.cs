using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Parole.Data.Services;
using Parole.Models;

namespace Parole.Pages.Forum
{
    public class IndexModel : PageModel
    {
        private readonly IServices _services;

        public IndexModel(IServices services)
        {
            _services = services;
        }

        public IEnumerable<Subject> Subjects { get; set; }

        public void OnGet()
        {
            Subjects = _services.SubjectList();
        }
    }
}