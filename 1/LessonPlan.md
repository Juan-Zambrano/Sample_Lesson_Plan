## 3.2 Lesson Plan: Introduction to .NET

---

# Overview

Today's class is meant to introduce students to the .NET Software developement framework. This class will focus on understanding .NET concepts, writting c# and getting a feel for using .NET App Models such as ASP.NET Core web app. 

# Class Objectives 

### Declarative Memory Objectives (concepts/facts/semantics)

* .NET core concepts

* C# and objective oriented concepts required for .NET

* Visual Studio

### Procedural Memory Objectives (learn by doing/type and hand write code)

* Write a calculator console application. (Visual Studio)

* Hand write simple OOP hello world application
**Goal of this activity is to have students remember basic objective oriented programming principles that are needed for a simple a web application.

* Write a simple ASP.NET web application (Visual Studio)

# Class Slides

*Add link to google slide show for instructor to use.

# Instructor Notes

This lesson was designed for junior to intermediate level developers. Some students may find the material to be slow, while others may be lost due to gaps in core web developement knowledge. Through out this lecture take note of the students body language along with engagement. From prior experience developers who come from java tend to have a smoother transitions compared to a developer who only use's javascript,css, and html for their web stack. Python developers tend to also have a smooth transition assuming they worked on django and flask stacks.

Have your TA observe the class setting and try to explain concepts discussed today by comparing it to the stack that they are most comfortable with.

---

### 1. Instructor Do: Course assumptions and pace (2 min)

Share with students the structure of the course and assumptions. It is assumed that students know the fundamentals of programming and some basic objective oriented programming principles.

Encouarge students to use this [programming reivew](https://dotnet.microsoft.com/learn/dotnet/architecture-guides) link to refresh on any concept that they may feel rusty on.

### 2. Instructor Do: Introduce .NET  (15 min)
Microsoft .NET has been around for two decades. Microsoft began to first build .NET in the 90's but did not release their first build until 2000. In contrast to popular belief by non-technical individuals (cough cough recruiters), .NET or dotnet (that's how it is acutally pronouce) is a software framework not a programming language. That being said think of .NET as a bucket that holds common runtime enviroments,libraries, and other common type systems. Now that we clearify that let's talk about how we develope on this framework. (**Clearify to the students that the term framework alone is a generic term used to describe many software kits.Therefore .NET Framework and .NET Core (what we will be using) both use the .NET software Framework**) There are many ways write on the .NET Framework languages such as vb.net,F#,J#,C++, and C# can be used. The most common language and the one we will use in this course is C# (aka like java but you don't have to worry about memory management as much). 

