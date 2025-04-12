# SupplyChainManagementSystem

[![Build Main](https://github.com/rfalanga/SupplyChainManagementSystem/actions/workflows/dotnet.yml/badge.svg)](https://github.com/rfalanga/SupplyChainManagementSystem/actions/workflows/dotnet.yml)

I'm following along in a tutorial named "Building Modern Web Applications Using Blazor ASP.NET Core" by Joydip Kanjilal, in the March/April 2025 edition of CODE Magazine. This application is from the section of that article, titled, "Create a New Blazor Server Applicaiton in .NET 9 and Visual Studio 2022".

This application is a simplified example of a microservices application.

## Caveats

As before, I'm using .NET 7 for the Blazor Server application. However, Joydip Kanjilal mentioned this time that .NET 7 is the last version that will support creating Blazor Server applications which easily allows for the navigation that it does. Microsoft removed that functionality with .NET 8 and newer.

The other thing is, following the instructions on p. 48 of that article, I will leave "Configure for HTTPS" checkbox, checked.

## Added three Blazor WebAssembly projects

I added two Blazor WebAssembly projects to this solution. They are named:
- SupplyChainManagementSystem.Server
- SupplyChainManagementSystem.Client

And they're all created using .NET 9. With HTTPS enabled. But this time I left off the sample pages.

### The Share project

SupplyChainManagementSystem.Shared is a Class Library project