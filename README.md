# Dr. Sillystringz's Factory

#### Description

## Contributors

* Brandon James Fenk

## Description
 This project is a simple web application for a business to keep track of Engineers and their Machines. Engineers and Machines have a many to many relationship meaning each engineer can belongs to many machines. A Engineer can have many machines. The application allows the user to create, update, delete, and view lists of the Engineers they're assigned corresponding machines. 

## Technologies Used

* _C#_
* _Html_
* _CSS_
* _ASP .NET6_
* _MySQL_
* _MVC_
* _Entity Framework Core_

## Setup/Installation Requirements

* Install MySQL Community Server and MySQL Workbench. Follow the instructions _[here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql/)_.
* Clone down the git repo ```https://github.com/BrandonF55/Sillystringz.solutions.git``` to the ```desktop``` directory
* Open the project with VSCode or a different source code editor.
* Restore required packages: change directory to ```Factory``` To use a tool called dontet-ef run ```$ dotnet tool install --global dotnet-ef --version 6.0.0
``` and in order to use dotnet-ef we also need to install ```$ dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0``` then restore with ```$ dotnet restore```
* While in the ```Factory``` directory use ```$ dotnet build``` to build the program.
* While in the ```Factory``` directory use ```$ dotnet watch run``` to run the program in the browser with a watcher.

## Database Setup

* To connect your database, create file ```appsettings.json``` in the production directory ```sillystringz_factory```
* Fill in the file with the following code: Be sure to replace the required fields marked with ```[]``` that must contain the database name, user id, and password.
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DB-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
```

## Known Bugs

<!-- * _On the client details page, the appointment link should route to appointment details instead it is routed back to client details_ -->
* If any bugs are found please email a brief description to: ```brandon.fenk99@gmail.com.com```

## License
Copyright (c) 2022 Brandon James Fenk
_[MIT](https://choosealicense.com/licenses/mit/)_