# Auction Web App

A web-based auction platform built with C#, HTML, and CSS. This application enables users to participate in online auctions with a clean, intuitive user interface.

## 📋 Table of Contents

- [Overview](#overview)
- [Tech Stack](#tech-stack)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Running the Application](#running-the-application)
- [Project Structure](#project-structure)
- [Contributing](#contributing)
- [License](#license)

## 🎯 Overview

The Auction Web App is a full-featured web application designed to facilitate online auction activities. Users can browse auctions, place bids, and manage their auction items in a user-friendly environment. This project demonstrates modern web development practices with server-side logic in C# and a responsive front-end interface.

## 🛠️ Tech Stack

| Technology | Purpose | Percentage |
|-----------|---------|-----------|
| **C#** | Backend logic and server-side processing | 69% |
| **HTML** | Page structure and markup | 25.1% |
| **CSS** | Styling and visual design | 5.6% |
| **JavaScript** | Client-side interactivity | 0.3% |

### Framework & Tools
- **ASP.NET** - Web application framework
- **Visual Studio** or **Visual Studio Code** - Development environment
- **Git** - Version control

## ✨ Features

- 🏷️ **Auction Listings** - Browse active and completed auctions
- 💰 **Bidding System** - Place and manage bids on auction items
- 👤 **User Accounts** - Create and manage user profiles
- 📊 **Auction Management** - Create and manage your own auctions
- 🔍 **Search & Filter** - Find auctions by category, price range, or keyword
- ⏰ **Real-time Updates** - Live auction timers and bid notifications

## 📋 Prerequisites

Before you begin, ensure you have the following installed on your system:

- **.NET Framework** or **.NET Core** (version 6.0 or higher recommended)
- **Git** (for cloning the repository)
- **Visual Studio 2019+** or **Visual Studio Code** with C# extensions
- **IIS Express** (included with Visual Studio) or another web server

## 📦 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/Feawos/Auction-Web-App.git
cd Auction-Web-App
```

### 2. Open the Project

**Using Visual Studio:**
- Open Visual Studio
- Go to `File` > `Open` > `Project/Solution`
- Navigate to the cloned folder and select the `.sln` file

**Using Visual Studio Code:**
- Open the folder in VS Code
- Install the "C#" extension by Microsoft (if not already installed)

### 3. Restore Dependencies

```bash
dotnet restore
```

This will download and install all required NuGet packages.

## 🚀 Running the Application

### Option 1: Using Visual Studio

1. Select the project in Solution Explorer
2. Press `F5` or click the **Start Debugging** button
3. The application will launch in your default browser at `http://localhost:5000` (or the configured port)

### Option 2: Using Command Line

```bash
# Build the project
dotnet build

# Run the application
dotnet run
```

The application will be available at `http://localhost:5000` by default.

### Option 3: Using IIS Express

1. Open the project in Visual Studio
2. Select **IIS Express** from the debug dropdown
3. Press `F5` to start

## 📁 Project Structure

```
Auction-Web-App/
├── Models/              # Data models and business logic
├── Controllers/         # ASP.NET controllers
├── Views/              # HTML views and Razor templates
├── wwwroot/            # Static files (CSS, JavaScript, images)
│   ├── css/            # Stylesheets
│   ├── js/             # Client-side JavaScript
│   └── images/         # Images and assets
├── appsettings.json    # Configuration file
└── README.md           # This file
```

## 🔧 Configuration

Key configuration settings are located in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=AuctionDb;Trusted_Connection=true;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information"
    }
  }
}
```

Update these settings based on your environment and requirements.

## 📚 Development

### Building the Project

```bash
dotnet build
```

### Running Tests

```bash
dotnet test
```

### Code Style

Please follow C# naming conventions and best practices:
- Use PascalCase for class and method names
- Use camelCase for local variables
- Add XML documentation comments to public members

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add YourFeature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

## ⚠️ Known Issues

This project has 5 open issues. Please check the [Issues](https://github.com/Feawos/Auction-Web-App/issues) tab for details and known limitations.

## 📄 License

This project is provided as-is. For licensing information, please contact the repository owner.

## 👤 Author

**Feawos** - [GitHub Profile](https://github.com/Feawos)

- Created: April 2, 2024
- Last Updated: May 23, 2024

## 📞 Support

For issues, questions, or suggestions:
- Open an [Issue](https://github.com/Feawos/Auction-Web-App/issues) on GitHub
- Check the [Wiki](https://github.com/Feawos/Auction-Web-App/wiki) for additional documentation

---

**Happy Bidding! 🎉**
