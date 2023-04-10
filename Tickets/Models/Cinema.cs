using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tickets.Data.Base;

namespace Tickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name=" Cinema Logo")]
        [Required(ErrorMessage ="The cinema logo is required.")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "The name is required.")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage ="The description is required.")]
        public string Description { get; set; }

        //public List<NewMovieVM> Movies { get; set; }
    }
}
