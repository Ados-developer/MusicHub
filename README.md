# MusicHub 🎵
MusicHub is my first Windows Forms application, built as a desktop project to manage a music database.
It allows users to browse and manage artists, albums, and songs with a modern custom user interface.

## Features
  1. Browse artists, albums and songs.
  2. Admin users can add, edit and delete music records.
  3. Musician users can add, edit and delete his own music records.
  4. Custom Title Bar and Buttons for UI.
  5. Uses dependency injection and SQLite database for data persistence.

## Technologies
  - .NET 10 / C# / Windows Forms
  - Entity Framework Core + SQLite
  - Microsoft.Extensions.Hosting for DI
  - Visual Studio Community 2026

## Login Information
  -The login credentials are stored in the database at Data/MusicHubDbContext.

## 🚀 How to Run the Project
  1. Clone the repository
  ```bash
  git clone https://github.com/Ados-developer/MusicHub.git
  cd MusicHub
  ```
  2.Restore NuGet packages
  - In Visual Studio: Tools → NuGet Package Manager → Restore Packages
  3.Build the project
  - Open MusicHub.sln in Visual Studio → Rebuild Solution
  4.Run the application
  -Login screen appears first.
  -Use credentials stored in Data/MusicHubDbContext (or add new users via seed/migrations).
  -After login, the main MusicHub interface opens.
