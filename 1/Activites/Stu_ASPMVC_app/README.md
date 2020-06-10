### This activity is meant to introduce you to a mvc application in .NET.
The objective of this execrise is not to get an expert level understanding of ASP.NET, but rather to highlight how quickly and with ease
one can get a website up with ASP.NET. In further sections we will divide more into the roots behind this framework.


In the Unsolved file the application that the instructor started on is provided. Add a method to the operation class that preforms a Sin(x)
calculation.

# **Use:**
&emsp; Sin(x) ~  $\sum_{k=0}^{10} t_k$ $\frac{$(-1)^k$ $x^2k+1$}{(2k+1)!}$

***
$\mathbf{\text{Gradient Tree Boosting Algorithm}}$<br>
***
1.&emsp;Initialize model with a constant value $$f_{0}(x) = \textrm{arg min}_{\gamma} \sum \limits _{i=1} ^{N} L(y_{i}, \gamma)$$
2.&emsp;For m = 1 to M:<br>
&emsp;&emsp;(a)&emsp;For $i = 1,2,...,N$ compute<br>
    $$r_{im} = - \displaystyle \Bigg[\frac{\partial L(y_{i}, f(x_{i}))}{\partial f(x_{i})}\Bigg]_{f=f_{m−1}}$$
&emsp;&emsp;(b)&emsp;Fit a regression tree to the targets $r_{im}$ giving terminal regions<br>
&emsp;&emsp;&emsp;&emsp;$R_{jm}, j = 1, 2, . . . , J_{m}.$<br><br>
&emsp;&emsp;(c)&emsp;For $j = 1, 2, . . . , J_{m}$ compute<br>
$$\gamma_{jm} = \underset{\gamma}{\textrm{arg min}} \sum \limits _{x_{i} \in R_{jm}} L(y_{i}, f_{m−1}(x_{i}) + \gamma)$$
<br>
&emsp;&emsp;(d)&emsp;Update $f_{m}(x) = f_{m−1}(x) + \sum _{j=1} ^{J_{m}} \gamma_{jm} I(x \in R_{jm})$<br><br>
3. Output $\hat{f}(x) = f_{M}(x)$
***

Sudo code:
  
  Sin(x):
    1. Define a retval to keep track of count.
    2. Interate through expression denoted after the summation, start at 1 and end at 10.
    3. Return the value and render the result to the web-page.
    
    
  This is a hard excerise for the first lecture, so don't be discourage. Take time after class to finsh this activity and the Instructor will go
  over in the beginning of the nect lecture.
  
  **Take home**
  Despite this being a bit of a challenging assignment, look how far you have come in this lecture. Even if the functionality was not perfectly 
  implemented consider how much longer it would have taken to make a web page of this nature using plain javascript, html, and css. This is the power
  of using .NET for projects. 
