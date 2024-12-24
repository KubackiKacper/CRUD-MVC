# Portfolio project - .Net CRUD MVC
### The application was built using the following tools:
    - C#
    -.Net
    - Microsoft SQL Server
    - Model-View-Controller (MVC) pattern
    - HTML, CSS, JavaScript
  
### The database used in this project was downloaded from:
<https://github.com/microsoft/sql-server-samples/tree/master/samples/databases/northwind-pubs/>
The *northwind.bak* file has been included in the root directory of the application.

### Extensions used:
    dotnet add package Microsoft.EntityFrameworkCore --version 9.0.0
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.0
    dotnet add package Microsoft.AspNetCore.Razor --version 2.2.0
    dotnet add package Microsoft.AspNetCore.Razor.Runtime --version 2.2.0
    dotnet add package bootstrap --version 5.3.3
The above commands can be executed in the Visual Studio Code terminal.

### To demonstrate the application, I chose to use the *Employees* table:

![Reference Image](/Screenshots/Database_design.PNG)
![Reference Image](/Screenshots/ssms.PNG)
# Application Structure and Demonstration
The root directory of the application:

![Reference Image](/Screenshots/App_folder.PNG)

Using the MVC pattern, I created code that retrieves data from an existing database and displays it to the user in a view on the webpage:
![Reference Image](/Screenshots/main_page_view.PNG)
By clicking the button responsible for adding a new employee, the user is redirected to the corresponding page:
![Reference Image](/Screenshots/add_employee_view.PNG)
For demonstration purposes, I created a sample employee. After clicking the *Add* button, the employee is saved to the database and displayed in the view:
![Reference Image](/Screenshots/after_adding.PNG)
Editing a record is possible by clicking the "pencil" icon next to the employee's ID in the *EmployeeID* column, the user is redirected to the edit page:
![Reference Image](/Screenshots/edit_view.PNG)
After making changes and clicking the *Save* button, the record in the database is updated and presented:
![Reference Image](/Screenshots/after_change.PNG)
By clicking the "trash" icon in the *Delete* column, a confirmation message is displayed. Upon confirming, the record is removed from the database and the view:
![Reference Image](/Screenshots/delete.PNG)
![Reference Image](/Screenshots/after_delete.PNG)
