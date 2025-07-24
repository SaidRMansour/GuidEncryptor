# GuidEncryptor

A simple C# console application that takes a user-provided GUID and returns an encrypted version using SHA-256 hashing with a salt.

## 🔐 Features

- Validates whether the input is a valid GUID
- Uses SHA-256 with a fixed salt to hash the input
- Converts the first 16 bytes of the hash to a new GUID-format string
- Simple CLI-based tool written in C#
- Easy to use and extend

## 🛠️ Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download) or later
- Visual Studio for Mac, Windows, or any text editor

## 🚀 Getting Started

### Clone the repository

```bash
git clone https://github.com/SaidRMansour/GuidEncryptor.git
cd GuidEncryptor
```

### Build and run

```bash
dotnet run
```

### Example

```
Enter a GUID: 2f1d5a87-1d43-4b15-a09e-120f54751e7b
Encrypted GUID: 7c9e6679-7425-40de-944b-e07fc1f90ae7
```

## 📁 Project Structure

- `Program.cs` – Entry point that interacts with the user
- `EncryptionHelper.cs` – Contains the SHA-256 encryption logic
- `GuidEncryptor.csproj` – Project configuration

## ⚠️ Note

This project uses a **fixed salt** for demonstration. For production, you should use a unique salt per user or per encryption.

## 📝 License

MIT License