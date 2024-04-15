# dotnet --list-sdks
dotnet new globaljson --sdk-version 7.0.408 --output MySolution/MyProject
dotnet new web --no-https --output MySolution/MyProject --framework net7.0 --use-program-main
dotnet new sln -o MySolution
dotnet sln MySolution add MySolution/MyProject
Copy-Item ../ch03/PartyInvites/Program.cs MySolution/MyProject

cd MySolution/MyProject
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 7.0.12