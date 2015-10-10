using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestValidations.Models
{
    public class IMDB
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string MovieTitle { get; set; }
        public string Actor { get; set; }
        public string Producer { get; set; }


        [Column("Year")]
        [Display(Name = "Release Year")]
        public string ReleaseYear { get; set; }

        [Column("Rating")]
        [Display(Name = "Rating")]
        public decimal Rating { get; set; }
    }
}