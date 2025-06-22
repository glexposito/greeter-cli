using System.ComponentModel;
using Spectre.Console;
using Spectre.Console.Cli;

namespace GreeterCli.App;

// ReSharper disable once ClassNeverInstantiated.Global
public sealed class Settings : CommandSettings
{
    [Description("Name of the person to greet.")]
    [CommandArgument(0, "<name>")]
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public string Name { get; init; } = "";

    [CommandOption("--shout")]
    [Description("Print in uppercase.")]
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public bool Shout { get; init; }

    [CommandOption("--whisper")]
    [Description("Print in lowercase.")]
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public bool Whisper { get; init; }

    public override ValidationResult Validate()
    {
        if (Shout && Whisper)
        {
            return ValidationResult.Error("Cannot use --shout and --whisper together.");
        }

        return ValidationResult.Success();
    }
}