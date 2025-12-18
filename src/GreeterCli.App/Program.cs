using Spectre.Console.Cli;
using GreeterCli.App.Commands;

var app = new CommandApp<GreetCommand>();
return app.Run(args);
