using Spectre.Console;
using Spectre.Console.Cli;
using GreeterCli.App;

var app = new CommandApp<GreetCommand>();
return app.Run(args);

// ReSharper disable once ClassNeverInstantiated.Global
public sealed class GreetCommand(IAnsiConsole console) : Command<Settings>
{
    public override int Execute(CommandContext context, Settings settings, CancellationToken cancellationToken)
    {
        var message = $"Hello, {settings.Name}!";

        if (settings.Shout)
        {
            message = message.ToUpper();
        }
        else if (settings.Whisper)
        {
            message = message.ToLower();
        }

        console.MarkupLine($"[green]{message}[/]");
        return 0;
    }
}