using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Pages;

namespace WebApplication1.Models
{
    public class MathOperations
    {
        //Define class properties
        public string operation { get; set; }
        public double input_one { get; set; }
        public double input_two { get; set; }
        public double retval { get; set; }


        public void Run()
        {
            if(this.operation != null)
            {
                _checkOp();
            }
            else
            {
                Console.WriteLine("Error: make sure you are inputing an operation.");
            }
        
        }

        private void _checkOp()
        {
            //Add conditional logic to call on methods below.
            
        }

        //write add and subtract methods to use above.
        private void _add()
        {
            //fill in here
        }
        private void _subtract()
        {
            //fill in here
        }




    }
}
