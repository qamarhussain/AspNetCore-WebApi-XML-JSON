# AspNetCore-WebApi-XML-JSON
Combining JSON and XML Requests and Response in Asp.Net Core Web Api.

## Implementation

* We need to configure ConfigureServices method in Startup class, and this change will add XML data support in our
  Request and Response in our web methods
  
  ![ScreenShot](https://raw.github.com/qamarhussain/AspNetCore-WebApi-XML-JSON/master/samples/Startup.PNG)
  
  
  
 * We need to have a Model class, so that we will use it to test our app.
 
  ![ScreenShot](https://raw.github.com/qamarhussain/AspNetCore-WebApi-XML-JSON/master/samples/EmployeeModel.PNG)
  
 * We will create a EmployeeController having two web methods for Get and Post. and we will decorate both methods
   with .{format} and "FormatFilter"
   
     ![ScreenShot](https://raw.github.com/qamarhussain/AspNetCore-WebApi-XML-JSON/master/samples/EmployeeController.PNG)
     
  * For each request we have to pass response type in url
  
  ![ScreenShot](https://raw.github.com/qamarhussain/AspNetCore-WebApi-XML-JSON/master/samples/Get-Request-XML.PNG)
  
  * and for JSON response
  
  ![ScreenShot](https://raw.github.com/qamarhussain/AspNetCore-WebApi-XML-JSON/master/samples/Get-Request-JSON.PNG)
  
   * Post XML request with JSON response. 
  
  ![ScreenShot](https://raw.github.com/qamarhussain/AspNetCore-WebApi-XML-JSON/master/samples/Post-Request.PNG)
  
