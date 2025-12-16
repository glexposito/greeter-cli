# Greeter CLI 👋

A simple cross-platform CLI application that greets users.

The primary purpose of this repository is to serve as a **Proof of Concept (POC)**

1.  **Spectre.Console CLI Framework:** To evaluate the core capabilities of the [Spectre.Console CLI framework](https://spectreconsole.net/cli/), focusing on the basic command structure and leveraging its rich, cross-platform terminal features.
2.  **Simple CI/CD Pipeline:** To establish and test a foundational release workflow using **GitHub Actions** that achieves:
    * Automated cross-platform packaging of self-contained executables (Windows, macOS, Linux).
    * Triggered release creation on GitHub based on version tags.

## ✨ Features

- Prints a personalized greeting to the console.
- Supports command-line arguments for name, shout, and whisper options.
- Self-contained builds for Windows and Linux (no .NET install required).
- Automated versioning and releases using GitHub Actions and GitVersion.

## 📦 Download

[Download the latest version here](https://github.com/glexposito/greeter-cli/releases)

Under Assets, choose the file for your operating system:

- **Linux:** `greeter`
- **Windows:** `greeter.exe`

## 🚀 Usage

### 🐧 Linux

```sh
chmod +x greeter
./greeter Alice --whisper
```

### 🪟 Windows

```sh
greeter.exe Alice --whisper
```

### ⚙️ Options

- `<NAME>`: The name to greet.
- `--shout`: Prints the greeting in uppercase.
- `--whisper`: Prints the greeting in lowercase.
- `-h, --help`:	Prints help information.

Print the normal greeting when no option is used.

## 🛠️ Development

- 🧰 .NET 10.0 required for building and testing.
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
