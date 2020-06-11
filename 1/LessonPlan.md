## 3.2 Lesson Plan: Introduction to .NET

---

# Overview

write overview of today's class

# Class Objectives 

### Declarative Memory Objectives (concepts/facts/semantics)

* .NET core concepts

* C# and objective oriented concepts required for .NET

### Procedural Memory Objectives (learn by doing/type and hand write code)

* Write a calculator console application. (Visual Studio)

* Hand write simple OOP hello world application
**Goal of this activity is to have students remember basic objective oriented programming principles that are needed for a simple a web application.

* Write a simple ASP.NET web application (Visual Studio)

# Class Slides

*Add link to google slide show for instructor to use.

# Instructor Notes

*write generic instructor notes

---

### 1. Instructor Do: Course pre-reqs and pace (2 min)

explain prereqs and assumptions. recommend resource to catch up. Installing

### 2. Instructor Do: Introduce .NET  (15 min)
talk about .NET and a high level overview of all that is possible
why .NET

### 4. Instructor Do: go over basic syntaxs (5 min)

### 5. Instructor Do: Talk about visual studio and create sample project (5 min)
project will be the Ins_console_app, add 2 functions.

```c#
using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorConsole_App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Since first lecture we are not covering exception handeling.

            Console.WriteLine("Simple Calculator App");
            Console.WriteLine("Enter large number:");
            Double input_one = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter small number:");
            Double input_two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add or Subtract");
            string operation = Console.ReadLine();
            Double retval = 0;

            if (operation == "add")
            {
                retval = input_one + input_two;
            }
            if (operation == "subtract")
            {
                retval = input_one - input_two;
            }
        
            Console.WriteLine("Calculated amount:" + Convert.ToString(retval));
            Console.ReadKey();
        }

    }
}

```

### 6. Instructor Do: Ask students about classes, objects, methods, properties (5 min) 
If students catch on quickly then review basic OOP concepts 

### 7. Student Do (Individual Activity): Programming the rust out on paper. (5 min)
Have students write with pen and paper a class that contains a method called main(). The method will write "hello world" to a console.
This activity needs to be done in c#. Emphasize to the students that the best way to fully learn a new language is to write it down with pen/pencil and paper. This is a form of procedural learning.

### 8. Instructor Do: Introduce the web stack of .NET (5 min)

### 9. Instructor Do: Implement logic from console app into web application (8 minutes)

```
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
        
```
The front end file index.cshtml

```
@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

    <div class="text-center">
        <h1>Wow .NET Core is awesome and so is 2u!!!</h1>

        <h3>If using the Factorial button only input the value in the first field and input 0 in the second field.</h3>

        <h1>@Model.DisplayVal</h1>
      
        <form method="post">

            <div>

                <input type="number" name="num1" />
                <input type="number" name="num2" />
            </div>
            <br />
            <div>
                <br />
                <input type="radio" name="operation" value="add" /> Add<br />
                <input type="radio" name="operation" value="subtract" /> Subtract <br />
                
                <input type="submit" value="Submit" />

            </div>
        </form>      
        </div>

```

Index.cshtml.cs is the file where the backend meets with the front end in order to obtain user input and preform opertations on it.

```

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
            Models.MathOperations calc = new Models.MathOperations();
            calc.input_one =  Convert.ToDouble(Request.Form["num1"]);
            calc.input_two = Convert.ToDouble(Request.Form["num2"]);
            calc.operation = Request.Form["operation"];

            calc.Run();

            DisplayVal = calc.retval;
        }

        public void OnGet()
        {

        }
    }
}



```

### 10. Student Do: Add more functionality to Calc_Web_App (10 min)
Encourage student to take this application and continue to add more functionalilty to it after class. If time permits go over the solution file during class. Begin the next class with a brief review of this activity solution.

---
End Class

