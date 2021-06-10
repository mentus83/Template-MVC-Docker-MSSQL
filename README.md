# Template for ASP .netcore MVC Website 
> hosted in a docker container using EntityFramework Core to connect with SQL Server database
---
## Componenets
- ASP .net core 5 MVC
- EntityFramework Core
- MS SQL Server
- Angular
- Bootstrap
- AutoMapper

## Requirements for development environment
### dotnet sdk 5
Install dotnet sdk 5 from the following [link](https://dotnet.microsoft.com/download/dotnet/5.0)

### EntityFramework Core
Once dotnet cli is installed, install EntityFramework core using the following command:
`dotnet tool install dotnet-ef`

### Make
#### Windows
In order to use Makefile shortcut commands on Windows, first install Makefile package using [cygwin](https://cygwin.com/install.html)
#### Linux e.g. Ubuntu 21
`sudo apt install make`

### Docker
#### Windows
Install Docker Desktop from the following [link](https://docs.docker.com/docker-for-windows/install/)
#### Linux e.g. Ubuntu 21
`sudo apt install docker-ce docker-ce-cli containerd.io`
`sudo usermod -aG docker $USER`
##### Install docker-compose
`sudo curl -L "https://github.com/docker/compose/releases/download/1.29.2/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose`
`sudo chmod +x /usr/local/bin/docker-compose`

## Debugging
In order to run the app in debug mode and be albe to connect to the database, the connection string needs to be added as a **user** environment variable with key name `DB_CONNECTION_STRING` and the following value:
`Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true`
e.g. using PowerShell cpmmand:
`setx DB_CONNECTION_STRING "Server=.,11433;Database=ApplicationsDb;User=sa;Password=ThiIsReallySecure!3;MultipleActiveResultSets=true"`

