 #r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Microsoft.Build.Engine.dll"
 #r "C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.0\Microsoft.Build.Framework.dll" 

using Microsoft.Build.BuildEngine;
using Microsoft.Build.Framework;

Engine engine = new Engine();

// Instantiate a new FileLogger to generate build log
FileLogger logger = new FileLogger();

// Set the logfile parameter to indicate the log destination
logger.Parameters = @"logfile=.\build.log";

// Register the logger with the engine
engine.RegisterLogger(logger);

// Build a project file 
bool success = engine.BuildProjectFile(@".\Example.sln");

//Unregister all loggers to close the log file
engine.UnregisterAllLoggers();

if (success)
    Console.WriteLine("Build succeeded.");
else
    Console.WriteLine(@"Build failed. View C:\temp\build.log for details");