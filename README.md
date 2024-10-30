### To clone this repository

1. Open terminal and navigate to where you would like to clone
2. Clone the repository using this command: `git clone git@github.com:ezjbrewer/Presidents.git`
3. Navigate to newly created repository
4. Run `dotnet restore`
5. Install `MySQL` if not already
6. Install MySQLConnector: `dotnet add package MySQLConnector`
7. In `appsettings.json` change database username and password to your MySQL username and password
8. Install EFCore tools: `dotnet add package Microsoft.EntityFrameworkCore`
9. Adjust connection string name in `Program.cs` if needed
10. Add migrations `dotnet ef migrations add InitialCreate`
11. Update database `dotnet ef database update`

At this point you will be able to run the server
