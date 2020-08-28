using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parole.Models
{
    public class User : IdentityUser
    {
        public List<Subject> Subjects { get; set; }
        public List<Response> Responses { get; set; }
    }
}