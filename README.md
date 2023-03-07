# icd0021-22-23-s

# install or update
dotnet tool install --global dotnet-ef
dotnet tool update --global dotnet-ef

# create migration
dotnet ef migrations add Initial --project DAL.EF.App --startup-project WebApp --context ApplicationDbContext

# apply migration
dotnet ef database update --project DAL.EF.App --startup-project WebApp --context ApplicationDbContext 


# Add nuget packages
# Microsoft.VisualStudio.Web.CodeGeneration.Design
# Microsoft.EntityFrameworkCore.SqlServer


# install tooling
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool update --global dotnet-aspnet-codegenerator

cd WebApp
# MVC
dotnet aspnet-codegenerator controller -m Owner -name OwnersController -outDir Controllers -dc ApplicationDbContext  -udl --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -m Pet   -name PetsController   -outDir Controllers -dc ApplicationDbContext  -udl --referenceScriptLibraries -f
# Rest API
dotnet aspnet-codegenerator controller -m Owner -name OwnersController -outDir Api -api -dc ApplicationDbContext  -udl --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -m Pet   -name PetsController   -outDir Api -api -dc ApplicationDbContext  -udl --referenceScriptLibraries -f