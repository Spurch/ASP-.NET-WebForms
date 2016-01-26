Each new ASP .NET WebForms project generates a lot of folders, files and code. 
The important parts of the auto-generated code we must notice:
	- Startup.cs - This is the OWIN Startup class that is used to specify application components.
	- Web.config - The main configuration file of our app, we use it to declare DB connection strings,
	  register custom EventHandlers, etc.
	- packages.config - The second most important configuration file in our app, it lists the packages
	  we are using in our app.
	- Bundle.config - Configuration file for the additional bundles we are going to use.
	- Project_Readme.html - HTML file that gives a user-friendly brief description of our project.
	- We also get some pre-initialized pages with their corresponding .cs files as an example.
	  For each page we get:
		- MyPage.aspx - the HTML, Razor... etc. tagged page that will be rendered by the browser.
		- MyPage.aspx.cs - the corresponding classes, object, events, event handlers etc. for the page.
		- MyPage.aspx.designer.cs - this is a very important file! It serves as a bridge between the 
		  other two files, giving us the connection between the view and the Code-Behind.
	- We get App_Data Folder - this is the folder to hold the Database related files.
	- App_Start Folder - this folder holds various configuration files for our app:
		- BundleConfig.cs - loads the script bundles provided.
		- IdentityConfig.cs - user authentication configuration.
		- RouteConfig.cs - app routing configuration.
		- Startup.Auth.cs - Initializes the authentication methods for the given app.
	- Content Folder - holds .css files and libraries.
	- fonts Folder - fonts related data.
	- Models Folder - contains all the object models that we'll use in our app.
	- Scripts Folder - contains all the additional scripts we are going to use. 

The idea of the Code Behind paradigm is to separate the HTML views from the code. By having our HTML
views in one file and the code in a separate .cs file we are basically separating the Presentation 
from the Business Layer giving us more flexibility when developing with ASP .NET.
		  