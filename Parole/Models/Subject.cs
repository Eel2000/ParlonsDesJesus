using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parole.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Sujet")]
        public string Title { get; set; }

        [Required]
        [Display(Name="Date d'ajout")]
        [DataType(DataType.DateTime),DisplayFormat(DataFormatString="{0:dd/MM/yy}", ApplyFormatInEditMode=true)]
        public DateTime DateDAjout { get; set; } = DateTime.UtcNow;

        public string IdUser { get; set; }

        public List<Response> Responses { get; set; }

        //navigatino properties
        public User User { get; set; }

    }
}