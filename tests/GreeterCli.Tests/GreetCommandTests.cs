using Shouldly;
using Spectre.Console.Testing;

namespace GreeterCli.Tests;

public class GreetCommandTests
{
    private readonly CommandAppTester _tester;
    private const string Name = "John Doe";

    public GreetCommandTests()
    {
        _tester = new CommandAppTester();
        _tester.SetDefaultCommand<GreetCommand>();
    }

    [Fact]
    public void ShouldPrintUppercase_WhenShoutIsUsed()
    {
        // Act
        var result = _tester.Run($"{Name}", "--shout");

        // Assert
        result.ExitCode.ShouldBe(0);
        result.Output.ShouldContain($"HELLO, {Name.ToUpper()}!", Case.Sensitive);
    }
    
    [Fact]
    public void ShouldPrintLowercase_WhenWhisperIsUsed()
    {
        // Act
        var result = _tester.Run($"{Name}", "--whisper");

        // Assert
        result.ExitCode.ShouldBe(0);
        result.Output.ShouldContain($"hello, {Name.ToLower()}!", Case.Sensitive);
    }
    
    [Fact]
    public void ShouldPrintNormal_WhenNoOptionIsUsed()
    {
        // Act
        var result = _tester.Run($"{Name}");

        // Assert
        result.ExitCode.ShouldBe(0);
        result.Output.ShouldContain($"Hello, {Name}!", Case.Sensitive);
    }
}