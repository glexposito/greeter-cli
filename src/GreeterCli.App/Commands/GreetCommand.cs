using Spectre.Console;
using Spectre.Console.Cli;

namespace GreeterCli.App.Commands;

// ReSharper disable once ClassNeverInstantiated.Global
public sealed class GreetCommand(IAnsiConsole console) : Command<GreetCommandSettings>
{
    protected override int Execute(CommandContext context, GreetCommandSettings settings, CancellationToken cancellationToken)
    {
        var message = $"Hello, {settings.Name}!";

        if (settings.Shout)
        {
            message = message.ToUpperInvariant();
        }
        else if (settings.Whisper)
        {
            message = message.ToLowerInvariant();
        }

        console.MarkupLine($"[green]{message}[/]");
        return 0;
    }
}
