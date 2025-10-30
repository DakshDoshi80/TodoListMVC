TodoListMVC - .NET 6 MVC To-Do List (by Daksh Doshi)
---------------------------------------------------

Framework: .NET 6.0.422
Database: LocalDB (SQL Server)

How to run:
1. Ensure .NET 6 SDK (6.0.422) and LocalDB are installed.
2. Open the solution TodoListMVC.sln in Visual Studio 2022+ OR use command-line.
3. From project folder, run:
   dotnet restore
   dotnet tool install --global dotnet-ef --version 6.0.22   (if you don't have dotnet-ef)
   dotnet ef database update   (applies included migration and creates DB)
   dotnet run

Default connection string is in appsettings.json:
Server=(localdb)\\mssqllocaldb;Database=TodoListMVC;Trusted_Connection=True;MultipleActiveResultSets=true

Notes:
- EF Core migration files (InitialCreate) are included in Migrations/.
- Your name and enrollment have been added to the header and footer.
