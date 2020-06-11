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
Microsoft .NET has been around for two decades. Microsoft began to first build .NET in the 90's but did not release their first build until 2000. In contrast to popular belief by non-technical individuals (cough cough recruiters), .NET or dotnet (that's how it is acutally pronouce) is a software framework not a programming language. That being said think of .NET as a bucket that holds common runtime enviroments,libraries, and other common type systems. Now that we clearify that let's talk about how we develope on this framework. (**Clearify to the students that the term framework alone is a generic term used to describe many software kits.Therefore .NET Framework and .NET Core (what we will be using) both use the .NET software Framework**) There are many ways write on the .NET Framework languages such as vb.net,F#,J#,C++, and C# can be used. The most common language and the one we will use in this course is C# (aka like java but you don't have to worry about memory management as much). 
![C#_2_.NET](https://docs.microsoft.com/zh-tw/dotnet/csharp/getting-started/media/netarchitecture.png)

As we can see in the diagram above, one would write C# code, which would then get compiled to .NET compliant code (intermediate language). IL code will then be consumed by the CLR(common language runtime) and converted into platform specific code by the JIT (just-in-time) compiler. 

**Depending on the audiance skill level and intrest level go over this in detail, if the audiance is not intrested glaze over this and jump to the next image.**

![.NET_IMG](https://www.intelegain.com/wp-content/uploads/2018/06/xNet-Standerd-Library.png.pagespeed.ic.Ur3-yx6RAs.png)

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

```c#
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
            if (this.operation == "add")
            {
                _add();
            }
            if (this.operation == "subtract")
            {
                _subtract();
            }
        }

        //write add and subtract methods to use above.
        private void _add()
        {
            //fill in here
            var _retval = this.input_one + this.input_two;
            this.retval = _retval;
        }

        private void _subtract()
        {
            //fill in here
            var _retval = this.input_one - this.input_two;
            this.retval = _retval;
        }
    }
        
```
The front end file index.cshtml

```c#
@page
@model IndexModel
@{
    ViewData["Title"] = "Home page";
}

    <div class="text-center">
        <h1>Wow .NET Core is awesome and so is 2u!!!</h1>
        
        <h1>@Model.DisplayVal</h1>
      
        <form method="post">

            <div>
                <input type="number" name="num1" />
                <input type="number" name="num2" />
            </div>
            <br />
            <div>
                <br />
                @*Add the radio input tags in html*@
                <input type="radio" name="operation" value="add" /> Add<br />
                <input type="radio" name="operation" value="subtract" /> Subtract <br />
                
                <input type="submit" value="Submit" />

            </div>
        </form>      
        </div>

```

Index.cshtml.cs is the file where the backend meets with the front end in order to obtain user input and preform opertations on it.

```c#

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
            calc.input_one =  Convert.ToDouble(Request.Form["num1"]);
            calc.input_two = Convert.ToDouble(Request.Form["num2"]);
            calc.operation = Request.Form["operation"];

            //run calc
            calc.Run();
            
            //Display Value
            DisplayVal = calc.retval;
        }

        public void OnGet()
        {
            //for this application , this method is not really needed.
        }
    }
}



```

### 10. Student Do: Add more functionality to the calculator web application (10 min)
Student Activity: [Stu_Calc_WebApp](https://github.com/Juan-Zambrano/Sample_Lesson_Plan/tree/master/1/Activites/Stu_Calc_WebApp)

Have the students take off where you left off by adding more functionalilty to the calculator web app. Have your TA assist and prevent students from getting overwhelmed with all of the features in visual studio.
The three locations where students need to add features too are:
1. Pages/index.cshtml
2. Pages/index.cshtml.cs
3. Models/MathOperations.cs
    
 **Reframe students from modifying the Program.cs and Startup.cs files**
 
 Have students work in debug mode.

Encourage student to take this application and continue to add more functionalilty to it after class (eg. Tan(x),Sin(x),e^x). If time permits go over the solution file during class. Begin the next class with a brief review of this activity solution.

---

### If class is 3 hours, go through the following 5 questions in order to fully assess weather students are on the right track or not.
[Part 2](https://github.com/Juan-Zambrano/Sample_Lesson_Plan/tree/master/1/Supplemental)

---
End Class

