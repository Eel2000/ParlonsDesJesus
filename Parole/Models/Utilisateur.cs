using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parole.Models
{
    //this class is optional 
    //it's for all user but 
    //to do it propertly we create a new class named "user"
    //and inherit it from IdentityUser to have access 
    public class Utilisateur
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Pseudo { get; set; }

        [Required]
        public string Names { get; set; }

        public int IdUser { get; set; }

        public List<Subject> Subjects { get; set; }
        public List<Response> Responses { get; set; }

        //navigation properties
        public User UserHimSelf { get; set; }
    }
}