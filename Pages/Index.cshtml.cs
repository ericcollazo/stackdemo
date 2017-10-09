using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace stackdemo.Pages
{
    public class IndexModel : PageModel
    {
        public string HostName;
        public void OnGet()
        {
            HostName = System.Net.Dns.GetHostName();
        }
    }
}
