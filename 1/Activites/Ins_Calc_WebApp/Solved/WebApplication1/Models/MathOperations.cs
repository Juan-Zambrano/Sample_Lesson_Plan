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
            if (this.operation == "add")
            {
                _add();
            }
            if (this.operation == "subtract")
            {
                _subtract();
            }
            if (this.operation == "multiple")
            {
                _multiply();
            }
            if (this.operation == "divide")
            {
                _divide();
            }
            if (this.operation == "factorial")
            {
                _Calculate_Factorial();
            }
           
        }


        private void _add()
        {
            var _retval = this.input_one + this.input_two;
            this.retval = _retval;
        }

        private void _subtract()
        {
            var _retval = this.input_one - this.input_two;
            this.retval = _retval;
        }

        private void _multiply()
        {
            var _retval = this.input_one * this.input_two;
            this.retval = _retval;
        }
        private void _divide()
        {
            var _retval = this.input_one / this.input_two;
            this.retval = _retval;
        }

        private void _Calculate_Factorial()
        {
            this.retval = SpecialFunctions.Factorial(Convert.ToInt32(this.input_one));
        }

     



    }
}
