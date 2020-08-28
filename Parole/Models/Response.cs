using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parole.Models
{
    public class Response
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name="Reponse")]
        [DataType(DataType.Text)]
        public string Body { get; set; }
        
        [Required]
        [Display(Name="")]
        [DataType(DataType.DateTime),DisplayFormat(DataFormatString="{0:dd/MM/yy}",ApplyFormatInEditMode=true)]
        public DateTime SubmitDate { get; set; } = DateTime.UtcNow;

        public int IdSubject { get; set; }
        public string IdUser { get; set; }

        
        //navigation properties
        public Subject Subject { get; set; }

        public User User { get; set; }
    }
}