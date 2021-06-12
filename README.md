# Template for ASP .netcore MVC Website 
> Hosted in a docker container using EntityFramework Core to connect with SQL Server database
---
## Componenets
- Framework
    - ASP .net core 5 MVC
- Data
    - MS SQL Server
    - EntityFramework Core
    - AutoMapper
- Front-end
    - Angular
    - Bootstrap
    - Fontawesome
- Hosting Environment
    - Docker

## Requirements for development environment
### dotnet sdk 5
Install dotnet sdk 5 from the following [link](https://dotnet.microsoft.com/download/dotnet/5.0)

### EntityFramework Core v5.0.6
Once dotnet cli is installed, install EntityFramework core using the following command:
`dotnet tool install dotnet-ef`

### Docker
#### Windows
Install Docker Desktop from the following [link](https://docs.docker.com/docker-for-windows/install/)
#### Linux e.g. Ubuntu server 21
`sudo apt install docker-ce docker-ce-cli containerd.io`
`sudo usermod -aG docker $USER`
##### Install docker-compose
`sudo curl -L "https://github.com/docker/compose/releases/download/1.29.2/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose`
`sudo chmod +x /usr/local/bin/docker-compose`

### Make
#### Windows
In order to use Makefile shortcut commands on Windows, first install Makefile package using [cygwin](https://cygwin.com/install.html)
#### Linux e.g. Ubuntu server 21
`sudo apt install make`

## Libraries
### Server-Side
#### Entityframework Core
- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
#### AutoMapper
- `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection`
#### Newtonsoft Json
This package is a built-in component of .NET core. This package is needed if there is need for serializing self-referencing objects.
- `dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson`
### Client-Side
#### Angular 
Install *node.js* latest version via the following [link](https://nodejs.org/en/download/current/):
- node version: 16.2.0
- npm version: 7.15.1
    - Install Angular globally i.e. not just for this project
        - `npm install @angular/cli -g`
    - Create a new Angular project
        - `ng new MyClientName --skip-git --skip-tests --minimal --defaults`
    - Build the project into its default destination
        - `ng build`
    - Run Angular to serve the client app and view it in a browser
        - `ng serve`
#### Bootstrap
Download manually or use Visual Studio `Add` > `Client-side library` which uses Libman
#### Fontawesome
Download manually or use Visual Studio `Add` > `Client-side library` which uses Libman

## Debugging
In order to run the app in debug mode and be albe to connect to the database, the connection string needs to be added as a **user** environment variable with key name `DB_CONNECTION_STRING` and the following value:
`Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true`
e.g. using PowerShell cpmmand:
`setx DB_CONNECTION_STRING "Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true"`

## Helpful vscode extensions
- C# (Microsoft) aka Omnisharp v1.23.12
- C# Extensions (JosKreativ) v1.4.0
- Gitignore Templates (Hasan Ali) v1.0.1
- Material Icon Theme (Philipp Kief) v4.7.0
- Docker (Microsoft) v1.13.0
- Markdown Preview Enhanced (Yiyi Wang) v0.5.21

## To Be Implemented
### Views
### API Post & Delete
### Angular