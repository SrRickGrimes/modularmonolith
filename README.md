# Modular Monolith with Clean Architecture Project Templates

This repository contains two robust project templates designed for building applications using the Modular Monolith architecture with ASP.NET Core. These templates are intended to accelerate the development process of scalable and maintainable web applications.

![Modular Monolith Diagram](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/2a0783df-8487-4aa0-9b36-5b8f018a8f2a)

## Technologies

These templates integrate several modern technologies and frameworks:

- **ASP.NET Core**: Framework for building web apps and services with .NET.
- **MediatR**: Simple mediator implementation in .NET for in-process messaging.
- **FastEndpoints**: Minimalistic and fast endpoint API library for ASP.NET Core.
- **FluentValidation**: Library for building strong validation rules.
- **Ardalis Result**: Library to implement the Result Pattern.

## Templates Description

1. **Main Project Template**: Sets up the primary project structure, incorporating all necessary configurations and base setups required for a Modular Monolith architecture.
2. **Module Template**: Allows the creation of additional modules to plug into the main project, facilitating system expansion and maintenance.

## Installation

Follow these steps to use these templates on your local machine:

1. Clone or download this repository to your local machine.
2. Navigate to the directory containing the templates.
3. Run the following command to install the templates:

dotnet new install ./

Note: Execute this command within both the 'monolith' and 'module' folders located in the 'Content' directory.
![Installation Step](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/c4672b73-1b97-468f-8bcf-a75bf6b79d6a)

After installation, the templates should appear in the Visual Studio 2022 project wizard.
![Project Wizard](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/a51fe89e-a1c0-4f3e-b079-7887b00c59bc)

## Creating a New Project

Using Visual Studio 2022, set the name of your project (e.g., Server, Host, etc.).
![Set Project Name](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/717004b4-691a-47e7-b14a-4d4cc4241413)

It is recommended to use the same name for the prefix in all the namespaces of your C# classes.
![Namespace Prefix](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/81fbbaad-67c9-4291-a6f0-ba38d172ddde)

The solution should be created with two projects: an ASP.NET Core Web API and a library named `YourHostName.CrossCuttingConcerns`.
![Solution Structure](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/da2803b6-45d2-46b4-986a-2efd105579c5)

A similar process applies when installing a module. If you want to maintain consistency in your namespaces, it is advisable to use the name of your main project followed by the name of your module (e.g., `Host.MyModule`).

In the next screen, specify the name of your main project and the name of your module again. This is important because the template will update the namespaces of all projects to maintain consistency.
![Specify Project Names](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/83c5a14a-7694-4b7e-a6ee-4fe0d0636045)

Your solution should look like this:

![Final Solution View](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/c65c3b5c-aca1-409d-ae98-a85645551222)

Finally, update the project reference for `Host.CrossCuttingConcerns` in `Host.MyModule.Module`.
![Update Project Reference](https://github.com/SrRickGrimes/modularmonolith/assets/81363560/a7f0cc1d-8426-4fed-92df-a508b5eddcac)

Add the reference of `Host.MyModule.Module` to your main project (Host), and you are ready to start working! The Host will automatically add the module to your main project, and you should see a working Swagger UI showing a basic endpoint for testing.

## Contributing

Contributions are welcome! Please feel free to submit pull requests, create issues, or provide feedback on how the templates can be improved.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

