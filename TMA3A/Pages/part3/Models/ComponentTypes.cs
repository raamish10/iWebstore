using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TMA3A.Pages.part3.Models
{
    public class ComponentTypes 
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Component Type")]
        public string ComponentType { get; set; }

    }
}
