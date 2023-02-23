using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Practice.Pages
{
    public class Form : PageModel
    {
        [BindProperty] // BindProperty is required for the validation to work
        public string? Name { get; set; } // ? means it can be null


        [BindProperty] // BindProperty is required for the validation to work
        [Range(1, 100)] // 1-100
        public int Age { get; set; } 
        

        public void OnGet()
        {
        }
        public void OnPost()
        {
            if (ModelState.IsValid) // ModelState.IsValid is required for the validation to work
            {
                ViewData["Greeting"] = $"Hello {Name}, you are {Age} years old.";
            }
        }
    }
}