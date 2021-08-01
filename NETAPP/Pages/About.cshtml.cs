using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NETAPP.Pages
{
    public class AboutModel : PageModel
    {
        public string[] clients { get; set; }

        public void OnGet()
        {
            ViewData["WelcomeMessage"] = "We are happy to have you here. We basically sell books";

           clients = new string[5] { "Google", "Facebook", "Yahoo", "Twitter", "Microsoft" };

        }
    }
}
