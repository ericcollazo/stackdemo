using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace stackdemo.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            string hostname = System.Net.Dns.GetHostName();
            Message = "This site is being served from: " + hostname;
        }
    }
}
