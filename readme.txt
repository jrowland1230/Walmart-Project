Walmart Web Project
1. Download and unzip the Walmart.Web.Project.zip file (The project was Publish as Self-Contained and was extremely large, unnecessarily). I installed and used Microsoft.Packaging.Tools.Trimming which is in Preview, which removed unnecessary dependencies (tree shaking). If the project doesn't load correctly it may be an issue with “Trimming”. If you have dotnet core 2.2 installed locally you should have no issues. 
2. Run the Walmart.Web.exe
3. You'll see a command window (Kestrel is now running - web server)
4. Open a browser and type as listed in the command window -> https://localhost:5001 to begin the application.
