using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace restraunt.Views.Home
{
    public class DetailPage : PageModel
    {
        private readonly ILogger<DetailPage> _logger;

        public DetailPage(ILogger<DetailPage> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}