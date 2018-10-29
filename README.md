# Codehaks.TagHelpers
### A couple of ASP.NET Core TagHelpers
This package has two fully working Tag Helpers for ASP.NET Core 2.1

### Instalation
install using nuget :
~~~code
PM > Install-Package Codehaks.TagHelpers -Version 1.1.0 
~~~

also you need to reference Codehaks.TagHelpers in you view or _viewImports.cshtml 
~~~csharp
@addTagHelper *, Codehaks.TagHelpers
~~~

you can download sample project to see it in action.


### Alert Tag Heper
Use this Tag Helper to generate Bootstrap's alert component.

#### How to use :
~~~html
<alert type="Danger" message="This is danger!"></alert>
<alert type="Success" message="And this is a success!"></alert>
~~~

you can use all alert types that bootstrap 4.1 supports like primary,secondary,danger,warning,...



![alt text](https://github.com/codehaks/Codehaks.TagHelpers/raw/master/docs/samples-alerts.png "Logo Title Text 1")

### Stars Tag Helper
Use this Tag Helper to show stars rating on your pages

#### How to use :
The default is a 5 star rating :
~~~html 
<stars level="3"></stars>
~~~

you can also have more stars, just set the count attribute to the number of stars you need.
~~~html
<stars level="4" count="10"></stars>
~~~

If you need more customization you can use other attributes.
~~~html
<stars level="3" count="5" de-active-style="color:yellowgreen;padding:3px" active-style="color:darkgreen;padding:3px"></stars>
~~~

list of all Attributes : 

Name | Function 
--- | --- 
active-class | set the class for for active stars 
active-style | use this to change colors and padding
de-active-class | same as active-class for deactive stars
de-active-style | same as active-style for deactive stars

![alt text](https://github.com/codehaks/Codehaks.TagHelpers/raw/master/docs/samples-stars.png "Logo Title Text 1")

Hope you enjoy using.





