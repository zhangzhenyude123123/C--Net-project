#.NET Project  
*This Project is by:*
 ZHANG Zhenyu 299920  
 CHEN Jingren 299919  
 LI Guanlong 299940  
 ZHANG Jie 299929  
 LIU Ruihang 299924  
 QIAN Qian 299901  

**1.Database Design**  
ER Graph：

Students have attributes: ID, gender, name  
Class has attributes: classid,classname, grade  
A class can have multiple students, and a student can only belong to one class. So There is a many-to-one relationship between students and classes.  

**2.DataBase Table Design**  
Student
| field name | type | constraint |
| ------- | ------- | ------- |
|ssid	|int	|primary key|
|sname	|nvarchar| 	null|
|ssex	|nvarchar|	null|
|cid	|int	|not null|

class
| field name | type | constraint |
| ------- | ------- | ------- |
|    cid  |  int |primary key|
|cname	|nvarchar	|null
|grade	|int	|not null




**3.Architecture**
In our Project, We use Layer-Architecture to develop our program.
 
1. Controller Layer
Define the user interaction process and interface presentation.
Data obtained from user controls or from the business logic layer should be displayed without any manipulation.
The acceptance of the request to the user, along with the return of data, provides the client with access to the application.

2. Business Layer
Define the business model.
Responsible for the operation of the data layer. That is to say, some data layer operations are combined.
Receive the data from the presentation layer, do the data validation on the business, and implement the business process, and finally, pass the processed data to the data access layer.

3. Data Access Layer
Responsible for interacting with database for data storage and query.
It is the operation layer of non-original data (database or text file storage data form), rather than the original data, that is to say, is the operation of the database, rather than the data, specifically for the business logic layer or presentation layer to provide data services.
Interactions with the database should be handled without any business manipulation of the data.Catch exceptions that occur during database interaction, throw them, or record them.

**4. Function using**  
In our Project, We use Nuget to manage our packages, use Entity Framework to manage our Database and use Package Manager Console to perform Database initialization and changes.

*Nuget:*
NuGet (pronounced New Get) is a package manager for the Microsoft.NET development platform and is an extension to Visual Studio.NuGet makes adding, removing, and updating references to projects much easier and faster when using Visual Studio to develop applications based on the.NET Framework.
NuGet makes it easy to access packages distributed by other developers. You can also create, share, or distribute your own packages to NuGet.EntityFramework or some third-party packages commonly used in this project can be hosted on NuGet.  

*Enity Framework manages databases:*  
1. Check the DbContext class being used.
2. Find the ConnectionString used by this context class.
3. Find domain entities and extract schema-related information.
4. Create a database.
5. Insert data into the system.  

*Package Manager Console:*  
In this Console, These code enable us to change our Database.  
1. Enable-Migrations. 
Start the migration, create the Migration file, and Config file.
2. Add-Migrations Init. 
Perform migration work
3.Update-DataBase. 
Create the tables for the database and entities.  

**5. Program implementation**  

Following the guidelines, we use entity framework to realize some function. It’s known to all that the EF tool is the technology that support the development of data-oriented software applications, which is used to connect the part of the database and modify it. The way to use it include Database First, Code First and Model First. In our project, we have chosen the Code First.   
(1)	Establish the Database:  
First, we created two entity class, Student and Class, and then added some attributes to them. 
 
Next we create the database context, which is an abstraction of the database. Currently, we have two tables Student and Class, so we need to define two attributes for the database context to represent these two tables. Furthermore, there must be more than one data row in a table, so we must define a set attribute. EF uses DbSet to achieve this purpose.
We add a new file named EFDbContext used to store the database context class. 
1.	Add class Context, and make this class inherit from DbContext class. And then create a constructed function, which inherits the constructed function of the DbContext class, and through the constructed function of the DbContext class, we can create a database connection.
(DbContext is the base class of all EF-based contexts located in the EntityFramework.dll assembly., through which all tables in the database can be accessed.)
2.	The parameter in the constructor of the DbContext class is the database connection string, through which the database is created

Till now, we have established our database already. 
We could find the database(.mdf file) in the user file. 
 
(2)	Realize the function add, delete, select and update.
Add StudentHandler.cs in the DataAccess layer to realize add, delete, select and update function on Student class which realizes the interaction with the database, the same way on Class class.
We use the SqlQuery execute statements to realize the function about select. By this way, we can use SQL statement directly in our cs files.

We use Linq’s FirstOrDefault method to select the exact data for update and delete.
 
 
At last, we create Adds.cs, Deletes.cs, Selects.cs and Updates.cs in the Business layer, by transfer the function in StudentHandler.cs and Classhandler.cs in the DataAccess layer to realize all the function on two tables.
One more special point, when adding students, due to the many-to-one relationship between students and the class, there is a database limitation. When a student is added to a class, due to foreign key restrictions, the class must exist first. Here we use an exception to remind users. At the same time add students to the class.

In the Controller layer, we just set up a class named Display.cs to manage the interaction between program and users. In the Display.cs, we edit different menus to help people to choose what you want. And if your number fit, you will enter the next menu or perform some function.
In the Program.cs which has the Main function, we add a judgement to exit the program. 

**6. Perform screenshots**  
Query:  
Query a student
 
Query a class
 
Query all student from one class

Add：
Add a student and add to the class:
 
Add a class
 
Update:  
Update one student
 
Update one class
 
Delete:  
Delete a student
 
Delete one class, the students in this class are also deleted at the same time. 

If these no pictures, please serche the Readme.pdf to check.
