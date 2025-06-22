# Greeter CLI 👋

A simple cross-platform CLI application that greets users.

This project is a **proof of concept (POC) to automatically generate, package, and release a CLI application using CI/CD (GitHub Actions)**.

## ✨ Features

- Prints a personalized greeting to the console.
- Supports command-line arguments for name, shout, and whisper options.
- Self-contained builds for Windows and Linux (no .NET install required).
- Automated versioning and releases using GitHub Actions and GitVersion.

## 📦 Download

[Download the latest version here](https://github.com/glexposito/greeter-cli/releases)

## 🚀 Usage

### 🪟 Windows

```sh
Greeter-<version>-win-x64.exe --name Alice
```

### 🐧 Linux

```sh
chmod +x Greeter-<version>-linux-x64
./Greeter-<version>-linux-x64 --name Alice
```

### ⚙️ Options

- `--name <NAME>`: Specify the name to greet.
- `--shout`: Print the greeting in uppercase.
- `--whisper`: Print the greeting in lowercase.

## 🛠️ Development

- 🧰 .NET 9.0 required for building and testing.
- 🧪 Run tests with:

  ```sh
  dotnet test tests/GreeterCli.Tests/GreeterCli.Tests.csproj
  ```

## 🚢 Release

Releases are automated via GitHub Actions. On every push to `main`, the workflow:
- Calculates the semantic version using GitVersion.
- Builds and tests the app.
- Publishes self-contained executables for Windows and Linux.
- Uploads the binaries as release assets.

---