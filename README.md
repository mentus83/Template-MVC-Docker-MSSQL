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
    - Self-hosting

## Requirements for development environment
### dotnet sdk 5
Install dotnet sdk 5 from the following [link](https://dotnet.microsoft.com/download/dotnet/5.0)

### EntityFramework Core
Once dotnet cli is installed, install EntityFramework core using the following command:
`dotnet tool install dotnet-ef`

### Docker
#### Windows
Install Docker Desktop from the following [link](https://docs.docker.com/docker-for-windows/install/)
#### Linux e.g. Ubuntu 21
`sudo apt install docker-ce docker-ce-cli containerd.io`
`sudo usermod -aG docker $USER`
##### Install docker-compose
`sudo curl -L "https://github.com/docker/compose/releases/download/1.29.2/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose`
`sudo chmod +x /usr/local/bin/docker-compose`

### Make
#### Windows
In order to use Makefile shortcut commands on Windows, first install Makefile package using [cygwin](https://cygwin.com/install.html)
#### Linux e.g. Ubuntu 21
`sudo apt install make`

## Debugging
In order to run the app in debug mode and be albe to connect to the database, the connection string needs to be added as a **user** environment variable with key name `DB_CONNECTION_STRING` and the following value:
`Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true`
e.g. using PowerShell cpmmand:
`setx DB_CONNECTION_STRING "Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true"`

## Helpful vscode extensions
- C# (Microsoft) aka Omnisharp
- Gitignore Templates (Hasan Ali)
- Material Icon Theme (Philipp Kief)
- Docker (Microsoft)
- Markdown Preview Enhanced (Yiyi Wang)