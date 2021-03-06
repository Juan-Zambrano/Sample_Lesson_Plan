﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;


namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public double DisplayVal { get; set; }

       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
       

        public void OnPost()
        {
            //Instantiate calculator object
            Models.MathOperations calc = new Models.MathOperations();

            //Access Form attributes
            calc.input_one = Convert.ToDouble(Request.Form["num1"]);
            calc.input_two = Convert.ToDouble(Request.Form["num2"]);
            calc.operation = Request.Form["operation"];

            //run calc
            calc.Run();

            //Display Value
            DisplayVal = calc.retval;
        }

        public void OnGet()
        {

        }
    }
}
