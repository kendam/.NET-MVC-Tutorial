using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETAPP.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }
        [BindProperty]
        public string EmailAddress { get; set; }
        [BindProperty]
        public string Phone {get; set;}
        [BindProperty]
        public string Message { get; set; }

        public void OnGet()
        {
           
        }
    }
}