![C#_2_.NET](https://docs.microsoft.com/zh-tw/dotnet/csharp/getting-started/media/netarchitecture.png)

As we can see in the diagram above, one would write C# code, which would then get compiled to .NET compliant code (intermediate language). IL code will then be consumed by the CLR(common language runtime) and converted into platform specific code by the JIT (just-in-time) compiler. What was discribed above all happends **under the hood** and thats the magic behind this framework. By getting the code into a compliant language, we can now benefit from microsofts powerful libraries.

**Depending on the audiance skill level and intrest level go over this in detail, if the audiance is not intrested glaze over this and jump to the next image.**

The image below depicts a high-level view of the microsoft .NET software platform. .NET Framework is the predecessor to .NET Core, where .NET Framework was developed for windows operating systems. .NET Core is new and microsofts goal with developing this framework was the participate in the open-source/cross platform race currently going on. In short Xamarin is cross platform .NET for mobile developement.

![.NET_IMG](https://www.intelegain.com/wp-content/uploads/2018/06/xNet-Standerd-Library.png.pagespeed.ic.Ur3-yx6RAs.png)

Today many legacy systems are running in visual basic or older versions of .NET framework. Despite the age and decades of success, Microsoft keeps pooring billions into their platform and continues to enhance their cloud offerings. Along with visual studio(The ide that we will use) and the upcoming release's of .NET Core , it is becoming easier to bridge local software developement with azure(microsoft cloud). 

Resources: ![.NET Architecture guides](https://dotnet.microsoft.com/learn/dotnet/architecture-guides)

The package manager used in this stack is called ![Nuget](https://www.nuget.org/) 

---
### 4. Instructor Do: go over basic syntaxs (5 min)
C# is an objective oriented programming language. Work in classes, use methods to preform actions or operations, and declare properties to store values. 

In C# a namespace is used to denote as a set of classes. The goal of a namespace is to provide isolation amount classes with the same name.
```c#
namespace Boy
{
    class Name
    {
        public first {get; set;}
        public last {get; set; }
        
    }
}
```
Notice how you have the same Name class in the same program. This is possible because each Name class is in a seperate namespace.
``` c#
namespace Girl
{
    class Name
    {
        public first {get; set;}
        public last {get; set; }
        
    }
}

```
Methods are define as such
```
public int func(int a, int b)
{
    int retval = a + b;
    return retval;
}

```
Share this reasource with students for more syntax documentation [c#](https://www.tutorialspoint.com/csharp/index.htm)

### 5. Instructor Do: Talk about visual studio and create sample project (5 min)
![Visual_Studio](https://visualstudio.microsoft.com/wp-content/uploads/2019/06/combined-gif2sl.gif)

The solution file to this sample project is located ![here](https://github.com/Juan-Zambrano/Sample_Lesson_Plan/tree/master/1/Activites/Ins_console_App/Solved)

Run this application in debug mode and highlight on some of features that visual studio provides. Meantion to students that there is some slight difference's between visual studio on windows,mac, and linux. 

Create a console app that is similar to the app below. Make sure it is a calculator team with the two methods below since we will be further enhancing this idea throughout this lecture. Make sure to high-light on some of visual studio dominant features such as intellisense,debug mode, break point, and accessing the nuget package.

For more reference on visual studio refer to this ![link](https://visualstudio.microsoft.com/vs/features/net-development/)

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
Popcorn call on 4 different students with the option to phone a friend and ask them to describe what one of these means. The act of them explaining in their own words should warm their brain up for the next execerise. 

### 7. Student Do (Individual Activity): Programming the rust out on paper. (5 min)
Have students write with pen and paper a class that contains a method called main(). The method will write "hello world" to a console.
This activity needs to be done in c#. Emphasize to the students that the best way to fully learn a new language is to write it down with pen/pencil and paper. This is a form of procedural learning.

Answer is below in code
```
Using System;
namespace Whatever_they_call_it
{
    public program
    {
        public static void main()
        {
            Console.writeline("Hello World");
        }
    }
}
```
Most students will miss the namespace part and the using system block. Take this as an opportunity to reinforce those two concepts.

### 8. Instructor Do: Introduce the web stack of .NET (5 min)
There are many approaches to web development in the .NET Platform, where the most commandly know one is ASP.NET MVC. For the purpose of this lecture we will focus on ASP.NET RAZOR Page web app, since it has less components to manage and is more beginner friendly.  In future lectures we will build on the this idea and work our way into a more enterprise platform such as ASP.NET MVC. In ASP.NET RAZOR Page there isnt any complicated middle-ware or need for true server-client modeling or design patterns such as model-view-controller(MVC).

Explaining to students that by using the .Net framework for web , you do not have to write client-side javascript. In fact you write in C# and microsoft magic happens.

**Warning no human javascript was written in the making of this web app** 
![](1/Activites/Stu_Calc_WebApp/final_app.PNG)

### 9. Instructor Do: Implement logic from console app into web application (8 minutes)
For the in class demo grab the ![file](https://github.com/Juan-Zambrano/Sample_Lesson_Plan/tree/master/1/Activites/Ins_Calc_WebApp) in the unsolved folder. Open it up in visual studio and fill in the comments sections with the code snippets provides below.

After this is done the students have a version that picks up the program from where the instructor left it and their final activity consist of them adding more functionalilty in a similar fashion.


For teaching and learning purpose run in debug. meantion to the student what the bin file contains but do not go into too much detail at this point.

The first file that you need to edit is the MathOperations.cs file (backend calculator logic)
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
Then front end index.cshtml file would follow, since we need to display and attach imformation from the user into a form.

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

Fianlly we edit the Index.cshtml.cs file. which is where the backend meets with the front end in order to obtain user input and preform opertations on it.

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

Encourage student to take this application and continue to add more functionalilty to it after class (eg. Tan(x),Sin(x),e^x). If time permits go over the ![solution file](https://github.com/Juan-Zambrano/Sample_Lesson_Plan/tree/master/1/Activites/Ins_Calc_WebApp/Solved/WebApplication1) during class. Begin the next class with a brief review of this activity solution.

---

### If class is 3 hours, go through the following 5 questions in order to fully assess weather students are on the right track or not.
[Part 2](https://github.com/Juan-Zambrano/Sample_Lesson_Plan/tree/master/1/Supplemental)

---
End Class

