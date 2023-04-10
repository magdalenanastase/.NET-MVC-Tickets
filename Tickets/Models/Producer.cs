using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Data.Base;

namespace Tickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="The profile picture is required.")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage ="The Full Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = " Full Name must be between 3 and 50 chars")]

        public string FullName { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage ="The biography is required.")]
        public string Bio { get; set; }

        //Relationships

        //public List<NewMovieVM> Movies { get; set; }

    }
}
